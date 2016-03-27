<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserResponsibilities.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserResponsibilities" %>

<div class="row">

    <div class="col-lg-6">

        <div class="form-group">
            <asp:Label ID="lblPosPurpose"
                runat="server"
                Text="Position Purpose:"
                AssociatedControlID="txtPosPurpose"></asp:Label>
            <asp:TextBox ID="txtPosPurpose"
                runat="server"
                TextMode="MultiLine"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:PlaceHolder ID="pHolderResponsibilities"
                runat="server">

            </asp:PlaceHolder>
        </div>

        <div class="form-group">

            <asp:LinkButton ID="lnkBtnCreateResponsibility"
                runat="server"
                data-toggle="tooltip"
                data-placement="top"
                title="Add responsibilities"
                OnClick="lnkBtnCreateResponsibility_Click">

                <i class="fa fa-plus-circle fa-3x"></i>

            </asp:LinkButton>

            <asp:Button ID="btnAddResponsibility"
                runat="server"
                Enabled="false"
                Text="Add Responsibility(ies)"
                OnClick="btnAddResponsibility_Click" />

        </div>

    </div>

</div>