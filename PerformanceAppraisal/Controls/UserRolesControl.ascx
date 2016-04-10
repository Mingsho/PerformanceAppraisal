<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserRolesControl.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserRolesControl" %>


<div class="row">
    <div class="col-lg-8">
        <div class="form-group">
            <label> Employee ID :</label>
            <asp:Label ID="lblEmpId"
                runat="server"></asp:Label>
        </div>
        <div class="form-group">
            <label>Employee Name:</label>
            <asp:Label ID="lblEmpName"
                runat="server"></asp:Label>
        </div>
        <div class="form-group">
            <label>Employee Department:</label>
            <asp:Label ID="lblDepartment"
                runat="server"></asp:Label>
        </div>
        <div class="from-group">
            <fieldset class="fieldset">
                <legend>User Roles</legend>
                <asp:PlaceHolder ID="pHolderRoles"
                runat="server"></asp:PlaceHolder>
            </fieldset>
            
        </div>
    </div>
</div>
