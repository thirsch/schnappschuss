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
    public partial class frmCrosshair : Form
    {
        public frmCrosshair()
        {
            InitializeComponent();
        }

        private void frmCrosshair_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmCrosshair_Move(object sender, EventArgs e)
        {
            this.lblX.Text = this.Location.X.ToString();
            this.lblY.Text = this.Location.Y.ToString();
        }
    }
}
