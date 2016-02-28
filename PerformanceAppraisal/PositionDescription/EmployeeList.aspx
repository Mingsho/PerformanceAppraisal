<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.EmployeeList" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    <div class="panel panel-default">
        <div class="panel-heading"></div>
        <div class="panel-body">

            <div class="row">

                <div class="col-lg-6">

                    <div class="form-group">

                        <asp:Label ID="lblDepartment"
                            runat="server"
                            Text="Department"></asp:Label>
                        <asp:DropDownList ID="dListDepartment"
                            runat="server"></asp:DropDownList>

                    </div>

                </div>

            </div>

            <div class="row">

                <div class="col-lg-12">

                    <div class="form-group">

                        <asp:GridView ID="grdUserList"
                            runat="server"
                            AutoGenerateColumns="false"
                            AllowPaging="true"
                            role="grid"></asp:GridView>
                            

                    </div>

                </div>

            </div>

            

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
