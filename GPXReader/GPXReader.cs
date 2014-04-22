using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

using GPX;

namespace GeoTagGPX
{
    public class TrackPoint:IComparable
    {
        public TrackPoint(DateTime time, decimal latitude, decimal longitude, decimal altitude)
        {
            this.Time = time;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Altitude = altitude;
        }

        public void Print()
        {
            Console.WriteLine("Time: {0} Lat:{1} long:{2} alt:{3}", this.Time, this.Latitude, this.Longitude, this.Altitude);
        }

        public DateTime Time { get; private set; }
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }
        public decimal Altitude { get; private set; }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            TrackPoint b = (TrackPoint)obj;
            if (this.Time == b.Time)
            {
                return 0;
            }
            else if (this.Time < b.Time)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        #endregion
    }

    public class GPXReader
    {
		private List<TrackPoint> trackPointList = null;

		public GPXReader()
		{
			trackPointList = new List<TrackPoint>();
		}

		public void LoadGPXFiles(string[] files)
        {
			foreach (string file in files)
			{
				XmlSerializer ser = new XmlSerializer(typeof(gpxType));
				using (FileStream str = new FileStream(file, FileMode.Open))
				{
					gpxType info = (gpxType)ser.Deserialize(str);

					if (info.trk != null)
					{
						MergeTracks(trackPointList, info.trk);
					}
				}
			}
            trackPointList.Sort();


        }

		public bool FindGPSPoint(
			DateTime queryDate,
			TimeSpan maxErrorTimeSpan,
			out DateTime gpsDate,
			out decimal latitude,
			out decimal longitude,
			out decimal altitude)
		{
			gpsDate = DateTime.MinValue;
			latitude = 0;
			longitude = 0;
			altitude = 0;
			int index = trackPointList.BinarySearch(new TrackPoint(queryDate, 0, 0, 0));
			TrackPoint point;
			if (index > 0)
			{
				point = trackPointList[index];
			}
			else
			{
				if (~index < 0 || ~index >= trackPointList.Count)
				{
					return false;
				}

				point = trackPointList[~index];
				if (GetAbsTimeSpan(point.Time - queryDate) > maxErrorTimeSpan)
				{
					if (~index - 1 < 0 || ~index - 1 >= trackPointList.Count)
					{
						return false;
					}
					else
					{
						point = trackPointList[~index - 1];
					}
				}
			}
			if (GetAbsTimeSpan(point.Time - queryDate) > maxErrorTimeSpan)
			{
				return false;
			}
			gpsDate = DateTime.SpecifyKind(point.Time,DateTimeKind.Utc);
			latitude = point.Latitude;
			longitude = point.Longitude;
			altitude = point.Altitude;
			return true;
		}

		static TimeSpan GetAbsTimeSpan(TimeSpan timeSpan)
		{
			if (timeSpan.CompareTo(TimeSpan.Zero) < 0)
			{
				return -timeSpan;
			}
			else
			{
				return timeSpan;
			}
		}
        static void MergeTracks(List<TrackPoint> trackPointList, trkType[] tracks)
        {
            foreach (trkType track in tracks)
            {
				foreach (trksegType seg in track.trkseg)
				{
					foreach (wptType wpt in seg.trkpt)
					{
						trackPointList.Add(new TrackPoint(wpt.time, wpt.lat, wpt.lon, wpt.ele));
					}
				}
            }
        }
    }
}