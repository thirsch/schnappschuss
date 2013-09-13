namespace De.THirsch.Schnappschuss
{
    partial class Options
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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.chkCopyScreenshotToClipboard = new System.Windows.Forms.CheckBox();
            this.chkAutosave = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFiletype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSample = new System.Windows.Forms.Label();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnChooseLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.chkOpenMainwindowAfterShot = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tmrSamples = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.pictureLogo);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(-1, -1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(414, 78);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogo.Image = global::De.THirsch.Schnappschuss.Properties.Resources.Options;
            this.pictureLogo.Location = new System.Drawing.Point(329, 4);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(76, 68);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Modifizieren Sie hier die Einstellungen der Software";
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbort.Location = new System.Drawing.Point(322, 341);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 28);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "Abbrechen";
            this.btnAbort.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(241, 341);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 28);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chkCopyScreenshotToClipboard
            // 
            this.chkCopyScreenshotToClipboard.AutoSize = true;
            this.chkCopyScreenshotToClipboard.Checked = true;
            this.chkCopyScreenshotToClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyScreenshotToClipboard.Location = new System.Drawing.Point(12, 85);
            this.chkCopyScreenshotToClipboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCopyScreenshotToClipboard.Name = "chkCopyScreenshotToClipboard";
            this.chkCopyScreenshotToClipboard.Size = new System.Drawing.Size(235, 20);
            this.chkCopyScreenshotToClipboard.TabIndex = 0;
            this.chkCopyScreenshotToClipboard.Text = "Kopiere Screenshot in die Zwischenablage";
            this.chkCopyScreenshotToClipboard.UseVisualStyleBackColor = true;
            // 
            // chkAutosave
            // 
            this.chkAutosave.AutoSize = true;
            this.chkAutosave.Checked = true;
            this.chkAutosave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutosave.Location = new System.Drawing.Point(8, 23);
            this.chkAutosave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAutosave.Name = "chkAutosave";
            this.chkAutosave.Size = new System.Drawing.Size(72, 20);
            this.chkAutosave.TabIndex = 0;
            this.chkAutosave.Text = "Aktiviert";
            this.chkAutosave.UseVisualStyleBackColor = true;
            this.chkAutosave.CheckedChanged += new System.EventHandler(this.chkAutosave_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbFiletype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSample);
            this.groupBox1.Controls.Add(this.txtSample);
            this.groupBox1.Controls.Add(this.txtFormat);
            this.groupBox1.Controls.Add(this.lblFormat);
            this.groupBox1.Controls.Add(this.btnChooseLocation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.chkAutosave);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(385, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatische Speicherung";
            // 
            // cmbFiletype
            // 
            this.cmbFiletype.FormattingEnabled = true;
            this.cmbFiletype.Items.AddRange(new object[] {
            "png",
            "jpg",
            "gif",
            "bmp"});
            this.cmbFiletype.Location = new System.Drawing.Point(261, 108);
            this.cmbFiletype.Name = "cmbFiletype";
            this.cmbFiletype.Size = new System.Drawing.Size(83, 24);
            this.cmbFiletype.TabIndex = 4;
            this.cmbFiletype.Text = "png";
            this.cmbFiletype.SelectedValueChanged += new System.EventHandler(this.cmbFiletype_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dateityp:";
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(132, 92);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(45, 16);
            this.lblSample.TabIndex = 13;
            this.lblSample.Text = "Beispiel";
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(135, 111);
            this.txtSample.Name = "txtSample";
            this.txtSample.ReadOnly = true;
            this.txtSample.Size = new System.Drawing.Size(100, 20);
            this.txtSample.TabIndex = 12;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(9, 111);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(100, 20);
            this.txtFormat.TabIndex = 3;
            this.txtFormat.Text = "img_{0:00000}";
            this.txtFormat.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(6, 92);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(48, 16);
            this.lblFormat.TabIndex = 9;
            this.lblFormat.Text = "Format:";
            // 
            // btnChooseLocation
            // 
            this.btnChooseLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseLocation.Location = new System.Drawing.Point(343, 68);
            this.btnChooseLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChooseLocation.Name = "btnChooseLocation";
            this.btnChooseLocation.Size = new System.Drawing.Size(36, 20);
            this.btnChooseLocation.TabIndex = 2;
            this.btnChooseLocation.Text = "...";
            this.btnChooseLocation.UseVisualStyleBackColor = true;
            this.btnChooseLocation.Click += new System.EventHandler(this.btnChooseLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ort:";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(8, 68);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(329, 20);
            this.txtLocation.TabIndex = 1;
            // 
            // chkOpenMainwindowAfterShot
            // 
            this.chkOpenMainwindowAfterShot.AutoSize = true;
            this.chkOpenMainwindowAfterShot.Checked = true;
            this.chkOpenMainwindowAfterShot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpenMainwindowAfterShot.Location = new System.Drawing.Point(12, 113);
            this.chkOpenMainwindowAfterShot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkOpenMainwindowAfterShot.Name = "chkOpenMainwindowAfterShot";
            this.chkOpenMainwindowAfterShot.Size = new System.Drawing.Size(234, 20);
            this.chkOpenMainwindowAfterShot.TabIndex = 4;
            this.chkOpenMainwindowAfterShot.Text = "Öffne Hauptfenster nach dem Screenshot";
            this.chkOpenMainwindowAfterShot.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Bitte wählen Sie den Speicherort für die Screenshots.";
            // 
            // tmrSamples
            // 
            this.tmrSamples.Interval = 2000;
            this.tmrSamples.Tick += new System.EventHandler(this.tmrSamples_Tick);
            // 
            // Options
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAbort;
            this.ClientSize = new System.Drawing.Size(409, 382);
            this.Controls.Add(this.chkOpenMainwindowAfterShot);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCopyScreenshotToClipboard);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptions_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox chkCopyScreenshotToClipboard;
        private System.Windows.Forms.CheckBox chkAutosave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChooseLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.ComboBox cmbFiletype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkOpenMainwindowAfterShot;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Timer tmrSamples;
    }
}