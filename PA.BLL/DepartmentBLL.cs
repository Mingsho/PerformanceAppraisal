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

        public PaDataSet.tbl_DepartmentDataTable GetDepartments()
        {
            return Adapter.GetData();
        }

        public Department GetDepartment(int nDeptId)
        {

            PaDataSet.tbl_DepartmentDataTable departments = Adapter.GetDepartmentByID(nDeptId);

            Department department;

            if (departments.Rows.Count > 0)
            {
                department = new Department();

                department.DepartmentID = int.Parse(departments.Rows[0]["DepartmentID"].ToString());
                department.Departmentname = departments.Rows[0]["Departmentname"].ToString();
                department.Description = departments.Rows[0]["Description"].ToString();
            }
            else
                department = null;

            return department;

        }       

        public bool AddDepartment(string departmentName, string description)
        {
            bool bRetVal = false;

            PaDataSet.tbl_DepartmentDataTable departments = new PaDataSet.tbl_DepartmentDataTable();
            PaDataSet.tbl_DepartmentRow department = departments.Newtbl_DepartmentRow();

            department.Departmentname = departmentName;
            department.Description = description;

            departments.Addtbl_DepartmentRow(department);

            int nRowsAffected = Adapter.Update(departments);

            if (nRowsAffected > 0)
                bRetVal = true;

            return bRetVal;
            
        }

        public bool UpdateDepartment(Department department)
        {
            bool bRetVal = false;

            PaDataSet.tbl_DepartmentDataTable deptDTable = GetDepartments();

            foreach(PaDataSet.tbl_DepartmentRow dRow in deptDTable)
            {
                if(dRow.DepartmentID==department.DepartmentID)
                {
                    dRow.Departmentname = department.Departmentname;
                    dRow.Description = department.Description;

                    int nRowsAffected = Adapter.Update(dRow);

                    if (nRowsAffected > 0)
                    {
                        bRetVal = true;
                        break;
                    }
                }
            }

            return bRetVal;

        }
    }
}
