namespace De.THirsch.Schnappschuss
{
    partial class frmRegion
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(412, 212);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Place the box over the region\r\nyou want to capture and press\r\nenter to take the s" +
                "hot or\r\nesc to abort.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRegion_MouseMove);
            this.lblDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegion_MouseDown);
            this.lblDescription.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRegion_MouseUp);
            // 
            // frmRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(436, 230);
            this.ControlBox = false;
            this.Controls.Add(this.lblDescription);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegion";
            this.Opacity = 0.7;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRegion_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRegion_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegion_MouseDown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegion_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRegion_MouseMove);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegion_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;

    }
}