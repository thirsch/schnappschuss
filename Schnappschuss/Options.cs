#region Copyright (c) 2008 Thomas A. Hirsch, All Rights Reserved.
/*
 * $LastChangedBy: thirsch $
 * $LastChangedDate: 2008-07-24 17:52:53 +0200 (Thu, 24 Jul 2008) $
 *
 * $HeadURL: http://subversion.assembla.com/svn/Schnappschuss/trunk/Schnappschuss/Schnappschuss/frmRegion.cs $
 *
 * Author: Thomas A. Hirsch <thirschfamily@gmail.com>
 * Version: $Revision: aae7279ad7dd $
*/
#endregion

using System;
using System.Windows.Forms;
using De.THirsch.Schnappschuss.Properties;

namespace De.THirsch.Schnappschuss
{
    public partial class Options : Form
    {
        private readonly ToolTip _toolTip = new ToolTip();

        public Options()
        {
            InitializeComponent();

            chkCopyScreenshotToClipboard.Checked = Settings.Default.CopyScreenshotToClipboard;
            chkOpenMainwindowAfterShot.Checked = Settings.Default.OpenWindowsAfterShot;
            chkAutosave.Checked = Settings.Default.AutosaveEnabled;
            txtFormat.Text = Settings.Default.AutosaveFormat;
            cmbFiletype.Text = Settings.Default.AutosaveFiletype;
            txtLocation.Text = Settings.Default.AutosaveLocation;
            if (String.IsNullOrEmpty(txtLocation.Text))
            {
                txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            if (chkAutosave.Checked)
            {
                tmrSamples.Enabled = true;
            }

            prepareSample();
        }

        private void txtPrefix_TextChanged(object sender, EventArgs e)
        {
            prepareSample();
        }

        private void prepareSample()
        {
            var r = new Random();
            var currentImg = r.Next(1, 999);

            try
            {
                txtSample.Text = String.Format(txtFormat.Text + ".{1}", currentImg, cmbFiletype.Text);
                _toolTip.SetToolTip(txtSample, null);
                errorProvider.SetError(txtFormat, null);
            }
            catch
            {
                txtSample.Text = "Fehler!";
                _toolTip.SetToolTip(txtSample, "Das aktuelle Format enthält einen Fehler!");
                errorProvider.SetError(txtFormat, "Das aktuelle Format enthält einen Fehler!");
            }
        }

        private void cmbFiletype_SelectedValueChanged(object sender, EventArgs e)
        {
            prepareSample();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.Default.AutosaveLocation = txtLocation.Text.Equals(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) ? String.Empty : txtLocation.Text;

            Settings.Default.CopyScreenshotToClipboard = chkCopyScreenshotToClipboard.Checked;
            Settings.Default.OpenWindowsAfterShot = chkOpenMainwindowAfterShot.Checked;
            Settings.Default.AutosaveEnabled = chkAutosave.Checked;
            Settings.Default.AutosaveFormat = txtFormat.Text;
            Settings.Default.AutosaveFiletype = cmbFiletype.Text;

            Settings.Default.Save();
        }

        private void chkAutosave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutosave.Checked)
            {
                txtLocation.Enabled = true;
                txtSample.Enabled = true;
                cmbFiletype.Enabled = true;
                btnChooseLocation.Enabled = true;
                txtFormat.Enabled = true;
                tmrSamples.Enabled = true;
            }
            else
            {
                txtLocation.Enabled = false;
                txtSample.Enabled = false;
                cmbFiletype.Enabled = false;
                btnChooseLocation.Enabled = false;
                txtFormat.Enabled = false;
                tmrSamples.Enabled = false;
            }
        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtLocation.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void tmrSamples_Tick(object sender, EventArgs e)
        {
            prepareSample();
        }

        private void frmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrSamples.Enabled = false;
        }
    }
}