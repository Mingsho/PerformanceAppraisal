<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserMaster.Master" CodeBehind="UserIndex.aspx.cs" Inherits="PerformanceAppraisal.UserPages.UserIndex" %>
<%@ MasterType VirtualPath="~/MasterPages/UserMaster.Master" %>

<asp:Content ID="childHeadContent" runat="server" ContentPlaceHolderID="userHeadContent"></asp:Content>

<asp:Content ID="childMainContent" runat="server" ContentPlaceHolderID="userMainContent">
    This is the user index page!!
</asp:Content>

<asp:Content ID="childFooterContent" runat="server" ContentPlaceHolderID="userFooterContent"></asp:Content>
