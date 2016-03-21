<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" Title="Employee Position Description" AutoEventWireup="true" CodeBehind="PositionDescription.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.PositionDescription" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
    
       <div class="panel panel-default">
           <div class="panel-heading">Employee Position Responsibilities</div>
           <div class="panel-body">

               <div class="row">

                   <div class="col-lg-6">

                       <div class="form-group">
                           <asp:Label ID="lblPosPurpose"
                               runat="server"
                               Text="Position Purpose:"
                               AssociatedControlID="txtPosPurpose"></asp:Label>
                           <asp:TextBox ID="txtPosPurpose"
                               runat="server"
                               TextMode="MultiLine"></asp:TextBox>
                       </div>

                       <div class="form-group">
                           <asp:PlaceHolder ID="pHolderResponsibilities"
                               runat="server">

                           </asp:PlaceHolder>
                       </div>

                       <asp:Button ID="btnAddResponsibility"
                           runat="server"
                           Text="Add Responsibility"
                           OnClick="btnAddResponsibility_Click" />

                   </div>
               </div>

           </div>
       </div>
</asp:Content>

<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server">
    
    <%: System.Web.Optimization.Scripts.Render("~/ValidationScripts") %>
</asp:Content>
