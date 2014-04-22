using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GeoTagGPX
{
	public partial class GeoTagGPXShell : Form
	{
        delegate void SetLabelStatusCallback(string text);
		public GeoTagGPXShell()
		{
			InitializeComponent();
		}

        delegate void setEnableCallback(bool enable);
        delegate void setProgressCallback(int cur, int max);

        void enableButton(bool enable)
        {
            buttonGeoTag.Enabled = enable;
        }
        void setProgress(int cur, int max)
        {
            progressBarPhotoNum.Maximum = max;
            progressBarPhotoNum.Value = cur;
        }
		private void buttonPickPhotoLocation_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			folderBrowserDialog.Description = "Select the folder that contain photos to GeoTag";
			folderBrowserDialog.ShowDialog();
			textPhotoLocation.Text = folderBrowserDialog.SelectedPath;
			updateButtonGeoTag();
		}

		private void buttonPickGPXLocation_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			folderBrowserDialog.Description = "Select the folder that contain GPX tracks";
			folderBrowserDialog.ShowDialog();
			textGPXLocation.Text = folderBrowserDialog.SelectedPath;
			updateButtonGeoTag();
		}

	     private void buttonGeoTag_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.process));
            buttonGeoTag.Enabled = false;
            thread.Start();

        }

        private void SetLabelStatus(string text)
        {
            this.labelStatus.Text = text;
        }
        private void process()
        {
            
            string[] photoFiles = Directory.GetFiles(textPhotoLocation.Text, "*.jpg");
            string[] gpxFiles = Directory.GetFiles(textGPXLocation.Text, "*.gpx");
            GPXReader gpxReader = new GPXReader();
            gpxReader.LoadGPXFiles(gpxFiles);
            int i = 0;
            
            int count = 0;
            foreach (string file in photoFiles)
            {
                i++;
                if (progressBarPhotoNum.InvokeRequired)
                {
                    setProgressCallback d = new setProgressCallback(setProgress);
                    this.Invoke(d, new object[] { i, photoFiles.Length });
                }
                else
                {
                    setProgress(i, photoFiles.Length);
                }
                this.progressBarPhotoNum.Value = i;
                if(this.labelStatus.InvokeRequired)
                {
                    SetLabelStatusCallback d = new SetLabelStatusCallback(SetLabelStatus);
                    this.Invoke(d, new object[] {string.Format("{0}/{1}", i, photoFiles.Length)});
                }
                else
                {
                    this.labelStatus.Text = string.Format("{0}/{1}", i, photoFiles.Length);
                }
                
                if (!File.Exists(file))
                {
                    continue;
                }

                try
                {
                    decimal latitude, longitude, altitude;
                    bool updateGPSInformation = checkBoxOverwriteGPSInformation.Checked || !EXIFHelper.HasGPSInformation(file);
                    if (updateGPSInformation)
                    {
                        DateTime date, gpsDate;
                        if (EXIFHelper.GetEXIFDate(file, out date))
                        {
                            date = date.ToUniversalTime();
                            if (gpxReader.FindGPSPoint(
                                date,
                                new TimeSpan(1, 0, 0),
                                out gpsDate,
                                out latitude,
                                out longitude,
                                out altitude))
                            {
                                EXIFHelper.SetGPSInformation(
                                    file,
                                    latitude,
                                    longitude,
                                    altitude);
                                count++;
                            }
                        }

                    }
                }
                finally
                {

                }

            }
            MessageBox.Show("为" + count + "张照片添加了地理信息");
            if (this.buttonGeoTag.InvokeRequired)
            {
                setEnableCallback d = new setEnableCallback(enableButton);
                this.Invoke(d, new object[] { true });
            }
            else
            {
                enableButton(true);
            }
            
        }

		private void updateButtonGeoTag()
		{
			if (!string.IsNullOrEmpty(textPhotoLocation.Text)
				&& !string.IsNullOrEmpty(textGPXLocation.Text)
				&& System.IO.Directory.Exists(textPhotoLocation.Text)
                && hasJpegFiles()
                && System.IO.Directory.Exists(textGPXLocation.Text)
                && hasGPXFiles()
				)
			{
				buttonGeoTag.Enabled = true;
			}
			else
			{
				buttonGeoTag.Enabled = false;
			}
		}

        private bool hasJpegFiles()
        {
            string[] photoFiles = Directory.GetFiles(textPhotoLocation.Text, "*.jpg");
            labelJpegFileNum.Text = "发现" + photoFiles.Length + "张照片"; 
            if (photoFiles.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool hasGPXFiles()
        {
            string[] gpxFiles = Directory.GetFiles(textGPXLocation.Text, "*.gpx");
            labelGPXFileNum.Text = "发现" + gpxFiles.Length + "个GPX轨迹文件"; 
            return gpxFiles.Length > 0;
        }

		private void textPhotoLocation_TextChanged(object sender, EventArgs e)
		{
			updateButtonGeoTag();
		}

		private void textGPXLocation_TextChanged(object sender, EventArgs e)
		{
			updateButtonGeoTag();
		}

		private void GeoTagGPXShell_Load(object sender, EventArgs e)
		{

		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((sender as LinkLabel).Text);
        }



	}
}
