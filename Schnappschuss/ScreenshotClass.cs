#region Copyright (c) 2008 Thomas A. Hirsch, All Rights Reserved.
/*
 * $LastChangedBy: thirsch $
 * $LastChangedDate: 2008-07-24 10:13:29 +0200 (Thu, 24 Jul 2008) $
 *
 * $HeadURL: http://subversion.assembla.com/svn/Schnappschuss/trunk/Schnappschuss/Schnappschuss/ScreenshotClass.cs $
 *
 * Author: Thomas A. Hirsch <thirschfamily@gmail.com>
 * Version: $Revision: aae7279ad7dd $
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace De.THirsch.Schnappschuss
{
    public class ScreenshotClass
    {
        private IntPtr ptr = IntPtr.Zero;

        #region DllImports
        /*
         * The following imports are required to determine the current foreground window.
         */
        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32")]
        public extern static IntPtr GetForegroundWindow();

        [DllImport("user32")]
        public extern static int GetWindowRect(IntPtr handle, out Rect lpRect);
        #endregion

        public Bitmap CreateBitmapOfRegion(Point location, Size size)
        {
            Bitmap result = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(result);
            g.CopyFromScreen(location, new Point(0, 0), size);
            g.Dispose();

            return result;
        }

        public Size DetermineScreenBounds()
        {
            return new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        public void SetForegroundWindow()
        {
            this.ptr = GetForegroundWindow();
        }

        public Bitmap CreateBitmapOfForegroundWindow()
        {
            Rect r;
            GetWindowRect(ptr, out r);
            Rectangle re = new Rectangle(r.Left, r.Top, r.Right - r.Left, r.Bottom - r.Top);
            
            return this.CreateBitmapOfRegion(new Point(re.Left, re.Top), new Size(re.Width, re.Height));
        }

    }
}
