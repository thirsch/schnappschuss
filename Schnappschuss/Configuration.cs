#region Copyright (c) 2008 Thomas A. Hirsch, All Rights Reserved.
/*
 * $LastChangedBy: thirsch $
 * $LastChangedDate: 2008-07-24 10:13:29 +0200 (Do, 24 Jul 2008) $
 *
 * $HeadURL: https://svn.assembla.com/svn/Schnappschuss/trunk/Schnappschuss/Schnappschuss/Program.cs $
 *
 * Author: Thomas A. Hirsch <thirschfamily@gmail.com>
 * Version: $Revision: aae7279ad7dd $
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace De.THirsch.Schnappschuss
{
    public class Configuration
    {
        public FormWindowState LastWindowState { get; set; }
        public Size LastWindowSize { get; set; }
        public Point LastWindowLocation { get; set; }
        public Size LastRegionSize { get; set; }
        public Point LastRegionLocation { get; set; }
        public Dictionary<string, Profile> Profiles { get; set; }
    }
}
