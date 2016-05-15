using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PA.DAL.PaDataSetTableAdapters;
using PA.DAL;
using PA.BLL.DTO;
using System.Data;


namespace PA.BLL
{
    public class TitleBLL
    {
        private tbl_TitleTableAdapter titleAdapter;

        public tbl_TitleTableAdapter Adapter
        {
            get
            {
                if (titleAdapter == null)
                    titleAdapter= new tbl_TitleTableAdapter();
                return titleAdapter;
            }
        }

        public PaDataSet.tbl_TitleDataTable GetTitles()
        {
            return Adapter.GetData();
        }

        public Title GetTitleByID(int nTitleID)
        {
            PaDataSet.tbl_TitleDataTable titledtable = Adapter.GetDataByID(nTitleID);
            Title title = new Title();

            if(titledtable.Rows.Count > 0)
            {
                foreach(DataRow row in titledtable.Rows)
                {
                    title.TitleID = (int)row["TitleID"];
                    title.JobTitle = (string)row["JobTitle"];
                    title.TitlePurpose = (string)row["TitlePurpose"];
                }
            }

            return title;
        }
            
    
        public bool AddTitle(string strTitleName, string strTitlePurpose)
        {
            PaDataSet.tbl_TitleDataTable titles = new PaDataSet.tbl_TitleDataTable();
            PaDataSet.tbl_TitleRow title = titles.Newtbl_TitleRow();

            title.JobTitle = strTitleName;
            title.TitlePurpose = strTitlePurpose;

            titles.Addtbl_TitleRow(title);

            int nRowsAffected = Adapter.Update(titles);

            if (nRowsAffected > 0)
                return true;
            else
                return false;
            
        }

        public bool UpdateTitle(Title title)
        {
            bool retVal = false;

            PaDataSet.tbl_TitleDataTable tDataTable = GetTitles();

            foreach(PaDataSet.tbl_TitleRow tRow in tDataTable)
            {
                if(tRow.TitleID==title.TitleID)
                {
                    tRow.JobTitle = title.JobTitle;
                    tRow.TitlePurpose = title.TitlePurpose;

                    int nRowsAffected = Adapter.Update(tRow);

                    if (nRowsAffected > 0)
                        retVal = true;
                }
            }

            return retVal;

        }
    }
}
