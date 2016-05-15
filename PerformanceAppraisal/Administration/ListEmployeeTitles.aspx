<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="ListEmployeeTitles.aspx.cs" Inherits="PerformanceAppraisal.Administration.ListEmployeeTitles" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childHeadContent" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">

    <div class="panel panel-default">
        <div class="panel-heading">Job Titles</div>
        <div class="panel-body">

            <div class="row">

                <div class="col-lg-6">

                    <div class="form-group">

                        <asp:LinkButton ID="lnkCreateEmpTitle"
                            runat="server"
                            CssClass="btn btn-primary"
                            OnClick="lnkCreateEmpTitle_Click">

                        <i class="fa fa-plus"></i>&nbsp;
                        Add Employee Title
                        </asp:LinkButton>

                    </div>

                </div>
            </div>

            <div class="row">

                <div class="col-lg-12">

                    <div class="form-group">

                        <asp:SqlDataSource ID="sqlDSourceEmpTitles"
                            runat="server"
                            ConnectionString='<%$ ConnectionStrings:performanceDbConnectionString %>'
                            SelectCommand="SELECT * FROM tbl_Title"
                            UpdateCommand="UPDATE tbl_Title SET [JobTitle]=@jobTitle,
                            [TitlePurpose]=@titlePurpose
                            WHERE TitleID=@tId">

                            <UpdateParameters>
                                <asp:Parameter Name="jobTitle" DbType="String" />
                                <asp:Parameter Name="titlePurpose" DbType="String" />
                                <asp:Parameter Name="tId" DbType="Int32" />
                            </UpdateParameters>

                        </asp:SqlDataSource>

                        <asp:GridView ID="grdEmployeeTitles"
                            runat="server"
                            DataSourceID="sqlDSourceEmpTitles"
                            AutoGenerateColumns="false"
                            AllowPaging="true"
                            PageSize="10"
                            AllowSorting="true"
                            role="grid"
                            DataKeyNames="TitleID"
                            CssClass="table table-striped
                             table-bordered table-hover
                             dataTable no-footer"
                            OnRowEditing="grdEmployeeTitles_RowEditing"
                            OnRowCancelingEdit="grdEmployeeTitles_RowCancelingEdit"
                            OnRowUpdating="grdEmployeeTitles_RowUpdating">
                            
                            <Columns>

                                <asp:BoundField HeaderText="Title ID"
                                    DataField="TitleID"
                                    SortExpression="TitleID"
                                    ReadOnly="true" />

                                <asp:TemplateField HeaderText="Title Name"
                                    SortExpression="JobTitle">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTitleName"
                                            runat="server"
                                            Text='<%# Eval("JobTitle") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtTitleName"
                                            runat="server"
                                            Text='<%# Eval("JobTitle") %>'
                                            CssClass="form-control"></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Title Name">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTitlePurpose"
                                            runat="server"
                                            Text='<%# Eval("TitlePurpose") %>'>
                                        </asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtTitlePurpose"
                                            runat="server"
                                            Text='<%# Eval("TitlePurpose") %>'
                                            TextMode="MultiLine"
                                            CssClass="form-control"></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:CommandField ButtonType="Button" 
                                    ShowEditButton="true" 
                                    ControlStyle-CssClass="btn btn-primary" />

                                <asp:CommandField ButtonType="Button" 
                                    ShowDeleteButton="true"
                                    ControlStyle-CssClass="btn btn-primary" />

                                
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
