namespace GeoTagGPX
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.Globalization;
    using ExifUtils.Exif;

    public class EXIFHelper
    {
        static public void SetGPSInformation(
            string filename,
            decimal latitude,
            decimal longitude,
            decimal altitude)
        {
            ExifUtils.Rational<uint> altitudeRational = ExifUtils.Rational<uint>.Approximate(altitude);
            ExifProperty altiProperty = new ExifProperty(ExifTag.GpsAltitude, altitudeRational);
            altiProperty.Type = ExifType.URational;

 
            ExifPropertyCollection collection = new ExifPropertyCollection();
            AddGPSCoord(collection, latitude, ExifTag.GpsLatitude, ExifTag.GpsLatitudeRef);
            AddGPSCoord(collection, longitude, ExifTag.GpsLongitude, ExifTag.GpsLongitudeRef);
            collection.Add(altiProperty);
            string target = Path.Combine(Path.GetDirectoryName(filename), Path.GetRandomFileName());
            ExifUtils.Exif.IO.ExifWriter.AddExifData(filename, target, collection);
            File.Delete(filename);
            File.Move(target, filename);
            return;
        }

        static public bool GetEXIFDate(string filename, out DateTime result)
        {
            ExifPropertyCollection properties = ExifUtils.Exif.IO.ExifReader.GetExifData(filename, ExifTag.DateTimeOriginal);
            ExifProperty property = properties[ExifTag.DateTimeOriginal];

            if (property.Value == null)
            {
                result = DateTime.MinValue;
                return false;
            }
            result = (DateTime)property.Value;
            return true;
        }

        static public void AddGPSCoord(ExifPropertyCollection collection, decimal d, ExifTag tag, ExifTag tagRef)
        {
            ExifUtils.GpsCoordinate coord = ExifUtils.GpsCoordinate.FromDecimal(d);
            ExifUtils.Rational<uint>[] result = new ExifUtils.Rational<uint>[3];
            result[0] = coord.Degrees;
            result[1] = coord.Minutes;
            result[2] = coord.Seconds;
            ExifProperty coordProperty = new ExifProperty(tag, result);
            coordProperty.Type = ExifType.URational;
            ExifProperty coordRefProperty = new ExifProperty(tagRef, coord.Direction);
            coordRefProperty.Type = ExifType.Ascii;
            collection.Add(coordProperty);
            collection.Add(coordRefProperty);

        }
        static public bool HasGPSInformation(
            string filename)
        {

            ExifPropertyCollection properties = ExifUtils.Exif.IO.ExifReader.GetExifData(
                filename, 
                ExifTag.GpsLatitude, 
                ExifTag.GpsLatitudeRef,
                ExifTag.GpsAltitude);
            ExifProperty property = properties[ExifTag.GpsLatitude];

            return property.Value != null;
        }

        static void DebugEXIFInformation(string filename)
        {
            Image pic = Image.FromFile(filename);
            PropertyItem[] items = pic.PropertyItems;
            foreach (PropertyItem item in items)
            {
                Console.WriteLine("Id:{0} Type:{1} Value.length:{2}", item.Id, item.Type, item.Len);
            }
        }
    }
}
