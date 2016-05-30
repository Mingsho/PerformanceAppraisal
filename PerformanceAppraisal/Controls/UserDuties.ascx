<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserDuties.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserDuties" %>


<div class="row">

    <div class="col-lg-6">

        <div class="form-group">
            <asp:Repeater ID="rptrEmpResponsibilities"
                runat="server"
                OnItemCommand="rptrEmpResponsibilities_ItemCommand">

                <ItemTemplate>

                    <asp:Label ID="lblResponsibilityDesc"
                        runat="server"
                        Text='<%# Eval("ResponsibilityDesc") %>'>
                    </asp:Label>&nbsp;

                    <asp:TextBox ID="txtDuties"
                        runat="server"
                        CssClass="form-control">
                    </asp:TextBox>

                    <asp:LinkButton ID="lnkBtnCreateDuties"
                        runat="server"
                        data-toggle=""
                        data-placement="top"
                        title="Click to add duties"
                        CommandName="Create">

                    </asp:LinkButton>

                    <asp:PlaceHolder ID="pHolderDuties"
                        runat="server"></asp:PlaceHolder>
                    
                    
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