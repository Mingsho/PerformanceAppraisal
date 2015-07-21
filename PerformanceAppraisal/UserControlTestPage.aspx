<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserControlTestPage.aspx.cs" Inherits="PerformanceAppraisal.UserControlTestPage" %>
<%@ Register Src="~/Controls/UserprofileControl.ascx" TagName="uprofile" TagPrefix="up" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <up:uprofile ID="uProfile1"
            runat="server" />
    </div>
    </form>
</body>
</html>
