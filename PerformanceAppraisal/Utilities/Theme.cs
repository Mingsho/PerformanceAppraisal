using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerformanceAppraisal.Utilities
{
    /// <summary>
    /// A Theme class to hold the available theme names
    /// in the application.
    /// </summary>
    public class Theme
    {
        private string strTheme;

        public string theme { get { return strTheme; } set { strTheme = value; } }

        public Theme(string theme)
        {
            this.theme = theme;
        }
    }
}