<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminIndex.aspx.cs" Inherits="PerformanceAppraisal.Admin.AdminIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SiteMapDataSource ID="paSmDataSource"
            runat="server" ShowStartingNode="false" />
    <div>
        <h1>This is the Admin Index Page</h1>
        <asp:LoginName ID="LoginName1" runat="server" /><br />
        <asp:LoginStatus ID="LoginStatus1" runat="server" /><br />
        <asp:Menu ID="menuAdmin"
            runat="server"
            DataSourceID="paSmDataSource"></asp:Menu>
            
    </div>
    </form>
</body>
</html>
