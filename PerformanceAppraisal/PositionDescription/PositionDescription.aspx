<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" Title="Employee Position Description" AutoEventWireup="true" CodeBehind="PositionDescription.aspx.cs" Inherits="PerformanceAppraisal.PositionDescription.PositionDescription" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">
    
        
       <div class="panel panel-default">
           <div class="panel-heading">Responsibilities and duties</div>
           <div class="panel-body">

               <div class="row">
                   <div class="col-lg-6">
                       <asp:Label ID="lblDepartment"
                            runat="server"
                            AssociatedControlID="dListDepartment"
                            Text="Department: "></asp:Label>

                        <asp:DropDownList ID="dListDepartment"
                            runat="server"
                            AutoPostBack="true"
                            OnSelectedIndexChanged="dListDepartment_SelectedIndexChanged"></asp:DropDownList><br />

                        <asp:Label ID="lblEmployee"
                            runat="server"
                            AssociatedControlID="dListEmployee"
                            Text="Employee: "></asp:Label>

                        <asp:DropDownList ID="dListEmployee"
                            runat="server"
                            AutoPostBack="true"></asp:DropDownList><br />

                        <asp:Label ID="lblResponsibility"
                            runat="server"
                            Text="Responsibility: "
                            AssociatedControlID="txtResponsibility"></asp:Label>
                        <asp:TextBox ID="txtResponsibility"
                            runat="server"
                            TextMode="MultiLine"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="requiredResponsiblity"
                            runat="server"
                            ControlToValidate="txtResponsibility"
                            ErrorMessage="Responsibility cannot be blank!"></asp:RequiredFieldValidator>
                        <asp:Button ID="btnAddDuty"
                            runat="server"
                            Text="Add Duty"
                            OnClick="btnAddDuty_Click" />
                        <asp:Panel ID="pnlDuties"
                            runat="server"></asp:Panel><br />
                        <asp:Button ID="btnAdd"
                            runat="server"
                            Text="Add Responsibility"
                            OnClick="btnAdd_Click" />
                   </div>
               </div>

           </div>
       </div>
        

    

</asp:Content>
