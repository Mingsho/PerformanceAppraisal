<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="EmployeePD.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.EmployeePD" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childHeadContent" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">

    <asp:SqlDataSource ID="sqlEmpDataSource"
        runat="server"
        ConnectionString="<%$ ConnectionStrings:performanceDbConnectionString %>"
        SelectCommand="SELECT E.Firstname, E.Lastname, E.EmployeeType,T.JobTitle 
                       FROM tbl_Employee AS E INNER JOIN tbl_Title AS T ON 
                       E.TitleID=T.TitleID WHERE E.EmpID=@EmpID">

        <SelectParameters>
            <asp:QueryStringParameter Name="EmpID" DbType="Int32" QueryStringField="EmpID" />
        </SelectParameters>

    </asp:SqlDataSource>

    <asp:SqlDataSource ID="sqlPdDataSource"
        runat="server"
        ConnectionString="<%$ ConnectionStrings:performanceDbConnectionString %>"
        SelectCommand="SELECT * FROM [tbl_PositionDescription]
                       WHERE EmpID=@EmpID"
        InsertCommand="INSERT INTO tbl_PositionDescription
                       VALUES(@EmpID,@PosPurpose)"
        OnSelected="sqlPdDataSource_Selected">

        <SelectParameters>
            <asp:QueryStringParameter Name="EmpID" DbType="Int32" QueryStringField="EmpID" />
        </SelectParameters>

        <InsertParameters>

        </InsertParameters>

    </asp:SqlDataSource>
    
    <div class="panel panel-default">

        <div class="panel-heading">
            <h3 class="panel-title">Employee Position description</h3>
        </div>

        <div class="panel-body">

            <div class="panel panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">
                        Position Description
                    </h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:FormView ID="frmEmpDesc"
                            runat="server"
                            DataSourceID="sqlEmpDataSource">

                            <ItemTemplate>
                                <asp:Label ID="lblfname"
                                    runat="server"
                                    Text='<%# Eval("Firstname") %>'></asp:Label><br />
                                <asp:Label ID="lblJbTitle"
                                    runat="server"
                                    Text='<%# Eval("JobTitle") %>'></asp:Label><br />
                                <asp:Label ID="EmployeeType"
                                    runat="server"
                                    Text='<%# Eval("EmployeeType") %>'></asp:Label>
                            </ItemTemplate>

                        </asp:FormView>
                    </div>
                </div>
            </div>

            <div class="row">

                <asp:FormView ID="frmViewPd"
                    runat="server"
                    RenderOuterTable="false"
                    DataSourceID="sqlPdDataSource"
                    DefaultMode="Insert"
                    OnDataBound="frmViewPd_DataBound">

                  

                    <InsertItemTemplate>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <asp:Label ID="lblPositionPurpose"
                                    runat="server"
                                    Text="Position Purpose"
                                    AssociatedControlID="txtPurpose"></asp:Label>
                                <asp:TextBox ID="txtPurpose"
                                    runat="server"
                                    Text=""></asp:TextBox>
                            </div>
                            
                            <div class="form-group">
                                <asp:PlaceHolder ID="pholderResponsibilities"
                                    runat="server">

                                </asp:PlaceHolder>
                            </div>

                            <div class="form-group">
                                <asp:Button ID="btnAddResponsibility"
                                    runat="server"
                                    Text="Add Responsibility"
                                    CssClass="btn btn-primary"
                                    OnClick="btnAddResponsibility_Click" />
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
