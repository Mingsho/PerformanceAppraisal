<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeeTitlesControl.ascx.cs" Inherits="PerformanceAppraisal.Controls.EmployeeTitlesControl" %>

<div class="row">
    <asp:SqlDataSource ID="sqlDSourceEmpTitles"
        runat="server"
        ConnectionString='<%$ ConnectionStrings:performanceDbConnectionString %>'
        SelectCommand="SELECT * FROM tbl_Title where TitleID=@TitleID">

        <SelectParameters>
            <asp:QueryStringParameter Name="TitleID" QueryStringField="TID" />
        </SelectParameters>
    </asp:SqlDataSource>

    <asp:FormView ID="frmViewEmpTitles"
        runat="server"
        DataSourceID="sqlDSourceEmpTitles"
        DataKeyNames="TitleID"
        RenderOuterTable="false">

       

    </asp:FormView>

        
</div>