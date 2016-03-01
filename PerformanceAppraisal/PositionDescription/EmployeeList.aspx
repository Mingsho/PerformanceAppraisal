<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.EmployeeList" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <div class="panel panel-default">
        <div class="panel-heading">Employee List</div>
        <div class="panel-body">

            <div class="row">

                <div class="col-lg-6">

                    <div class="form-group">

                        <asp:SqlDataSource ID="sqlDepartmentDataSource"
                            runat="server"
                            ConnectionString='<%$ ConnectionStrings:performanceDbConnectionString  %>'
                            SelectCommand="SELECT * FROM tbl_Department"></asp:SqlDataSource>

                        <asp:Label ID="lblDepartment"
                            runat="server"
                            Text="Department"></asp:Label>

                        <asp:DropDownList ID="dListDepartment"
                            runat="server"
                            DataSourceID="sqlDepartmentDataSource"
                            DataTextField="Departmentname"
                            DataValueField="DepartmentID"
                            AutoPostBack="true"></asp:DropDownList>

                    </div>

                </div>

            </div>

            <div class="row">

                <div class="col-lg-12">

                    <div class="form-group">

                        <asp:SqlDataSource ID="sqlUserDataSource"
                            runat="server"
                            ConnectionString='<%$ ConnectionStrings:performanceDbConnectionString %>'
                            SelectCommand="SELECT Emp.EmpID, Emp.Firstname, Emp.Middlename,
                                           Emp.Lastname, Title.JobTitle FROM tbl_Employee
                                           AS Emp INNER JOIN tbl_Title AS Title ON
                                           Emp.TitleID=Title.TitleID
                                           WHERE Emp.DeptID=@DeptID">

                            <SelectParameters>
                                <asp:ControlParameter ControlID="dListDepartment" 
                                    Name="DeptID"
                                    PropertyName="SelectedValue" />
                            </SelectParameters>

                        </asp:SqlDataSource>

                        <asp:GridView ID="grdUserList"
                            runat="server"
                            DataSourceID="sqlUserDataSource"
                            AutoGenerateColumns="false"
                            AllowPaging="true"
                            PageSize="10"
                            AllowSorting="true"
                            role="grid"
                            DataKeyNames="EmpID"
                            CssClass="table-condensed">

                            <Columns>
                                <asp:BoundField HeaderText="Employee ID"
                                    DataField="EmpID"
                                    SortExpression="EmpID"
                                    ReadOnly="true" />

                                <asp:TemplateField HeaderText="Position">
                                    <ItemTemplate>
                                        <asp:Label ID="lblPosition"
                                            runat="server"
                                            Text='<%# Eval("JobTitle") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                    
                                
                                <asp:TemplateField HeaderText="Firstname"
                                    SortExpression="Firstname">
                                    <ItemTemplate>
                                        <asp:Label ID="lblFname"
                                            runat="server"
                                            Text='<%# Eval("Firstname") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Middlename"
                                    SortExpression="Middlename">
                                    <ItemTemplate>
                                        <asp:Label ID="lblMiddlename"
                                            runat="server"
                                            Text='<%# Eval("Middlename") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Lastname"
                                    SortExpression="Lastname">

                                    <ItemTemplate>
                                        <asp:Label ID="lblLastname"
                                            runat="server"
                                            Text='<%# Eval("Lastname") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:CommandField ShowEditButton="true" EditText="View PD" />

                            </Columns>

                        </asp:GridView>
                            

                    </div>

                </div>

            </div>

            

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
