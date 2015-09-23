<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="AddDepartment.aspx.cs" Inherits="PerformanceAppraisal.Administration.AddDepartment" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">Department details</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-lg-6">

                    <div class="form-group">
                        <asp:Label ID="lblDeptName"
                            AssociatedControlID="txtDeptName"
                            runat="server"
                            Text="Department Name: "></asp:Label>

                        <asp:TextBox ID="txtDeptName"
                            runat="server"
                            placeholder="Department name..."></asp:TextBox>

                        <asp:RequiredFieldValidator ID="reqDeptNameVal"
                            runat="server" ControlToValidate="txtDeptName"
                            ErrorMessage="Department name is required"
                            ToolTip="Department name is required"
                            EnableClientScript="false">
                        </asp:RequiredFieldValidator>

                    </div>
                    
                    <div class="form-group">

                        <asp:Label ID="lblDesc"
                            runat="server"
                            AssociatedControlID="txtDesc"
                            Text="Description: "></asp:Label>
                        <asp:TextBox ID="txtDesc"
                            runat="server" 
                            TextMode="MultiLine"></asp:TextBox>

                    </div>
                    
                    <asp:Button ID="btnAdd" 
                        runat="server" 
                        Text="Add Department" 
                        OnClick="btnAdd_Click" />
                </div>
            </div>
        </div>
        
    </div>
</asp:Content>

<asp:Content ID="childFooterContent" runat="server" ContentPlaceHolderID="footerContent">

    <script type="text/javascript">

        var txtDeptName = '<%= Page.Master.FindControl("mainContent").FindControl("txtDeptName").ClientID%>';
        
    </script>

   <%: System.Web.Optimization.Scripts.Render("~/ValidationScripts") %>
    <script src="../Scripts/Validation/departmentValidation.js"></script>

</asp:Content>

