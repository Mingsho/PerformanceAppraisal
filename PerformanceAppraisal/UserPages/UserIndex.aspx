<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserMaster.Master" CodeBehind="UserIndex.aspx.cs" Inherits="PerformanceAppraisal.UserPages.UserIndex" %>
<%@ MasterType VirtualPath="~/MasterPages/UserMaster.Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        This is the User Index Page!!
       
        </div>
    </form>
</body>
</html>

<asp:Content ID="childHeadContent" runat="server" ContentPlaceHolderID="userHeadContent"></asp:Content>

<asp:Content ID="childMainContent" runat="server" ContentPlaceHolderID="userMainContent">
    This is the user index page!!
</asp:Content>

<asp:Content ID="childFooterContent" runat="server" ContentPlaceHolderID="userFooterContent"></asp:Content>
