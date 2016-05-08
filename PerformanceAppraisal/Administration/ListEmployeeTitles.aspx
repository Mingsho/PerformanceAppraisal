<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="ListEmployeeTitles.aspx.cs" Inherits="PerformanceAppraisal.Administration.ListEmployeeTitles" %>


<asp:Content ID="childHeadContent" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">

    <div class="panel panel-default">
        <div class="panel-heading">Job Titles</div>
        <div class="panel-body">

            <div class="row">

                <div class="col-lg-12">

                    <asp:LinkButton ID="lnkBtnCreateEmployeeTitles"
                        runat="server"
                        Text="Create Employee Titles">

                        <i class="fa fa-plus"></i>
                    </asp:LinkButton>

                    <div class="form-group">

                        <asp:SqlDataSource ID="sqlDSourceEmpTitles"
                            runat="server"
                            ConnectionString='<%$ ConnectionStrings:performanceDbConnectionString %>'
                            SelectCommand="SELECT * FROM tbl_Title"></asp:SqlDataSource>

                        <asp:GridView ID="grdEmployeeTitles"
                            runat="server"
                            DataSourceID="sqlDSourceEmpTitles"
                            AutoGenerateColumns="false"
                            AllowPaging="true"
                            PageSize="10"
                            AllowSorting="true"
                            role="grid"
                            DataKeyNames="TitleID"
                            CssClass="table">

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
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Title Name">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTitlePurpose"
                                            runat="server"
                                            Text='<%# Eval("TitlePurpose") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:ButtonField ButtonType="Button"
                                    CommandName="Edit"
                                    HeaderText="Edit Titles" />

                                
                            </Columns>

                            <EmptyDataTemplate>
                                There are no Employee Titles to display.
                            </EmptyDataTemplate>

                        </asp:GridView>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
