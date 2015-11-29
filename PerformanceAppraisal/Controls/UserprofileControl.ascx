<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserprofileControl.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserprofileControl" %>

<div>
    <fieldset>
        <legend>Basic User Profile</legend>
        
        <div>
            <asp:FormView ID="frmViewUserDetails"
                runat="server"
                EmptyDataText="No Employee Found!"
                OnModeChanging="frmViewUserDetails_ModeChanging"
                DataKeyNames="EmpID">

                <ItemTemplate>  
                    
                    <asp:Image ID="imgUserProfile"
                        runat="server"
                        Height="225px"
                        Width="225px"
                        ImageUrl='<%# "~/Handlers/ImageHandler.ashx?empId="+Eval("EmpID") %>' BorderStyle="Solid" BorderWidth="1px" /><br />
                   Firstname: 
                    <asp:Label ID="lblFirstname"
                        runat="server"
                        Text='<%#Eval("Firstname") %>'></asp:Label><br />
                    Middlename:
                    <asp:Label ID="lblMiddlename"
                        runat="server"
                        Text='<%#Eval("Middlename") %>'></asp:Label><br />
                    Lastname:
                    <asp:Label ID="lblLastname"
                        runat="server"
                        Text='<%#Eval("Lastname") %>'></asp:Label><br />
                    <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="true"
                        CommandName="Edit" CommandArgument='<%# Eval("EmpID") %>'>Edit</asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>

                    Firstname: <asp:TextBox ID="txtEditFName"
                        runat="server"
                        Text='<%# Bind("Firstname") %>'></asp:TextBox><br />
                    Middlename: <asp:TextBox ID="txtEditMiddleName"
                        runat="server"
                        Text='<%# Bind("Middlename") %>'></asp:TextBox><br />
                    Lastname: <asp:TextBox ID="txtLastname"
                        runat="server"
                        Text='<%# Bind("Lastname") %>'></asp:TextBox>


                </EditItemTemplate>
                
            </asp:FormView>
        </div>
    </fieldset>

</div>