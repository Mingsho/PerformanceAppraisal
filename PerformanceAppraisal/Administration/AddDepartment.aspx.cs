﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;


namespace PerformanceAppraisal.Administration
{
    public partial class AddDepartment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DepartmentBLL deptBll = new DepartmentBLL();

            if (deptBll.addDepartment(txtDeptName.Text, txtDesc.Text))
                Response.Write("New Department added");
            else
                Response.Write("Unable to add new department");

            
        }
    }
}