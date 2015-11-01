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
        <asp:LoginName ID="LoginName1" runat="server" />
    
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        </div>
    </form>
</body>
</html>
