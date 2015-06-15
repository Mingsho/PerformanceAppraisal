using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.DAL.PaDataSetTableAdapters;

namespace PA.BLL
{
    public class DepartmentBLL
    {
        private tbl_DepartmentTableAdapter deptAdapter;

        public tbl_DepartmentTableAdapter Adapter
        {
            get
            {
                if (deptAdapter == null)
                    deptAdapter = new tbl_DepartmentTableAdapter();
                return deptAdapter;
            }
        }

        public PA.DAL.PaDataSet.tbl_DepartmentDataTable getDepartments()
        {
            return Adapter.GetData();
        }

        public bool addDepartment(string departmentName, string description)
        {
            bool bRetVal = false;

            PA.DAL.PaDataSet.tbl_DepartmentDataTable departments = new DAL.PaDataSet.tbl_DepartmentDataTable();
            PA.DAL.PaDataSet.tbl_DepartmentRow department = departments.Newtbl_DepartmentRow();

            department.Departmentname = departmentName;
            department.Description = description;

            departments.Addtbl_DepartmentRow(department);

            int nRowsAffected = Adapter.Update(departments);

            if (nRowsAffected > 0)
                bRetVal = true;

            return bRetVal;
            
        }
    }
}
