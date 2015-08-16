using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace PerformanceAppraisal.Utilities
{
    /// <summary>
    /// Class to manage the available themes in
    /// the application
    /// </summary>
    public class ThemeManager
    {
        public static List<Theme> RetrieveThemes()
        {
            //get the application theme directory
            DirectoryInfo dInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/App_Themes"));

            //get all subdirectories in the App_Themes folder
            DirectoryInfo[] dInfoArray = dInfo.GetDirectories();

            List<Theme> lstThemes = new List<Theme>();

            //iterate through each subdirectories in DirectoryInfo array
            foreach(DirectoryInfo dInfoTemp in dInfoArray)
            {
                Theme tempTheme = new Theme(dInfoTemp.Name);
                lstThemes.Add(tempTheme);
            }

            return lstThemes;
        }
    }
}