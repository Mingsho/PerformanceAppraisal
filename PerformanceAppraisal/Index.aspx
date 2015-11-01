<%@ Page Title="Index Page" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/UserMaster.Master" CodeBehind="Index.aspx.cs" Inherits="PerformanceAppraisal.Index" %>
<%@ MasterType VirtualPath="~/MasterPages/UserMaster.Master" %>

<asp:Content ID="childHeadContent" ContentPlaceHolderID="userHeadContent" runat="server"></asp:Content>

<asp:Content ID="childBodyContent" ContentPlaceHolderID="userMainContent" runat="server">
    <h1>this is the user index page!</h1>
</asp:Content>

<asp:Content ID="childFooterContent" ContentPlaceHolderID="userFooterContent" runat="server">
</asp:Content>



