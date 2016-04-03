<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserprofileControl.ascx.cs" Inherits="PerformanceAppraisal.Controls.UserprofileControl" %>

<div class="row">

    <asp:FormView ID="frmViewUserDetails"
        runat="server"
        EmptyDataText="No Employee Found!"
        DataKeyNames="EmpID"
        OnItemUpdating="frmViewUserDetails_ItemUpdating"
        OnModeChanging="frmViewUserDetails_ModeChanging"
        OnItemUpdated="frmViewUserDetails_ItemUpdated"
        RenderOuterTable="false">

        <ItemTemplate>

            <div class="col-lg-6">

                <div class="form-group">

                    <asp:Image ID="imgUserProfile"
                        runat="server"
                        Height="225px"
                        Width="225px"
                        ImageUrl='<%# "~/Handlers/ImageHandler.ashx?empId="+Eval("EmpID") %>' 
                        onerror="imgError(this)"
                        BorderStyle="Solid" BorderWidth="1px" />

                </div>

                <div class="form-group">

                    <label>Firstname:</label>
                
                    <asp:Label ID="lblFirstname"
                        runat="server"
                        Text='<%#Eval("Firstname") %>'></asp:Label>
                </div>

                <div class="form-group">
                 
                    <label>Middlename:</label>
                    <asp:Label ID="lblMiddlename"
                        runat="server"
                        Text='<%#Eval("Middlename") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>Lastname:</label>
                    <asp:Label ID="lblLastname"
                        runat="server"
                        Text='<%#Eval("Lastname") %>'></asp:Label>
                </div>

                <div class="form-group">

                    <label>Job Title:</label>
                    <asp:Label ID="lblTitle"
                        runat="server"
                        Text='<%# Eval("JobTitle") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>Date of birth:</label>
                    <asp:Label ID="lblDateOfBirth"
                        runat="server"
                        Text='<%# Eval("DateOfBirth") %>'></asp:Label>
                </div>

            </div> <!--end col-lg-6-->
                    
            <div class="col-lg-6">

                <div class="form-group">
                    <label>House/Unit No:</label>
                    <asp:Label ID="lblHouseUnitNo"
                        runat="server"
                        Text='<%# Eval("HouseUnitNo") %>'></asp:Label>
                </div>

                <div class="form-group">
                   <label>Streetname:</label>
                    <asp:Label ID="lblStreetname"
                        runat="server"
                        Text='<%# Eval("Streetname") %>'></asp:Label>
                </div>

                <div class="form-group">
                     <label>Suburb:</label>
                    <asp:Label ID="lblSuburb"
                        runat="server"
                        Text='<%# Eval("Suburb") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>City:</label>
                    <asp:Label ID="lblCity"
                        runat="server"
                        Text='<%# Eval("City") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>Post Code:</label>
                    <asp:Label ID="lblPostcode"
                        runat="server"
                        Text='<%# Eval("Postcode") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>Contact Number:</label>
                    <asp:Label ID="lblContactNumber"
                        runat="server"
                        Text='<%# Eval("ContactNumber") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>Email:</label>
                    <asp:Label ID="lblEmail"
                        runat="server"
                        Text='<%# Eval("Email") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>Employee Type:</label>
                    <asp:Label ID="lblEmpType"
                        runat="server"
                        Text='<%# Eval("EmployeeType") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>Start Date:</label>
                    <asp:label ID="lblStartDate"
                        runat="server"
                        Text='<%# Eval("StartDate") %>'></asp:label>
                </div>

                <div class="form-group">
                     <label>Manager ID:</label>
                    <asp:Label ID="lblManager"
                        runat="server"
                        Text='<%# Eval("ManagerID") %>'></asp:Label>
                </div>

                <div class="form-group">
                    <label>Department:</label>
                    <asp:Label ID="lblDepartment"
                        runat="server"
                        Text='<%# Eval("Departmentname") %>'></asp:Label>
                </div>

                <asp:LinkButton ID="lnkBtnEdit"
                    runat="server" 
                    CausesValidation="true"
                    CommandName="Edit" 
                    CommandArgument='<%# Eval("EmpID") %>'
                    CssClass="btn btn-primary">Edit</asp:LinkButton>

            </div> <!--end col-lg-6-->

            

        </ItemTemplate>

        <EditItemTemplate>

            <div class="col-lg-6">

                <div class="form-group">

                    <asp:Image ID="imgUserProfileEdit"
                    runat="server"
                    Heigh="225px"
                    Width="225px"
                    ImageUrl='<%# "~/Handlers/ImageHandler.ashx?empId="+Eval("EmpID") %>'
                    onerror="imgError(this)" 
                    BorderStyle="Solid" BorderWidth="1px" />

                    &nbsp;
                    <ajaxToolkit:AsyncFileUpload ID="fUploadProfilePic"
                        runat="server"
                        CssClass="form-control"
                        OnUploadedComplete="fUploadProfilePic_UploadedComplete"
                        OnClientUploadComplete=""
                        UploaderStyle="Modern" />

                </div>

                <div class="form-group">
                    <asp:Label ID="lbl2Firstname" runat="server"
                        Text="Firstname:"
                        AssociatedControlID="txtFname"></asp:Label>
                    <asp:TextBox ID="txtFname"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("Firstname") %>'></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lbl2Mname" runat="server" 
                        AssociatedControlID="txtMname"
                        Text="Middlename:"></asp:Label>
                    <asp:TextBox ID="txtMname"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("Middlename") %>'></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lbl2Lastname" runat="server"
                        AssociatedControlID="txtLname"
                        Text="Lastname:"></asp:Label>
                    <asp:TextBox ID="txtLname"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("Lastname") %>'></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lbl2JobTitle" runat="server"
                        Text="Job Title"></asp:Label>
                    <asp:TextBox ID="txtJobTitle"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("JobTitle") %>'
                        disabled></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lbl2Dob" runat="server"
                        AssociatedControlID="txtDob"
                        Text="Date of Birth:"></asp:Label> 
                    <asp:TextBox ID="txtDob"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("DateOfBirth") %>'></asp:TextBox>
                </div>

            </div>

            <div class="col-lg-6">

                <div class="form-group">

                    <asp:Label ID="lbl2HouseUnitNo" 
                        runat="server"
                        Text="House/Unit No:" 
                        AssociatedControlID="txtHouseUnitNo">
                    </asp:Label>
                    <asp:TextBox ID="txtHouseUnitNo" 
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("HouseUnitNo") %>'></asp:TextBox>
                </div>

                <div class="form-group">

                    <asp:Label ID="lbl2Streetname" 
                        runat="server"
                        Text="Streetname:" 
                        AssociatedControlID="txtStreetname">
                    </asp:Label>
                    <asp:TextBox ID="txtStreetname" 
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("Streetname") %>'></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lbl2Suburb" 
                        runat="server"
                        Text="Suburb:"
                        AssociatedControlID="txtSuburb">
                    </asp:Label>
                    <asp:TextBox ID="txtSuburb"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("Suburb") %>'></asp:TextBox>
                </div>

                <div class="form-group">

                    <asp:Label ID="lbl2City"
                        runat="server"
                        Text="City:"
                        AssociatedControlID="txtCity"></asp:Label>
                    <asp:TextBox ID="txtCity"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("City") %>'></asp:TextBox>
                </div>

                <div class="form-group">

                    <asp:Label ID="lbl2Postcode"
                        runat="server"
                        Text="Postcode:"
                        AssociatedControlID="txtPostCode"></asp:Label>
                    <asp:TextBox ID="txtPostcode"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("Postcode") %>'></asp:TextBox>

                </div>

                <div class="form-group">

                    <asp:Label ID="lbl2ContactNo"
                        runat="server"
                        Text="Contact Number"
                        AssociatedControlID="txtContactNo"></asp:Label>
                    <asp:TextBox ID="txtContactNo"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("ContactNumber") %>'></asp:TextBox>

                </div>

                <div class="form-group">

                    <asp:Label ID="lbl2Email"
                        runat="server"
                        Text="Email:"
                        AssociatedControlID="txtEmail"></asp:Label>
                    <asp:TextBox ID="txtEmail"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("Email") %>'></asp:TextBox>
                </div>

                <div class="form-group">

                    <asp:Label ID="lbl2EmpType"
                        runat="server"
                        Text="Employee Type:"
                        AssociatedControlID="txtEmpType"></asp:Label>
                    <asp:TextBox ID="txtEmpType"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("EmployeeType") %>'></asp:TextBox>
                </div>

                <div class="form-group">

                    <asp:Label ID="lbl2StartDate"
                        runat="server"
                        Text="Start Date:"
                        AssociatedControlID="txtStartDate"></asp:Label>
                    <asp:TextBox ID="txtStartDate"
                        runat="server"
                        CssClass="form-control"
                        Text='<%# Bind("StartDate") %>'></asp:TextBox>
                </div>

                <div class="form-group">

                    <asp:Label ID="lbl2ManagerID"
                        runat="server"
                        Text="Manager ID:"></asp:Label>
                    <asp:TextBox ID="txtManagerID"
                        runat="server"
                        Text='<%# Bind("ManagerID") %>'
                        CssClass="form-control"
                        disabled></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="lbl2Department"
                        runat="server"
                        Text="Department:"></asp:Label>
                    <asp:TextBox ID="txtDepartment"
                        runat="server"
                        Text='<%# Bind("Departmentname") %>'
                        CssClass="form-control"
                        disabled></asp:TextBox>
                </div>


                <asp:LinkButton ID="lnkBtnUpdate"
                    runat="server"
                    Text="Update"
                    CommandName="Update"
                    CssClass="btn btn-primary"></asp:LinkButton>&nbsp;

                <asp:LinkButton ID="lnkBtnCancelUpdate"
                    runat="server"
                    Text="Cancel"
                    CommandName="Cancel"
                    CssClass="btn btn-primary"></asp:LinkButton>

            </div>
            
        </EditItemTemplate>
                
    </asp:FormView>

    <script type="text/javascript">

        function imgError(objImage) {

            objImage.src = "../images/defaultProfileImage1.png";
        }
    </script>

</div>