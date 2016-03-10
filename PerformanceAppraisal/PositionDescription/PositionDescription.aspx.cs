using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PA.BLL;
using PA.BLL.DTO;
using PerformanceAppraisal.Utilities;

namespace PerformanceAppraisal.PositionDescription
{
    public partial class PositionDescription : ThemedPage
    {
        //    TitleBLL titleLogic = new TitleBLL();
        //    DepartmentBLL deptLogic = new DepartmentBLL();
        //    EmployeeBLL empLogic = new EmployeeBLL();
        //    ResponsibilityBLL responsiblityLogic = new ResponsibilityBLL();

        //    private void CreateResponsibility(string strId, int nIndex)
        //    {
        //        Label lblTemp = new Label();
        //        lblTemp.ID="lblDuty"+ nIndex;
        //        lblTemp.Text = "Duty" + nIndex;
        //        lblTemp.AssociatedControlID = strId + nIndex;
        //        pnlDuties.Controls.Add(lblTemp);


        //        TextBox txtTemp = new TextBox();
        //        txtTemp.ID = strId + nIndex;
        //        txtTemp.TextMode = TextBoxMode.MultiLine;
        //        pnlDuties.Controls.Add(txtTemp);

        //        Literal lt = new Literal();
        //        lt.Text = "<br/>";
        //        pnlDuties.Controls.Add(lt);
        //    }

        //    private void InitializeComponents()
        //    {
        //        dListDepartment.DataSource = deptLogic.GetDepartments();
        //        dListDepartment.DataTextField = "Departmentname";
        //        dListDepartment.DataValueField = "DepartmentID";
        //        dListDepartment.SelectedIndex = 1;
        //        dListDepartment.DataBind();

        //        //Bind the employees dropdownlist
        //        BindEmployees();

        //    }

        //    private void BindEmployees()
        //    {
        //        int nDeptId = int.Parse(dListDepartment.SelectedValue);

        //        dListEmployee.DataSource = empLogic.GetEmployees(nDeptId);
        //        dListEmployee.DataTextField = "Firstname";
        //        dListEmployee.DataValueField = "EmpID";
        //        dListEmployee.DataBind();
        //    }

        //    /// <summary>
        //    /// recreating the controls that was created dynamically after postback.
        //    /// all controls with the key "txtDuty" is retrieved from the Request.Forms
        //    /// foreach of these keys the CreateTextBox method is called.
        //    /// </summary>
        //    /// <param name="e"></param>
        //    protected override void OnPreInit(EventArgs e)
        //    {
        //        //child control's init event is fired before that of parents.
        //        //this method is called to prevent this.
        //        this.PrepareChildControlsDuringPreint();

        //        List<string> keys = Request.Form.AllKeys.Where(key => key.Contains("txtDuty")).ToList();
        //        int i = 1;

        //        foreach(string key in keys)
        //        {
        //            this.CreateResponsibility("txtDuty", i);
        //            i++;
        //        }

        //        base.OnPreInit(e);
        //    }

        //    protected void Page_Load(object sender, EventArgs e)
        //    {
        //        if (!Page.IsPostBack)
        //        {
        //            InitializeComponents();
        //            this.Master.PageHeading = "Employee Position Description";
        //        }

        //    }

        //    protected void btnAddDuty_Click(object sender, EventArgs e)
        //    {
        //        //get the count of textbox in the pnlduties control.
        //        int nIndex = pnlDuties.Controls.OfType<TextBox>().ToList().Count + 1;
        //        this.CreateResponsibility("txtDuty", nIndex);
        //    }

        //    protected void btnAdd_Click(object sender, EventArgs e)
        //    {
        //        Responsibility responsibility = new Responsibility();

        //        responsibility.ResponsibilityID = null;
        //        responsibility.ResponsibilityDesc = txtResponsibility.Text;
        //        responsibility.EmpID = int.Parse(dListEmployee.SelectedValue);

        //        foreach(Control ctrl in pnlDuties.Controls)
        //        {
        //            Duty duty = new Duty();

        //            if(ctrl is TextBox)
        //            {
        //                duty.DutyID = null;
        //                duty.DutyDescription = ((TextBox)ctrl).Text;

        //                responsibility.LstDuties.Add(duty);
        //            }
        //        }

        //        //if (responsiblityLogic.AddResponsibility(responsibility))
        //        //    Response.Write("Responsiblity successfully added!");
        //    }

        //    protected void dListDepartment_SelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        //bind employees dropdownlist 
        //        //when the selected index is changed.
        //        BindEmployees();
        //    }


        //}
    }
}