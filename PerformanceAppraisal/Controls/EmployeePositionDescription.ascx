<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EmployeePositionDescription.ascx.cs" Inherits="PerformanceAppraisal.Controls.EmployeePositionDescription" %>

<div>

    <div class="form-control">

        <asp:Label ID="lblPosPurpose"
            runat="server"
            AssociatedControlID="txtPosPurpose">
        </asp:Label>
        <asp:TextBox ID="txtPosPurpose"
            runat="server"
            data-toggle="tooltip"
            data-placement="top"
            title="The main purpose of this position"></asp:TextBox>
        <asp:Button ID="btnAddResponsibility"
            runat="server"
            class="btn btn-primary" />
    </div>
    <div class="form-control">
        <asp:PlaceHolder ID="pHolderResponsibilities"
            runat="server">

        </asp:PlaceHolder>
    </div>
</div>