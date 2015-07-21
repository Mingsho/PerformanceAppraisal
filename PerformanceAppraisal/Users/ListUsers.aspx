<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListUsers.aspx.cs" Inherits="PerformanceAppraisal.Users.ListUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="../Admin/AdminIndex.aspx">Go Back</a>
    <div>

        <asp:Label ID="lblSelectDepartment"
            runat="server"
            Text="Select Department: "></asp:Label>

        <asp:DropDownList ID="dListDepartment"
            runat="server"
            AutoPostBack="true"
            OnSelectedIndexChanged="dListDepartment_SelectedIndexChanged"></asp:DropDownList>

        <asp:GridView ID="grdEmployees"
            runat="server"
            AutoGenerateColumns="false"
            AllowPaging="true"
            PageSize="15">

            <Columns>
                <asp:BoundField HeaderText="Firstname" DataField="Firstname" />
                <asp:BoundField HeaderText="Middlename" DataField="Middlename" />
                <asp:BoundField HeaderText="Lastname" DataField="Lastname" />
            </Columns>


        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
