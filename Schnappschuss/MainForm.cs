#region Copyright (c) 2008 Thomas A. Hirsch, All Rights Reserved.
/*
 * $LastChangedBy: thirsch $
 * $LastChangedDate: 2008-07-28 12:48:50 +0200 (Mon, 28 Jul 2008) $
 *
 * $HeadURL: http://subversion.assembla.com/svn/Schnappschuss/trunk/Schnappschuss/Schnappschuss/MainForm.cs $
 *
 * Author: Thomas A. Hirsch <thirschfamily@gmail.com>
 * Version: $Revision: aae7279ad7dd $
*/
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using De.THirsch.Schnappschuss.Properties;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using gma.System.Windows;

namespace De.THirsch.Schnappschuss
{
    public partial class MainForm : Form
    {
        private readonly ScreenshotClass _sc = new ScreenshotClass();
        private readonly UserActivityHook _actHook = new UserActivityHook();

        private bool _x;
        private bool _hidden;

        public MainForm()
        {
            InitializeComponent();
            notifyIcon.Icon = Icon;

            _actHook.KeyDown += actHook_KeyDown;
            _actHook.KeyUp += actHook_KeyUp;
            _actHook.OnMouseActivity += actHook_OnMouseActivity;

            //frmCrosshairBackground f = new frmCrosshairBackground();
            //f.ShowDialog();
        }

        private void actHook_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.LMenu:
                    this.isAlt = false;
                    break;
                case Keys.LShiftKey:
                    this.isShift = false;
                    break;
            }
        }


        private void actHook_OnMouseActivity(object sender, MouseEventArgs e)
        {
            // für das Fadenkreuzzeug...
        }

        private bool isAlt = false;
        private bool isShift = false;

        private void actHook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.LMenu:
                    this.isAlt = true;
                    break;
                case Keys.LShiftKey:
                    this.isShift = true;
                    break;
                case Keys.D3:
                    if (isAlt && isShift)
                    {
                        // create a full view screenshot
                        Size size = this._sc.DetermineScreenBounds();
                        this.createShot(new Point(0, 0), size);
                        e.Handled = true;
                    }
                    break;
                case Keys.D4:
                    if (isAlt && isShift)
                    {
                        this.Hide();
                        Application.DoEvents();

                        frmRegion fr = new frmRegion();
                        fr.FormClosed += new FormClosedEventHandler(fr_FormClosed);
                        fr.Show();
                        e.Handled = true;
                    }
                    break;
                case Keys.D5:
                    if (isAlt && isShift)
                    {
                        this._sc.SetForegroundWindow();
                        this.processScreenshot(this._sc.CreateBitmapOfForegroundWindow());
                        e.Handled = true;
                    }
                    break;
            }
        }

        void fr_FormClosed(object sender, FormClosedEventArgs e)
        {
            var fr = (Form)sender;
            if (fr.DialogResult != DialogResult.OK) return;
            fr.Hide();
            createShot(fr.Location, fr.Size);
        }

        private void bildschirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var size = _sc.DetermineScreenBounds();
            createShot(new Point(0, 0), size);
        }

        private void aktivesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Application.DoEvents();

            // take screenshot
            var screenShot = _sc.CreateBitmapOfForegroundWindow();
            _x = false;
            processScreenshot(screenShot);

            // wenn das Fenster vorher offen war, müssen
            // wir es aber auch wieder öffnen!
            if (!_hidden)
            {
                Show();
            }
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 0 || e.Y < 0)
            {
                _x = false;
            }
            if (_x)
                return;

            this._sc.SetForegroundWindow();
            _x = true;
        }

        private void ausschnittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.DoEvents();

            frmRegion fr = new frmRegion();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                this.createShot(fr.Location, fr.Size);
            }
        }

        private void createShot(Point location, Size size)
        {
            this.Hide();
            Application.DoEvents();

            Bitmap screenShot = this._sc.CreateBitmapOfRegion(location, size);

            this.processScreenshot(screenShot);

            // wenn das Fenster vorher offen war, müssen
            // wir es aber auch wieder öffnen!
            if (!this._hidden)
            {
                this.Show();
            }
        }

        private void processScreenshot(Bitmap screenShot)
        {
            if (this.pictureBox.Image != null)
                this.pictureBox.Image.Dispose();

            this.pictureBox.Image = screenShot;

            if (Settings.Default.AutosaveEnabled)
            {
                this.autosave(screenShot);
            }

            // Screenshot in Zwischenablage kopieren
            if (Settings.Default.CopyScreenshotToClipboard)
            {
                Clipboard.SetImage(screenShot);
            }

            if (Settings.Default.OpenWindowsAfterShot)
            {
                this.Show();
                this.BringToFront();
            }
        }

        private void autosave(Bitmap screenShot)
        {
            string path = Settings.Default.AutosaveLocation;
            string filetype = Settings.Default.AutosaveFiletype;
            string format = Settings.Default.AutosaveFormat;

            if (String.IsNullOrEmpty(path))
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            string filename = String.Empty;

            string findNumberRegex = @"^(?<prefix>.*){.*}(?<suffix>.*)$";
            Match m = Regex.Match(format, findNumberRegex);
            if (m.Success)
            {
                string prefix = m.Groups[1].Value;
                string suffix = m.Groups[2].Value;

                DirectoryInfo di = new DirectoryInfo(path);

                string searchMask = prefix + "*" + suffix + "." + filetype;
                string idRegex = "^" + prefix + "(?<id>.*)" + suffix + "." + filetype + "$";

                int highest = 0;

                FileInfo[] fiList = di.GetFiles(searchMask);
                foreach (FileInfo fi in fiList)
                {
                    Match idMatch = Regex.Match(fi.Name, idRegex);
                    if (idMatch.Success)
                    {
                        int currentId = Convert.ToInt32(idMatch.Groups[1].Value);
                        if (currentId > highest)
                        {
                            highest = currentId;
                        }
                    }
                }

                highest++;
                filename = String.Format(format + ".{1}", highest, filetype);
            }

            if (String.IsNullOrEmpty(filename))
            {
                filename = format + "." + filetype;

                if (File.Exists(path + "\\" + filename)
                    && MessageBox.Show("Overwrite file?", this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    filename = null;
                }
            }

            if (filename != null)
            {
                this.save(path + "\\" + filename, filetype);
            }
        }

        private void save(string filename, string filetype)
        {
            ImageFormat iFormat = ImageFormat.Png;
            switch (filetype)
            {
                case "gif":
                    iFormat = ImageFormat.Gif;
                    break;
                case "bmp":
                    iFormat = ImageFormat.Bmp;
                    break;
                case "jpg":
                    iFormat = ImageFormat.Jpeg;
                    break;
            }
            // suche alle vorhandenen Dateien und ermittle die für das 
            // Format gegebene höchste Nummer.
            this.pictureBox.Image.Save(filename, iFormat);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void frmShooter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                this._hidden = true;
            }
            else
            {
                // store the values
                switch (this.WindowState)
                {
                    case FormWindowState.Normal:
                        Settings.Default.LastWindowLocation = this.Location;
                        Settings.Default.LastWindowSize = this.Size;
                        Settings.Default.LastWindowState = this.WindowState;
                        break;
                    case FormWindowState.Maximized:
                        Settings.Default.LastWindowState = this.WindowState;
                        break;
                }

                Settings.Default.Save();

                if (this.pictureBox.Image != null)
                {
                    this.pictureBox.Image.Dispose();
                    this.pictureBox.Image = null;
                }
                this.pictureBox.Dispose();

            }
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showOptions(FormStartPosition.CenterParent);
        }

        private void showOptions(FormStartPosition formStartPosition)
        {
            var options = new Options { StartPosition = formStartPosition };
            options.ShowDialog(this);
        }

        private void frmShooter_Load(object sender, EventArgs e)
        {
            // restore state
            if (!Settings.Default.LastWindowSize.IsEmpty)
            {
                this.Location = Settings.Default.LastWindowLocation;
                this.Size = Settings.Default.LastWindowSize;
                this.WindowState = Settings.Default.LastWindowState;
            }
        }

        private void beendenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.closeApplication();
        }

        private void closeApplication()
        {
            Application.Exit();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeApplication();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this._hidden = false;
        }

        private void sichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] parts = this.saveFileDialog.FileName.Split('.');
                this.save(this.saveFileDialog.FileName, parts[parts.Length - 1]);
            }
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO : Prüfe ob das Bild gespeichert ist.
            if (this.pictureBox.Image != null)
            {
                this.pictureBox.Image.Dispose();
                this.pictureBox.Image = null;
            }
        }

        private void einstellungenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showOptions(FormStartPosition.CenterScreen);
        }
    }
}
