#region Copyright (c) 2008 Thomas A. Hirsch, All Rights Reserved.
/*
 * $LastChangedBy: thirsch $
 * $LastChangedDate: 2008-07-24 18:10:51 +0200 (Thu, 24 Jul 2008) $
 *
 * $HeadURL: http://subversion.assembla.com/svn/Schnappschuss/trunk/Schnappschuss/Schnappschuss/frmOptions.cs $
 *
 * Author: Thomas A. Hirsch <thirschfamily@gmail.com>
 * Version: $Revision: aae7279ad7dd $
*/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using De.THirsch.Schnappschuss.Properties;
using System.IO;

namespace De.THirsch.Schnappschuss
{
    public partial class frmOptions : Form
    {
        private ToolTip toolTip = new ToolTip();

        public frmOptions()
        {
            InitializeComponent();

            this.chkCopyScreenshotToClipboard.Checked = Settings.Default.CopyScreenshotToClipboard;
            this.chkOpenMainwindowAfterShot.Checked = Settings.Default.OpenWindowsAfterShot;
            this.chkAutosave.Checked = Settings.Default.AutosaveEnabled;
            this.txtFormat.Text = Settings.Default.AutosaveFormat;
            this.cmbFiletype.Text = Settings.Default.AutosaveFiletype;
            this.txtLocation.Text = Settings.Default.AutosaveLocation;
            if (String.IsNullOrEmpty(this.txtLocation.Text))
            {
                this.txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            if (this.chkAutosave.Checked)
            {
                this.tmrSamples.Enabled = true;
            }

            this.prepareSample();
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            this.prepareSample();
        }

        private void prepareSample()
        {
            Random r = new Random();
            int currentImg = r.Next(1, 999);

            try
            {
                this.txtSample.Text = String.Format(this.txtFormat.Text + ".{1}", currentImg, this.cmbFiletype.Text);
                toolTip.SetToolTip(this.txtSample, null);
                errorProvider.SetError(this.txtFormat, null);
            }
            catch
            {
                this.txtSample.Text = "Fehler!";
                toolTip.SetToolTip(this.txtSample, "Das aktuell Format enthält einen Fehler!");
                errorProvider.SetError(this.txtFormat, "Das aktuelle Format enthält einen Fehler!");
            }
        }

        private void cmbFiletype_SelectedValueChanged(object sender, EventArgs e)
        {
            this.prepareSample();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtLocation.Text.Equals(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)))
            {
                Settings.Default.AutosaveLocation = String.Empty;
            }
            else
            {
                Settings.Default.AutosaveLocation = this.txtLocation.Text;
            }

            Settings.Default.CopyScreenshotToClipboard = this.chkCopyScreenshotToClipboard.Checked;
            Settings.Default.OpenWindowsAfterShot = this.chkOpenMainwindowAfterShot.Checked;
            Settings.Default.AutosaveEnabled = this.chkAutosave.Checked;
            Settings.Default.AutosaveFormat = this.txtFormat.Text;
            Settings.Default.AutosaveFiletype = this.cmbFiletype.Text;

            Settings.Default.Save();
        }

        private void chkAutosave_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAutosave.Checked)
            {
                this.txtLocation.Enabled = true;
                this.txtSample.Enabled = true;
                this.cmbFiletype.Enabled = true;
                this.btnChooseLocation.Enabled = true;
                this.txtFormat.Enabled = true;
                this.tmrSamples.Enabled = true;
            }
            else
            {
                this.txtLocation.Enabled = false;
                this.txtSample.Enabled = false;
                this.cmbFiletype.Enabled = false;
                this.btnChooseLocation.Enabled = false;
                this.txtFormat.Enabled = false;
                this.tmrSamples.Enabled = false;
            }
        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.SelectedPath = this.txtLocation.Text;
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtLocation.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        private void tmrSamples_Tick(object sender, EventArgs e)
        {
            this.prepareSample();
        }

        private void frmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tmrSamples.Enabled = false;
        }
    }
}
