using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAL.PaDataSetTableAdapters;
using PA.DAL;
using PA.BLL.DTO;

namespace PA.BLL
{
    public class DutyBLL
    {
        //private tbl_DutiesTableAdapter tblDutiesAdapter;

        //public tbl_DutiesTableAdapter Adapter
        //{
        //    get
        //    {
        //        if (tblDutiesAdapter == null)
        //            tblDutiesAdapter = new tbl_DutiesTableAdapter();
        //        return tblDutiesAdapter;
        //    }
        //}

        //public bool AddDuty(Duty duty)
        //{
        //    bool bRetVal = false;

        //    PaDataSet.tbl_DutiesDataTable dutiesDtTable = new PaDataSet.tbl_DutiesDataTable();
        //    PaDataSet.tbl_DutiesRow dutiesRow = dutiesDtTable.Newtbl_DutiesRow();

        //    if (string.IsNullOrEmpty(duty.DutyDescription))
        //        bRetVal = false;
        //    else
        //    {
        //        dutiesRow.Duty = duty.DutyDescription;
        //        dutiesRow.ResponsibilityID = duty.ResponsibilityID;
        //    }

        //    //same as DataTable.rows.Add(DataRow datarow);
        //    dutiesDtTable.Addtbl_DutiesRow(dutiesRow);

        //    int nRowsAffected = Adapter.Update(dutiesDtTable);

        //    if (nRowsAffected > 0)
        //        bRetVal = true;

        //    return bRetVal;

        //}
    }
}
