<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="EmployeePD.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.EmployeePD" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childHeadContent" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">

    <asp:SqlDataSource ID="sqlPdDataSource"
        runat="server"
        ConnectionString="<%$ ConnectionStrings:performanceDbConnectionString %>"
        SelectCommand="SELECT * FROM [tbl_PositionDescription]
                       WHERE EmpID=@EmpID"
        InsertCommand="INSERT INTO tbl_PositionDescription
                       VALUES(@EmpID,@PosPurpose)">

        <SelectParameters>
            <asp:QueryStringParameter 
        </SelectParameters>

        <InsertParameters>

        </InsertParameters>

    </asp:SqlDataSource>
    
    <div class="panel panel-default">

        <div class="panel-heading">Employee Position description</div>

        <div class="panel-body">

            <div class="row">

                <asp:FormView ID="frmViewPd"
                    runat="server"
                    RenderOuterTable="false"
                    DataSourceID="sqlPdDataSource">

                    <InsertItemTemplate>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <asp:Label ID="lblPositionPurpose"
                                    runat="server"
                                    AssociatedControlID="txtPurpose"></asp:Label>
                                <asp:TextBox ID="txtPurpose"
                                    runat="server"
                                    Text=""></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="btnAddResponsibility"
                                    runat="server"
                                    Text="Add Responsibility"
                                    CssClass="btn btn-primary" />
                            </div>
                            <div class="form-group">
                                <asp:PlaceHolder ID="pholderResponsibilities"
                                    runat="server">

                                </asp:PlaceHolder>
                            </div>

                        </div>
                    </InsertItemTemplate>

                </asp:FormView>
                    
            </div>

        </div>

    </div>
    
</asp:Content>

<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
