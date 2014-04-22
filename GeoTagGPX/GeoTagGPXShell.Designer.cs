namespace GeoTagGPX
{
	partial class GeoTagGPXShell
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoTagGPXShell));
            this.textPhotoLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPickPhotoLocation = new System.Windows.Forms.Button();
            this.textGPXLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPickGPXLocation = new System.Windows.Forms.Button();
            this.buttonGeoTag = new System.Windows.Forms.Button();
            this.checkBoxOverwriteGPSInformation = new System.Windows.Forms.CheckBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelJpegFileNum = new System.Windows.Forms.Label();
            this.labelGPXFileNum = new System.Windows.Forms.Label();
            this.progressBarPhotoNum = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPhotoLocation
            // 
            this.textPhotoLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textPhotoLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textPhotoLocation.Location = new System.Drawing.Point(24, 44);
            this.textPhotoLocation.Name = "textPhotoLocation";
            this.textPhotoLocation.Size = new System.Drawing.Size(219, 21);
            this.textPhotoLocation.TabIndex = 0;
            this.textPhotoLocation.TextChanged += new System.EventHandler(this.textPhotoLocation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择存放照片的文件夹";
            // 
            // buttonPickPhotoLocation
            // 
            this.buttonPickPhotoLocation.Location = new System.Drawing.Point(268, 42);
            this.buttonPickPhotoLocation.Name = "buttonPickPhotoLocation";
            this.buttonPickPhotoLocation.Size = new System.Drawing.Size(75, 21);
            this.buttonPickPhotoLocation.TabIndex = 2;
            this.buttonPickPhotoLocation.Text = "浏览";
            this.buttonPickPhotoLocation.UseVisualStyleBackColor = true;
            this.buttonPickPhotoLocation.Click += new System.EventHandler(this.buttonPickPhotoLocation_Click);
            // 
            // textGPXLocation
            // 
            this.textGPXLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textGPXLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textGPXLocation.Location = new System.Drawing.Point(24, 109);
            this.textGPXLocation.Name = "textGPXLocation";
            this.textGPXLocation.Size = new System.Drawing.Size(219, 21);
            this.textGPXLocation.TabIndex = 0;
            this.textGPXLocation.TextChanged += new System.EventHandler(this.textGPXLocation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择存放GPX轨迹的文件夹";
            // 
            // buttonPickGPXLocation
            // 
            this.buttonPickGPXLocation.Location = new System.Drawing.Point(268, 106);
            this.buttonPickGPXLocation.Name = "buttonPickGPXLocation";
            this.buttonPickGPXLocation.Size = new System.Drawing.Size(75, 21);
            this.buttonPickGPXLocation.TabIndex = 2;
            this.buttonPickGPXLocation.Text = "浏览";
            this.buttonPickGPXLocation.UseVisualStyleBackColor = true;
            this.buttonPickGPXLocation.Click += new System.EventHandler(this.buttonPickGPXLocation_Click);
            // 
            // buttonGeoTag
            // 
            this.buttonGeoTag.Enabled = false;
            this.buttonGeoTag.Location = new System.Drawing.Point(98, 173);
            this.buttonGeoTag.Name = "buttonGeoTag";
            this.buttonGeoTag.Size = new System.Drawing.Size(192, 35);
            this.buttonGeoTag.TabIndex = 3;
            this.buttonGeoTag.Text = "开始";
            this.buttonGeoTag.UseVisualStyleBackColor = true;
            this.buttonGeoTag.Click += new System.EventHandler(this.buttonGeoTag_Click);
            // 
            // checkBoxOverwriteGPSInformation
            // 
            this.checkBoxOverwriteGPSInformation.AutoSize = true;
            this.checkBoxOverwriteGPSInformation.Location = new System.Drawing.Point(24, 151);
            this.checkBoxOverwriteGPSInformation.Name = "checkBoxOverwriteGPSInformation";
            this.checkBoxOverwriteGPSInformation.Size = new System.Drawing.Size(216, 16);
            this.checkBoxOverwriteGPSInformation.TabIndex = 4;
            this.checkBoxOverwriteGPSInformation.Text = "如果照片已经包含地理信息也要覆盖";
            this.checkBoxOverwriteGPSInformation.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(302, 222);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(23, 12);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "0/0";
            // 
            // labelJpegFileNum
            // 
            this.labelJpegFileNum.AutoSize = true;
            this.labelJpegFileNum.Location = new System.Drawing.Point(199, 21);
            this.labelJpegFileNum.Name = "labelJpegFileNum";
            this.labelJpegFileNum.Size = new System.Drawing.Size(0, 12);
            this.labelJpegFileNum.TabIndex = 6;
            // 
            // labelGPXFileNum
            // 
            this.labelGPXFileNum.AutoSize = true;
            this.labelGPXFileNum.Location = new System.Drawing.Point(222, 86);
            this.labelGPXFileNum.Name = "labelGPXFileNum";
            this.labelGPXFileNum.Size = new System.Drawing.Size(0, 12);
            this.labelGPXFileNum.TabIndex = 6;
            // 
            // progressBarPhotoNum
            // 
            this.progressBarPhotoNum.Location = new System.Drawing.Point(98, 221);
            this.progressBarPhotoNum.Name = "progressBarPhotoNum";
            this.progressBarPhotoNum.Size = new System.Drawing.Size(192, 12);
            this.progressBarPhotoNum.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(141, 299);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(239, 12);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.sandcomp.com/blog/sandgeotag";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Version: 0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "由 albert (gmajian AT gmail DOT com) 制作";
            // 
            // GeoTagGPXShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.progressBarPhotoNum);
            this.Controls.Add(this.labelGPXFileNum);
            this.Controls.Add(this.labelJpegFileNum);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.checkBoxOverwriteGPSInformation);
            this.Controls.Add(this.buttonGeoTag);
            this.Controls.Add(this.buttonPickGPXLocation);
            this.Controls.Add(this.buttonPickPhotoLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textGPXLocation);
            this.Controls.Add(this.textPhotoLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeoTagGPXShell";
            this.Text = "SandGeoTag 用GPX为你的照片添加地理信息";
            this.Load += new System.EventHandler(this.GeoTagGPXShell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textPhotoLocation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPickPhotoLocation;
		private System.Windows.Forms.TextBox textGPXLocation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonPickGPXLocation;
		private System.Windows.Forms.Button buttonGeoTag;
		private System.Windows.Forms.CheckBox checkBoxOverwriteGPSInformation;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelJpegFileNum;
        private System.Windows.Forms.Label labelGPXFileNum;
        private System.Windows.Forms.ProgressBar progressBarPhotoNum;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
	}
}

