<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/UserMaster.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="PerformanceAppraisal.UserPages.UserProfile" %>
<%@ MasterType VirtualPath="~/MasterPages/UserMaster.Master" %>
<%@ Register Src="~/Controls/UserprofileControl.ascx" TagName="UserProfile" TagPrefix="up" %>

<asp:Content ID="childHeadContent" runat="server" ContentPlaceHolderID="userHeadContent"></asp:Content>

<asp:Content ID="childMainContent" runat="server" ContentPlaceHolderID="userMainContent">
    <a href="UserIndex.aspx">Go back to index</a>
    <br />
    <up:UserProfile ID="uProfileControl" runat="server" />
</asp:Content>


