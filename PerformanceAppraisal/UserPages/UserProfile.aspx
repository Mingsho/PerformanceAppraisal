<%@ Page Title="User Profile Page" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="PerformanceAppraisal.UserPages.UserProfile" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>
<%@ Register Src="~/Controls/UserprofileControl.ascx" TagName="UserProfileControl" TagPrefix="cus" %>

<asp:Content ID="childHeadContent" runat="server" ContentPlaceHolderID="headContent"></asp:Content>

<asp:Content ID="childMainContent" runat="server" ContentPlaceHolderID="mainContent">
    
    <div class="panel panel-default">
        <div class="panel-heading">My Profile</div>
        <div class="panel-body">
            <cus:UserProfileControl ID="userProfileControl" runat="server" />
        </div>
    </div>
    
</asp:Content>

<asp:Content ID="childFooterContent" runat="server" ContentPlaceHolderID="footerContent"></asp:Content>



