<%@ Page Title="Edit User Role" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="EditUserRole.aspx.cs" Inherits="PerformanceAppraisal.Administration.EditUserRole" %>
<%@ Register Src="~/Controls/UserRolesControl.ascx" TagName="UserRoles" TagPrefix="uCustom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div>
        <uCustom:UserRoles ID="uCusRoles"
            runat="server" />
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
