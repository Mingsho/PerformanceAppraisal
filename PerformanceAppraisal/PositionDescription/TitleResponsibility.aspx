<%@ Page Language="C#" Title="Employee Responsibilities" AutoEventWireup="true" CodeBehind="TitleResponsibility.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.TitleResponsibility" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<asp:Label ID="lblTitle"
            runat="server"
            Text="Title: "
            AssociatedControlID="dListTitles"></asp:Label>
        <asp:DropDownList ID="dListTitles"
            runat="server"
            AutoPostBack="true"></asp:DropDownList><br />--%>

        <asp:Label ID="lblDepartment"
            runat="server"
            AssociatedControlID="dListDepartment"
            Text="Department: "></asp:Label>

        <asp:DropDownList ID="dListDepartment"
            runat="server"
            AutoPostBack="true"
            OnSelectedIndexChanged="dListDepartment_SelectedIndexChanged"></asp:DropDownList><br />

        <asp:Label ID="lblEmployee"
            runat="server"
            AssociatedControlID="dListEmployee"
            Text="Employee: "></asp:Label>

        <asp:DropDownList ID="dListEmployee"
            runat="server"
            AutoPostBack="true"></asp:DropDownList><br />

        <asp:Label ID="lblResponsibility"
            runat="server"
            Text="Responsibility: "
            AssociatedControlID="txtResponsibility"></asp:Label>
        <asp:TextBox ID="txtResponsibility"
            runat="server"
            TextMode="MultiLine"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="requiredResponsiblity"
            runat="server"
            ControlToValidate="txtResponsibility"
            ErrorMessage="Responsibility cannot be blank!"></asp:RequiredFieldValidator>
        <asp:Button ID="btnAddDuty"
            runat="server"
            Text="Add Duty"
            OnClick="btnAddDuty_Click" />
        <asp:Panel ID="pnlDuties"
            runat="server"></asp:Panel><br />
        <asp:Button ID="btnAdd"
            runat="server"
            Text="Add Responsibility"
            OnClick="btnAdd_Click" />

    </div>
    </form>
</body>
</html>
