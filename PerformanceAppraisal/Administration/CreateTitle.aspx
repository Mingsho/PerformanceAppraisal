<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="CreateTitle.aspx.cs" Inherits="PerformanceAppraisal.Administration.CreateTitle" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">Employee Position Titles</div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-lg-6">

                        <div class="form-group">
                            <asp:Label ID="lblTitleName"
                            runat="server"
                            Text="Title Name: "
                            AssociatedControlID="txtTitleName"></asp:Label>

                            <asp:TextBox ID="txtTitleName"
                                runat="server" placeholder="Enter Title name..."></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqTitleVal"
                                runat="server"
                                ControlToValidate="txtTitleName"
                                ErrorMessage="The Title name cannot be blank!"
                                ForeColor="Red"></asp:RequiredFieldValidator>
                            <br />
                        </div>

                        <div class="form-group">
                            <asp:Label ID="lblTitlePurpose"
                            runat="server"
                            Text="Title Purpose: "
                            AssociatedControlID="txtTitlePurpose"></asp:Label>

                            <asp:TextBox ID="txtTitlePurpose"
                            runat="server"
                            TextMode="MultiLine"></asp:TextBox><br />
                        </div>
                        

                        <asp:Button ID="btnCreateTitle"
                            runat="server"
                            Text="Create Title"
                            OnClick="btnCreateTitle_Click" />
                    </div>
                </div>
            </div>
    </div>
</asp:Content>

