<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserprofileControl.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserprofileControl" %>

<div>
    <fieldset>
        <legend>Basic User Profile</legend>
        
        <div>
            <asp:FormView ID="frmViewUserDetails"
                runat="server">
                <ItemTemplate>
                    
                    <asp:Image ID="imgUserProfile"
                        runat="server"
                        Height="225px"
                        Width="225px"
                        ImageUrl='<%# GetImage(Eval("ProfileImage")) %>' BorderStyle="Solid" BorderWidth="1px" /><br />
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
                        Text='<%#Eval("Lastname") %>'></asp:Label>
                </ItemTemplate>
            </asp:FormView>
        </div>
    </fieldset>

</div>