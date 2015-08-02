<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="PerformanceAppraisal.UserPages.UserProfile" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>
<%@ Register Src="~/Controls/UserprofileControl.ascx" TagName="UserProfile" TagPrefix="up" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">

    
    <up:UserProfile ID="uProfile" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
