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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using De.THirsch.Schnappschuss.Properties;

namespace De.THirsch.Schnappschuss
{
    public partial class frmRegion : Form
    {
        private bool mouse = false;
        private int posX;
        private int posY;

        public frmRegion()
        {
            InitializeComponent();
        }

        private void frmRegion_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Left = this.Left + (e.X - posX);
                this.Top = this.Top + (e.Y - posY);
            }
        }

        private void frmRegion_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            posX = e.X;
            posY = e.Y;
        }

        private void frmRegion_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void frmRegion_KeyDown(object sender, KeyEventArgs e)
        {
            int move = 1;
            if ((e.Modifiers & Keys.Shift) == Keys.Shift)
            {

                move = 10;
            }

            bool alt = (e.Modifiers & Keys.Alt) == Keys.Alt;

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
                case Keys.Return:
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                case Keys.Left:
                    if (alt)
                    {
                        this.Width -= move;
                    }
                    else
                    {
                        this.Left -= move;
                    }
                    break;
                case Keys.Right:
                    if (alt)
                    {
                        this.Width += move;
                    }
                    else
                    {
                        this.Left += move;
                    }
                    break;
                case Keys.Up:
                    if (alt)
                    {
                        this.Height -= move;
                    }
                    else
                    {
                        this.Top -= move;
                    }
                    break;
                case Keys.Down:
                    if (alt)
                    {
                        this.Height += move;
                    }
                    else
                    {
                        this.Top += move;
                    }
                    break;
            }
        }

        private void frmRegion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.LastRegionLocation = this.Location;
            Settings.Default.LastRegionSize = this.Size;
            Settings.Default.Save();
        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            if (!Settings.Default.LastRegionLocation.IsEmpty)
            {
                this.Location = Settings.Default.LastRegionLocation;
                this.Size = Settings.Default.LastRegionSize;
            }
        }
    }
}
