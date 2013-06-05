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

namespace De.THirsch.Schnappschuss
{
    public class Profile
    {
        public bool CopyScreenshotToClipboard { get; set; }
        public bool OpenWindowAfterShot { get; set; }
        public bool AutosaveEnabled { get; set; }
        public string AutosaveFormat { get; set; }
        public string AutosaveFiletype { get; set; }
        public string AutosaveLocation { get; set; }
    }
}
