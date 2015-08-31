<%@ Page Title="Manage Users" Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="PerformanceAppraisal.Administration.ManageUsers" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="panel panel-default">
        <div class="panel-heading">Manage employee roles</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-lg-6">
                    <div class="form-group">
                        <asp:Label ID="lblDepartment"
                            runat="server"
                            Text="Select Department: "></asp:Label>
                        <asp:DropDownList ID="dListDepartment"
                            runat="server"
                            AutoPostBack="true"
                            OnSelectedIndexChanged="dListDepartment_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="form-group">
                        <asp:GridView ID="grdEmployees"
                           runat="server"
                           AutoGenerateColumns="false"
                           role="grid">

                           <Columns>
                               <asp:BoundField HeaderText="Employee ID" DataField="EmpID" />
                               <asp:BoundField HeaderText="First Name" DataField="Firstname" />
                               <asp:BoundField HeaderText="Middle Name" DataField="Middlename" />
                               <asp:BoundField HeaderText="Last Name" DataField="Lastname" />

                               <asp:TemplateField>
                                   <ItemTemplate>
                                       <asp:HyperLink ID="hLnkEditRole"
                                           Text="Edit Role"
                                           runat="server"
                                           NavigateUrl='<%# Eval("EmpID","~/Administration/EditUserRole.aspx?Id={0}") %>'></asp:HyperLink>
                                   </ItemTemplate>
                               </asp:TemplateField>
                           </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div><!--inner row-->
            </div><!--panel body-->
    </div><!--Panel-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>
