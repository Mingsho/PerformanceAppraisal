<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserprofileControl.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserprofileControl" %>

<div>
    <fieldset>
        <legend>Basic User Profile</legend>
        
        <div>
            <asp:FormView ID="frmViewUserDetails"
                runat="server"
                EmptyDataText="No Employee Found!"
                DataKeyNames="EmpID"
                OnItemUpdating="frmViewUserDetails_ItemUpdating"
                OnModeChanging="frmViewUserDetails_ModeChanging"
                OnItemUpdated="frmViewUserDetails_ItemUpdated">

              
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
                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CausesValidation="true"
                        CommandName="Edit" CommandArgument='<%# Eval("EmpID") %>'>Edit</asp:LinkButton>
                    Date of Birth:
                    <asp:Label ID="lblDateOfBirth"
                        runat="server"
                        Text='<%# Eval("DateOfBirth") %>'></asp:Label><br />
                    House/Unit No:
                    <asp:Label ID="lblHouseUnitNo"
                        runat="server"
                        Text='<%# Eval("HouseUnitNo") %>'></asp:Label><br />
                    Streetname:
                    <asp:Label ID="lblStreetname"
                        runat="server"
                        Text='<%# Eval("Streetname") %>'></asp:Label><br />
                    Suburb:
                    <asp:Label ID="lblSuburb"
                        runat="server"
                        Text='<%# Eval("Suburb") %>'></asp:Label><br />
                    City:
                    <asp:Label ID="lblCity"
                        runat="server"
                        Text='<%# Eval("City") %>'></asp:Label><br />
                    Postcode:
                    <asp:Label ID="lblPostcode"
                        runat="server"
                        Text='<%# Eval("Postcode") %>'></asp:Label><br />
                    ContactNumber:
                    <asp:Label ID="lblContactNumber"
                        runat="server"
                        Text='<%# Eval("ContactNumber") %>'></asp:Label><br />
                    Email:
                    <asp:Label ID="lblEmail"
                        runat="server"
                        Text='<%# Eval("Email") %>'></asp:Label><br />
                    Employee Type:
                    <asp:Label ID="lblEmpType"
                        runat="server"
                        Text='<%# Eval("EmployeeType") %>'></asp:Label><br />
                    Start Date:
                    <asp:label ID="lblStartDate"
                        runat="server"
                        Text='<%# Eval("StartDate") %>'></asp:label><br />
                    Manager:
                    <asp:Label ID="lblManager"
                        runat="server"
                        Text=""></asp:Label><br />


                </ItemTemplate>

                <EditItemTemplate>

                    <asp:Image ID="imgUserProfileEdit"
                        runat="server"
                        Heigh="225px"
                        Width="225px"
                        ImageUrl='<%# "~/Handlers/ImageHandler.ashx?empId="+Eval("EmpID") %>' BorderStyle="Solid" BorderWidth="1px" /><br />

                    Firstname: <asp:TextBox ID="txtFname"
                        runat="server"
                        Text='<%# Bind("Firstname") %>'></asp:TextBox><br />
                    Middlename: <asp:TextBox ID="txtMname"
                        runat="server"
                        Text='<%# Bind("Middlename") %>'></asp:TextBox><br />
                    Lastname: <asp:TextBox ID="txtLname"
                        runat="server"
                        Text='<%# Bind("Lastname") %>'></asp:TextBox><br />
                    Date Of Birth: <asp:TextBox ID="txtDob"
                        runat="server"
                        Text='<%# Bind("DateOfBirth") %>'></asp:TextBox><br />


                    <asp:LinkButton ID="lnkBtnUpdate"
                        runat="server"
                        Text="Update"
                        CommandName="Update"></asp:LinkButton>&nbsp;

                    <asp:LinkButton ID="lnkBtnCancelUpdate"
                        runat="server"
                        Text="Cancel"
                        CommandName="Cancel"></asp:LinkButton>



                </EditItemTemplate>
                
            </asp:FormView>
        </div>
    </fieldset>

</div>