<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateTitle.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.CreateTitle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="lblTitleName"
            runat="server"
            Text="Title Name: "
            AssociatedControlID="txtTitleName"></asp:Label>

        <asp:TextBox ID="txtTitleName"
            runat="server" placeholder="Enter Title name..."></asp:TextBox>&nbsp;
        <asp:RequiredFieldValidator ID="rFieldValidator1"
            runat="server"
            ControlToValidate="txtTitleName"
            ErrorMessage="The Title name cannot be blank!"
            ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="lblTitlePurpose"
            runat="server"
            Text="Title Purpose: "
            AssociatedControlID="txtTitlePurpose"></asp:Label>

        <asp:TextBox ID="txtTitlePurpose"
            runat="server"
            TextMode="MultiLine"></asp:TextBox><br />

        <asp:Button ID="btnCreateTitle"
            runat="server"
            Text="Create Title"
            OnClick="btnCreateTitle_Click" />

    
    </div>
    </form>
</body>
</html>
