<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authentication.aspx.cs" Inherits="PerformanceAppraisal.Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Login ID="lgnUser"
            runat="server"
            OnLoggedIn="lgnUser_LoggedIn"></asp:Login>
    </div>
    </form>
</body>
</html>
