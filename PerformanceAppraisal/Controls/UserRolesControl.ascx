<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserRolesControl.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserRolesControl" %>


<div class="form-group">
    Employee ID : <asp:Label ID="lblEmpId"
                                runat="server"></asp:Label>
</div>
<div class="form-group">
    Employee Name: <asp:Label ID="lblEmpName"
                                runat="server"></asp:Label>
</div>
<div class="form-group">
    Employee Department: <asp:Label ID="lblDepartment" 
                                runat="server"></asp:Label>
</div>
<div class="from-group">
    <asp:Panel ID="pnlRoles" 
        runat="server"></asp:Panel>
</div>
   