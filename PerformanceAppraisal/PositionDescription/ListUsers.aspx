<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="ListUsers.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.ListUsers" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>


<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
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
</asp:Content>

