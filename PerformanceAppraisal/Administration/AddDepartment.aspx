<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="AddDepartment.aspx.cs" Inherits="PerformanceAppraisal.Administration.AddDepartment" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
    <div>
        <asp:Label ID="lblDeptName" runat="server" Text="Department Name: "></asp:Label>
        <asp:TextBox ID="txtDeptName" runat="server" placeholder="Department name..."></asp:TextBox><br />
        <asp:Label ID="lblDesc" runat="server" Text="Description: "></asp:Label>
        <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine"></asp:TextBox><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Department" OnClick="btnAdd_Click" />
    </div>
</asp:Content>

