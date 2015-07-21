using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAL;
using PA.DAL.PaDataSetTableAdapters;
using PA.BLL.DTO;

namespace PA.BLL
{
    public class ResponsibilityBLL
    {
        private tbl_ResponsibilitiesTableAdapter tblResponsibilityTblAdapter;
        private DutyBLL dutyLogic = new DutyBLL();

        protected tbl_ResponsibilitiesTableAdapter Adapter
        {
            get
            {
                if (tblResponsibilityTblAdapter == null)
                    tblResponsibilityTblAdapter = new tbl_ResponsibilitiesTableAdapter();
                return tblResponsibilityTblAdapter;
            }
        }

        public bool AddResponsibility(Responsibility responsibility)
        {
            bool bRetVal = false;

            PA.DAL.PaDataSet.tbl_ResponsibilitiesDataTable responsibilityDtable = new PaDataSet.
                tbl_ResponsibilitiesDataTable();
            PA.DAL.PaDataSet.tbl_ResponsibilitiesRow responsibilityRow = responsibilityDtable.Newtbl_ResponsibilitiesRow();

            responsibilityRow.Responsibility = responsibility.ResponsibilityDesc;
            responsibilityRow.TitleID = responsibility.TitleID;

            responsibilityDtable.Addtbl_ResponsibilitiesRow(responsibilityRow);

            int nRowsAffected = Adapter.Update(responsibilityDtable);

            int nResponsibilityId = responsibilityRow.ResponsibilityID;

            foreach(Duty duty in responsibility.LstDuties)
            {
                duty.ResponsibilityID = nResponsibilityId;
                dutyLogic.AddDuty(duty);

            }

            if (nRowsAffected > 0)
                bRetVal = true;

            return bRetVal;

        }

    }
}
