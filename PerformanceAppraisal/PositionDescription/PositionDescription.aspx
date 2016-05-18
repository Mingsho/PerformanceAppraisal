<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" Title="Employee Position Description" 
    AutoEventWireup="true" CodeBehind="PositionDescription.aspx.cs" 
    Inherits="PerformanceAppraisal.PositionDescription.PositionDescription" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>
<%@ Register Src="~/Controls/UserResponsibilities.ascx" TagName="userResponsibilities" TagPrefix="usr" %>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
    
       <div class="panel panel-default">
           <div class="panel-heading">Employee Position Responsibilities</div>
           <div class="panel-body">

               <div class="row">
                   <asp:SqlDataSource ID="sqlDSourceEmp"
                       runat="server"
                       ConnectionString='<%$ ConnectionStrings:performanceDbConnectionString %>'
                       SelectCommand="SELECT E.EmpID,E.Firstname,E.Middlename,E.Lastname,
                       D.Departmentname FROM [tbl_Employee] AS E INNER JOIN
                       [tbl_Department] AS D ON E.DeptID=D.DepartmentID
                       WHERE E.EmpID=@empId">

                       <SelectParameters>
                           <asp:QueryStringParameter Name="empId" 
                               QueryStringField="EmpID" DbType="Int32" />
                       </SelectParameters>

                   </asp:SqlDataSource>

                   <div class="col-lg-6">
                       <asp:FormView ID="frmViewEmployee"
                           runat="server"
                           DataSourceID="sqlDSourceEmp">

                           <ItemTemplate>
                               <div class="form-group">

                                   <asp:Label ID="lblEmpID"
                                       runat="server"
                                       Text="Employee ID:"
                                       CssClass="form-label"></asp:Label>
                                   <asp:Label ID="lblEmpIdVal"
                                       runat="server"
                                       Text='<%# Eval("EmpID") %>'></asp:Label>
                               </div>

                               <div class="form-group">
                                   <asp:Label ID="lblFname"
                                       runat="server"
                                       Text="First Name:"></asp:Label>
                                   <asp:Label ID="lblFnameVal"
                                       runat="server"
                                       Text='<%# Eval("Firstname") %>'></asp:Label>
                               </div>

                               <div class="form-group">
                                   <asp:Label ID="lblMname"
                                       runat="server"
                                       Text="Middle Name:"></asp:Label>
                                   <asp:Label ID="lblMnameVal"
                                       runat="server"
                                       Text='<%# Eval("Middlename") %>'></asp:Label>
                               </div>

                               <div class="form-group">
                                   <asp:Label ID="lblLname"
                                       runat="server"
                                       Text="Last Name:"></asp:Label>
                                   <asp:Label ID="lblLnameVal"
                                       runat="server"
                                       Text='<%# Eval("Lastname") %>'></asp:Label>
                               </div>
                               <div class="form-group">
                                   <asp:Label ID="lblDept"
                                       runat="server"
                                       Text="Department:"></asp:Label>
                                   <asp:Label ID="lblDeptVal"
                                       runat="server"
                                       Text='<%# Eval("Departmentname") %>'></asp:Label>
                               </div>
                              
                           </ItemTemplate>

                       </asp:FormView>
                           
                   </div>

                       
               </div>

               <div class="row">

                   <div class="col-lg-12">

                      <asp:PlaceHolder ID="pHolderUserControls"
                          runat="server"></asp:PlaceHolder>

                   </div>
               </div>

           </div>
       </div>
</asp:Content>

<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server">
    
    <%: System.Web.Optimization.Scripts.Render("~/ValidationScripts") %>
</asp:Content>
