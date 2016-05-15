<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="ListDepartment.aspx.cs" Inherits="PerformanceAppraisal.Administration.ListDepartment" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childHeadContent" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">

    <div class="panel panel-default">
        <div class="panel-heading">Department List</div>
        <div class="panel-body">

            <div class="row">
                <div class="col-lg-6">
                    <div class="form-group">
                        <asp:LinkButton ID="lnkBtnCreateDepartment"
                            runat="server"
                            CssClass="btn btn-primary"
                            OnClick="lnkBtnCreateDepartment_Click">
                            <i class="fa fa-plus-"></i>&nbsp;
                            Add Department
                        </asp:LinkButton>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <div class="form-group">

                        <asp:SqlDataSource ID="sqlDSourceDepartments"
                            runat="server"
                            ConnectionString='<%$ ConnectionStrings:performanceDbConnectionString %>'
                            SelectCommand="SELECT * FROM [tbl_Department]"></asp:SqlDataSource>

                        <asp:GridView ID="grdDepartment"
                            runat="server"
                            DataSourceID="sqlDSourceDepartments"
                            DataKeyNames="DepartmentID"
                            AutoGenerateColumns="false"
                            AllowPaging="true"
                            PageSize="10"
                            AllowSorting="true"
                            role="grid"
                            CssClass="table table-striped
                            table-bordered table-hover
                            dataTable no-footer">

                            <Columns>

                                <asp:BoundField HeaderText="Department ID"
                                    SortExpression="DepartmentID"
                                    DataField="DepartmentID"
                                    ReadOnly="true" />

                                <asp:TemplateField HeaderText="Department Name"
                                    SortExpression="Departmentname">

                                    <ItemTemplate>
                                        <asp:Label ID="lblDepartmentName"
                                            runat="server"
                                            Text='<%# Eval("DepartmentName") %>'>
                                        </asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtDepartmentName"
                                            runat="server"
                                            Text='<%# Eval("DepartmentName") %>'
                                            CssClass="form-control"></asp:TextBox>
                                    </EditItemTemplate>

                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Description"
                                    SortExpression="Description">

                                    <ItemTemplate>
                                        <asp:Label ID="lbDescription"
                                            runat="server"
                                            Text='<%# Eval("Description") %>'>
                                        </asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtDescription"
                                            runat="server"
                                            Text='<%# Eval("Description") %>'
                                            CssClass="form-control">
                                        </asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:CommandField ButtonType="Button"
                                    ControlStyle-CssClass="btn btn-primary"
                                    ShowEditButton="true" />
                                <asp:CommandField ButtonType="Button"
                                    ControlStyle-CssClass="btn btn-primary"
                                    ShowDeleteButton="true" />

                            </Columns>

                        </asp:GridView>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
