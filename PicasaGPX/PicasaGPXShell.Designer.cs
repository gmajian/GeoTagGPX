namespace GeoTagGPX
{
	partial class PicasaGPXShell
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
			this.buttonLogon = new System.Windows.Forms.Button();
			this.labelLogonInfo = new System.Windows.Forms.Label();
			this.labelAlbum = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxGPXLocation = new System.Windows.Forms.TextBox();
			this.buttonGPXLocation = new System.Windows.Forms.Button();
			this.buttonGeoTag = new System.Windows.Forms.Button();
			this.checkBoxOverwriteGPSInformation = new System.Windows.Forms.CheckBox();
			this.buttonClearGPS = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBoxAlbum = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxPicasaUseUTC = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.labelInformation = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonLogon
			// 
			this.buttonLogon.Location = new System.Drawing.Point(266, 25);
			this.buttonLogon.Name = "buttonLogon";
			this.buttonLogon.Size = new System.Drawing.Size(75, 23);
			this.buttonLogon.TabIndex = 1;
			this.buttonLogon.Text = "Logon Picasa";
			this.buttonLogon.UseVisualStyleBackColor = true;
			this.buttonLogon.Click += new System.EventHandler(this.buttonLogon_Click);
			// 
			// labelLogonInfo
			// 
			this.labelLogonInfo.AutoSize = true;
			this.labelLogonInfo.Location = new System.Drawing.Point(8, 30);
			this.labelLogonInfo.Name = "labelLogonInfo";
			this.labelLogonInfo.Size = new System.Drawing.Size(192, 13);
			this.labelLogonInfo.TabIndex = 2;
			this.labelLogonInfo.Text = "You need to not logon Picasa Web first";
			// 
			// labelAlbum
			// 
			this.labelAlbum.AutoSize = true;
			this.labelAlbum.Location = new System.Drawing.Point(10, 26);
			this.labelAlbum.Name = "labelAlbum";
			this.labelAlbum.Size = new System.Drawing.Size(84, 13);
			this.labelAlbum.TabIndex = 5;
			this.labelAlbum.Text = "Select an Album";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Pick the folder for GPX tracks";
			// 
			// textBoxGPXLocation
			// 
			this.textBoxGPXLocation.Location = new System.Drawing.Point(13, 120);
			this.textBoxGPXLocation.Name = "textBoxGPXLocation";
			this.textBoxGPXLocation.Size = new System.Drawing.Size(225, 20);
			this.textBoxGPXLocation.TabIndex = 7;
			this.textBoxGPXLocation.TextChanged += new System.EventHandler(this.textBoxGPXLocation_TextChanged);
			// 
			// buttonGPXLocation
			// 
			this.buttonGPXLocation.Location = new System.Drawing.Point(268, 117);
			this.buttonGPXLocation.Name = "buttonGPXLocation";
			this.buttonGPXLocation.Size = new System.Drawing.Size(75, 23);
			this.buttonGPXLocation.TabIndex = 8;
			this.buttonGPXLocation.Text = "Browser";
			this.buttonGPXLocation.UseVisualStyleBackColor = true;
			this.buttonGPXLocation.Click += new System.EventHandler(this.buttonGPXLocation_Click);
			// 
			// buttonGeoTag
			// 
			this.buttonGeoTag.Enabled = false;
			this.buttonGeoTag.Location = new System.Drawing.Point(26, 359);
			this.buttonGeoTag.Name = "buttonGeoTag";
			this.buttonGeoTag.Size = new System.Drawing.Size(144, 23);
			this.buttonGeoTag.TabIndex = 9;
			this.buttonGeoTag.Text = "GeoTag!";
			this.buttonGeoTag.UseVisualStyleBackColor = true;
			this.buttonGeoTag.Click += new System.EventHandler(this.buttonGeoTag_Click);
			// 
			// checkBoxOverwriteGPSInformation
			// 
			this.checkBoxOverwriteGPSInformation.AutoSize = true;
			this.checkBoxOverwriteGPSInformation.Location = new System.Drawing.Point(13, 146);
			this.checkBoxOverwriteGPSInformation.Name = "checkBoxOverwriteGPSInformation";
			this.checkBoxOverwriteGPSInformation.Size = new System.Drawing.Size(188, 17);
			this.checkBoxOverwriteGPSInformation.TabIndex = 10;
			this.checkBoxOverwriteGPSInformation.Text = "Overwrite existing GPS information";
			this.checkBoxOverwriteGPSInformation.UseVisualStyleBackColor = true;
			// 
			// buttonClearGPS
			// 
			this.buttonClearGPS.Location = new System.Drawing.Point(214, 359);
			this.buttonClearGPS.Name = "buttonClearGPS";
			this.buttonClearGPS.Size = new System.Drawing.Size(130, 23);
			this.buttonClearGPS.TabIndex = 11;
			this.buttonClearGPS.Text = "Clear GPS information";
			this.buttonClearGPS.UseVisualStyleBackColor = true;
			this.buttonClearGPS.Click += new System.EventHandler(this.buttonClearGPS_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelLogonInfo);
			this.groupBox1.Controls.Add(this.buttonLogon);
			this.groupBox1.Location = new System.Drawing.Point(15, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(358, 64);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Logon";
			// 
			// comboBoxAlbum
			// 
			this.comboBoxAlbum.FormattingEnabled = true;
			this.comboBoxAlbum.Location = new System.Drawing.Point(13, 52);
			this.comboBoxAlbum.Name = "comboBoxAlbum";
			this.comboBoxAlbum.Size = new System.Drawing.Size(225, 21);
			this.comboBoxAlbum.TabIndex = 4;
			this.comboBoxAlbum.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlbum_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxPicasaUseUTC);
			this.groupBox2.Controls.Add(this.labelAlbum);
			this.groupBox2.Controls.Add(this.checkBoxOverwriteGPSInformation);
			this.groupBox2.Controls.Add(this.comboBoxAlbum);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.buttonGPXLocation);
			this.groupBox2.Controls.Add(this.textBoxGPXLocation);
			this.groupBox2.Location = new System.Drawing.Point(13, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(360, 183);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Select";
			// 
			// checkBoxPicasaUseUTC
			// 
			this.checkBoxPicasaUseUTC.AutoSize = true;
			this.checkBoxPicasaUseUTC.Location = new System.Drawing.Point(201, 26);
			this.checkBoxPicasaUseUTC.Name = "checkBoxPicasaUseUTC";
			this.checkBoxPicasaUseUTC.Size = new System.Drawing.Size(148, 17);
			this.checkBoxPicasaUseUTC.TabIndex = 11;
			this.checkBoxPicasaUseUTC.Text = "This album use UTC Time";
			this.checkBoxPicasaUseUTC.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.progressBar1);
			this.groupBox3.Controls.Add(this.labelInformation);
			this.groupBox3.Location = new System.Drawing.Point(16, 277);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(356, 57);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Informaton";
			// 
			// labelInformation
			// 
			this.labelInformation.AutoSize = true;
			this.labelInformation.Location = new System.Drawing.Point(17, 25);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(0, 13);
			this.labelInformation.TabIndex = 0;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(10, 20);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(330, 23);
			this.progressBar1.TabIndex = 1;
			// 
			// PicasaGPXShell
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 394);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.buttonClearGPS);
			this.Controls.Add(this.buttonGeoTag);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Name = "PicasaGPXShell";
			this.Text = "PicasaGPXShell";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonLogon;
		private System.Windows.Forms.Label labelLogonInfo;
		private System.Windows.Forms.Label labelAlbum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxGPXLocation;
		private System.Windows.Forms.Button buttonGPXLocation;
		private System.Windows.Forms.Button buttonGeoTag;
		private System.Windows.Forms.CheckBox checkBoxOverwriteGPSInformation;
		private System.Windows.Forms.Button buttonClearGPS;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBoxAlbum;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label labelInformation;
		private System.Windows.Forms.CheckBox checkBoxPicasaUseUTC;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}

