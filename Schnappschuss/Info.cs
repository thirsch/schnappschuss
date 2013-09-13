#region Copyright (c) 2008 Thomas A. Hirsch, All Rights Reserved.
/*
 * $LastChangedBy: thirsch $
 * $LastChangedDate: 2008-07-24 12:51:30 +0200 (Thu, 24 Jul 2008) $
 *
 * $HeadURL: http://subversion.assembla.com/svn/Schnappschuss/trunk/Schnappschuss/Schnappschuss/Info.cs $
 *
 * Author: Thomas A. Hirsch <thirschfamily@gmail.com>
 * Version: $Revision: aae7279ad7dd $
*/
#endregion

using System;
using System.Reflection;
using System.Windows.Forms;

namespace De.THirsch.Schnappschuss
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();

            lblTitle.Text = AssemblyTitle;
            lblVersion.Text = String.Format("Version {0}.{1} (r{2})", AssemblyVersion.Major, AssemblyVersion.Minor, AssemblyVersion.Build);
            lblCopyright.Text = AssemblyCopyright;
        }

        public string AssemblyTitle
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    var titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public Version AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
            }
        }
    }
}
