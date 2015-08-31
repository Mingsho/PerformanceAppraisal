<%@ Page Title="Edit User Role" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="EditUserRole.aspx.cs" Inherits="PerformanceAppraisal.Administration.EditUserRole" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>
<%@ Register Src="~/Controls/UserRolesControl.ascx" TagName="UserRoles" TagPrefix="uCustom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">Edit User Role</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-lg-6">
                    <uCustom:UserRoles ID="uCusRoles"
                        runat="server" />
                </div>
            </div>
        </div>
        
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
