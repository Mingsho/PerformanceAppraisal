<%@ Page Title="User Profile Page" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="PerformanceAppraisal.UserPages.UserProfile" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>
<%@ Register Src="~/Controls/UserprofileControl.ascx" TagName="UserProfileControl" TagPrefix="cus" %>

<asp:Content ID="childHeadContent" runat="server" ContentPlaceHolderID="headContent"></asp:Content>

<asp:Content ID="childMainContent" runat="server" ContentPlaceHolderID="mainContent">
    <a href="UserIndex.aspx">Go back to index</a>
    <br />

    <cus:UserProfileControl ID="userProfileControl" runat="server" />
</asp:Content>

<asp:Content ID="childFooterContent" runat="server" ContentPlaceHolderID="footerContent"></asp:Content>



