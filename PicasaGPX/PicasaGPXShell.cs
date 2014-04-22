using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Google.GData.Photos;
using Google.GData.Extensions.MediaRss;


namespace GeoTagGPX
{
	public partial class PicasaGPXShell : Form
	{
		private string authenticationToken = null;
		private string user = null;
		private PicasaFeed picasaFeed = null;
		private PicasaService picasaService = new PicasaService("PicasaGPX");

		public PicasaGPXShell()
		{
			InitializeComponent();
		}

		private void buttonLogon_Click(object sender, EventArgs e)
		{
			GoogleClientLogin googleClientLogin = new GoogleClientLogin(new PicasaService("PicasaGPX"));
			googleClientLogin.ShowDialog();
			this.authenticationToken = googleClientLogin.AuthenticationToken;
			this.user = googleClientLogin.User;
			if (this.authenticationToken != null)
			{
				picasaService.SetAuthenticationToken(this.authenticationToken);
				UpdateLogonInformation();
				UpdateAlbumInformation();
			}

		}

		private void UpdateLogonInformation()
		{
			labelLogonInfo.Text = this.user + " logged on";
		}

		private void UpdateAlbumInformation()
		{
			AlbumQuery query = new AlbumQuery();
			query.Uri = new Uri(PicasaQuery.CreatePicasaUri(this.user));

			this.picasaFeed = this.picasaService.Query(query);
			comboBoxAlbum.Items.Clear();

			if (this.picasaFeed != null && this.picasaFeed.Entries.Count > 0)
			{
				foreach (PicasaEntry entry in this.picasaFeed.Entries)
				{
					comboBoxAlbum.Items.Add(new PicasaEntryInfo(entry));
				}
				comboBoxAlbum.SelectedIndex = 0;
				labelAlbum.Text = string.Format("There are {0} albums:", this.picasaFeed.Entries.Count);
			}
		}

		private class PicasaEntryInfo
		{
			public PicasaEntry Entry { get; private set; }
			public PicasaEntryInfo(PicasaEntry entry)
			{
				this.Entry = entry;
			}

			public override string ToString()
			{
				return string.Format(
					"{0} ({1})",
					this.Entry.Title.Text,
					Entry.getPhotoExtensionValue(GPhotoNameTable.NumPhotos));
			}
		}

		private void buttonGPXLocation_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (System.IO.Directory.Exists(textBoxGPXLocation.Text))
			{
				folderBrowserDialog.SelectedPath = textBoxGPXLocation.Text;
			}
			folderBrowserDialog.ShowNewFolderButton = false;
			folderBrowserDialog.Description = "Select the folder that contain GPX tracks";
			folderBrowserDialog.ShowDialog();
			textBoxGPXLocation.Text = folderBrowserDialog.SelectedPath;
			updateButtonGeoTag();
		}

		private void updateButtonGeoTag()
		{
			if (comboBoxAlbum.SelectedItem != null
				&& !string.IsNullOrEmpty(textBoxGPXLocation.Text)
				&& System.IO.Directory.Exists(textBoxGPXLocation.Text)
				)
			{
				buttonGeoTag.Enabled = true;
			}
			else
			{
				buttonGeoTag.Enabled = false;
			}
		}

		private void textBoxGPXLocation_TextChanged(object sender, EventArgs e)
		{
			updateButtonGeoTag();
		}

		private void comboBoxAlbum_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateButtonGeoTag();
		}

		private void buttonGeoTag_Click(object sender, EventArgs e)
		{
			PicasaEntryInfo info = (PicasaEntryInfo)comboBoxAlbum.SelectedItem;
			PicasaEntry entry = info.Entry;
			int updateFileCount = UpdateGPSInformation(
				entry, 
				checkBoxOverwriteGPSInformation.Checked,
				checkBoxPicasaUseUTC.Checked);
			labelInformation.Text = String.Format("{0} photos are updated.", updateFileCount);
		}

		private int UpdateGPSInformation(PicasaEntry entry, bool overwrite, bool picasaUseUTC)
		{
			int updateFileCount = 0;
			PhotoQuery query = new PhotoQuery(entry.FeedUri);
			GPXReader gpxReader = new GPXReader();
			gpxReader.LoadGPXFiles(System.IO.Directory.GetFiles(textBoxGPXLocation.Text, "*.gpx"));


			PicasaFeed feed = this.picasaService.Query(query);

			foreach (PicasaEntry feedEntry in feed.Entries)
			{
				Console.WriteLine(feedEntry.Title.Text);
				PhotoAccessor ac = new PhotoAccessor(feedEntry);
				if (ac.Longitude != -1.0 && ac.Latitude != -1.0 && !overwrite)
				{
					continue;
				}
				DateTime date = DateTime.SpecifyKind(new DateTime(1970, 1, 1).AddMilliseconds(ac.Timestamp),DateTimeKind.Local);
				if (!picasaUseUTC)
				{
					date = date.ToUniversalTime();
				}
				decimal latitude, longitude, altitude;
				DateTime gpsDate;
				if (gpxReader.FindGPSPoint(
					date,
					new TimeSpan(1, 0, 0),
					out gpsDate,
					out latitude,
					out longitude,
					out altitude))
				{
					feedEntry.Location = new Google.GData.Extensions.Location.GeoRssWhere();
					feedEntry.Location.Latitude = (double)latitude;
					feedEntry.Location.Longitude = (double)longitude;
					feedEntry.Update();
					updateFileCount++;
				}
			}
			return updateFileCount;
		}
		private int  ClearGPSInformation(PicasaEntry entry)
		{
			int count = 0;
			PhotoQuery query = new PhotoQuery(entry.FeedUri);

			PicasaFeed feed = this.picasaService.Query(query);

			foreach (PicasaEntry feedEntry in feed.Entries)
			{
				PhotoAccessor ac = new PhotoAccessor(feedEntry);

				ac.Latitude = -1f;
				ac.Longitude = -1f;
				feedEntry.Update();
				count++;
			}
			return count;
		}

		private void buttonClearGPS_Click(object sender, EventArgs e)
		{
			PicasaEntryInfo info = (PicasaEntryInfo)comboBoxAlbum.SelectedItem;
			PicasaEntry entry = info.Entry;
			int count = ClearGPSInformation(entry);
			labelInformation.Text = String.Format("{0} photos are cleared.", count);
		}

	} 
}
