using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAL.PaDataSetTableAdapters;
using PA.DAL;

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

        public PaDataSet.tbl_TitleDataTable getTitles()
        {
            return Adapter.GetData();
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
    }
}
