<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" Title="Employee Position Description" AutoEventWireup="true" CodeBehind="PositionDescription.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.PositionDescription" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>
<%@ Register Src="~/Controls/UserResponsibilities.ascx" TagName="userResponsibilities" TagPrefix="usr" %>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
    
       <div class="panel panel-default">
           <div class="panel-heading">Employee Position Responsibilities</div>
           <div class="panel-body">

               <div class="row">

                   <div class="col-lg-6">

                      <asp:PlaceHolder ID="pHolderUserControls"
                          runat="server"></asp:PlaceHolder>

                   </div>
               </div>

           </div>
       </div>
</asp:Content>

<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server">
    
    <%: System.Web.Optimization.Scripts.Render("~/ValidationScripts") %>
</asp:Content>
