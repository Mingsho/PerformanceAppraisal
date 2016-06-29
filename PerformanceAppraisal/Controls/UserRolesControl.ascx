<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserRolesControl.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserRolesControl" %>


<div class="row">
    <div class="col-lg-8">

        <fieldset>
            <legend>Basic Employee Details</legend>
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
            
        </fieldset>
        
        <fieldset>
            <legend>User Roles</legend>
            <div class="from-group">
            
                <asp:PlaceHolder ID="pHolderRoles"
                runat="server"></asp:PlaceHolder>
            
            </div>

            <div class="form-group">

                <asp:Button ID="btnAssignRoles"
                    runat="server"
                    OnClick="btnAssignRoles_Click"
                    CssClass="btn btn-primary" />
            </div>

        </fieldset>
        
    </div>
</div>
