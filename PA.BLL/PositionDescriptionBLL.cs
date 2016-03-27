using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAL.PaDataSetTableAdapters;
using PA.DAL;


namespace PA.BLL
{
    public class PositionDescriptionBLL
    {
        private tbl_PositionDescriptionTableAdapter PdAdapter;

        public tbl_PositionDescriptionTableAdapter Adapter
        {
            get
            {
                if (PdAdapter == null)
                    PdAdapter = new tbl_PositionDescriptionTableAdapter();

                return PdAdapter;
            }
        }

        /// <summary>
        /// Method to get all position descriptions
        /// </summary>
        /// <returns>tbl_PositionDescriptionDataTable</returns>
        public PaDataSet.tbl_PositionDescriptionDataTable GetPositionDescriptions()
        {
            return Adapter.GetData();
        }

        public int InsertPositionDescription(int nEmpId, string strPositionPurpose)
        {
            int nPdId = 0;

            nPdId = Convert.ToInt32(Adapter.InsertPD(nEmpId, strPositionPurpose));

            return nPdId;
        }


    }
}
