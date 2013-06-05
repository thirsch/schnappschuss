using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace De.THirsch.Schnappschuss
{
    public partial class frmCrosshairBackground : Form
    {
        private frmCrosshair crosshair = new frmCrosshair();

        public frmCrosshairBackground()
        {
            InitializeComponent();

            //this.crosshair.Show();
        }

        private void frmCrosshairBackground_MouseMove(object sender, MouseEventArgs e)
        {
            //this.crosshair.Location = new Point(e.X, e.Y);
            //Application.DoEvents();
        }

        private void frmCrosshairBackground_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
