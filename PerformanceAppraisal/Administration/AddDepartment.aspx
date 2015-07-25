<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDepartment.aspx.cs" Inherits="PerformanceAppraisal.Administration.AddDepartment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblDeptName" runat="server" Text="Department Name: "></asp:Label>
        <asp:TextBox ID="txtDeptName" runat="server" placeholder="Department name..."></asp:TextBox><br />
        <asp:Label ID="lblDesc" runat="server" Text="Description: "></asp:Label>
        <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine"></asp:TextBox><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Department" OnClick="btnAdd_Click" />
    </div>
    </form>
</body>
</html>
