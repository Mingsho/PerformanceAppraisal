<%@ Page Title="Manage Users" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="PerformanceAppraisal.Administration.ManageUsers" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
    <link rel="stylesheet" href="../Content/jquery-ui.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="panel panel-default">

        <div class="panel-heading">Manage employee roles</div>

        <div class="panel-body">

            <div class="row">

                <div class="col-lg-6">
                    <div class="form-group">
                        <asp:Label ID="lblDepartment"
                            runat="server"
                            Text="Select Department: "></asp:Label>
                        <asp:DropDownList ID="dListDepartment"
                            runat="server"
                            AutoPostBack="true"
                            OnSelectedIndexChanged="dListDepartment_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>
            </div> <!--row-->

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group">
                        <asp:GridView ID="grdEmployees"
                            runat="server"
                            AutoGenerateColumns="false"
                            AllowPaging="true"
                            OnRowCommand="grdEmployees_RowCommand"
                            OnRowDeleting="grdEmployees_RowDeleting"
                            role="grid"
                            DataKeyNames="EmpID">

                           <Columns>
                               <asp:BoundField HeaderText="Employee ID" DataField="EmpID" />
                               <asp:BoundField HeaderText="First Name" DataField="Firstname" />
                               <asp:BoundField HeaderText="Middle Name" DataField="Middlename" />
                               <asp:BoundField HeaderText="Last Name" DataField="Lastname" />

                               <asp:TemplateField HeaderText="Actions">
                                   <ItemTemplate>
                                       <asp:HyperLink ID="hLnkEditRole"
                                           Text="Edit Role"
                                           runat="server"
                                           NavigateUrl='<%# Eval("EmpID","~/Administration/EditUserRole.aspx?Id={0}") %>'></asp:HyperLink>|
                                       <asp:LinkButton ID="lnkBtnDelete"
                                           Text="Delete"
                                           runat="server"
                                           CommandName="Delete"
                                           CommandArgument='<%# Container.DataItemIndex %>'></asp:LinkButton>|
                                       <asp:LinkButton ID="lnkTest"
                                           runat="server"
                                           Text="ClickMe"></asp:LinkButton>
                                   </ItemTemplate>
                               </asp:TemplateField>
                           </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div><!--row-->

        </div><!--Panel-body-->
    </div>
    <div id="dialog-confirm" title="Empty the recycle bin?">
  <p><span class="ui-icon ui-icon-alert" style="float:left; margin:0 7px 20px 0;"></span>These items will be permanently deleted and cannot be recovered. Are you sure?</p>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
    <%: System.Web.Optimization.Scripts.Render("~/CustomScripts") %>

    <script type="text/javascript" src="../Scripts/Custom/myCustom1.js"></script>

</asp:Content>
