<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainLayout.Master" CodeBehind="UserIndex.aspx.cs" Inherits="PerformanceAppraisal.UserPages.UserIndex" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childHeaderContent" ContentPlaceHolderID="headContent" runat="server"></asp:Content>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
    This is the User Main content!
</asp:Content>

<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>