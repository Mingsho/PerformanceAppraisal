<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="EmployeePD.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.EmployeePD" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childHeadContent" ContentPlaceHolderID="headContent" runat="server">
    <style type="text/css">
        .no-border {

            border: 0;
            box-shadow: none;
        }
    </style>
</asp:Content>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">

    <asp:SqlDataSource ID="sqlPdDataSource"
        runat="server"
        ConnectionString="<%$ ConnectionStrings:performanceDbConnectionString %>"
        SelectCommand="SELECT * FROM [tbl_PositionDescription]
                       WHERE EmpID=@EmpID">

        <SelectParameters>
            <asp:QueryStringParameter Name="EmpID" DbType="Int32" QueryStringField="EmpID" />
        </SelectParameters>

    </asp:SqlDataSource>
    
    <div class="panel panel-default">

        <div class="panel-heading">
            <h3 class="panel-title">Employee Position description</h3>
        </div>

        <div class="panel-body">

            <div class="row">

                <asp:FormView ID="frmViewPd"
                    runat="server"
                    RenderOuterTable="false"
                    DataSourceID="sqlPdDataSource">

                    <EmptyDataTemplate>

                        <div class="col-lg-6">
                            <div class="alert alert-warning" role="alert">
                                Position Description for the employee does not exist.
                                Would you like to create one?
                            </div>
                            <asp:Button ID="btnCreatePD"
                                runat="server"
                                Text="Create Employee PD"
                                OnClick="btnCreatePD_Click"
                                class="btn btn-success" />
                        </div>
                        
                    </EmptyDataTemplate>

                </asp:FormView>
                    
            </div>

        </div>

    </div>
    
</asp:Content>

<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
