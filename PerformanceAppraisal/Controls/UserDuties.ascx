<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserDuties.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserDuties" %>


<div class="row">

    <div class="col-lg-6">

        <div class="form-group">
            <asp:Repeater ID="testRepeater"
                runat="server">

                <ItemTemplate>
                    <%# Eval("ResponsibilityDesc") %>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <div class="form-group">
            <asp:LinkButton ID="lnkBtnCreateDuties"
                runat="server"
                data-toggle="tooltip"
                data-placement="top"
                title="Add duties to responsibility"
                OnClick="lnkBtnCreateDuties_Click">

                <i class="fa fa-plus-circle fa-3x"></i>
            </asp:LinkButton>
        </div>

    </div>


</div>