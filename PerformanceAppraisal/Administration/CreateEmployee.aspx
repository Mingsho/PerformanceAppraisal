<%@ Page Language="C#" MasterPageFile="~/MasterPages/MainLayout.Master" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="PerformanceAppraisal.Administration.CreateEmployee" %>
<%@ MasterType VirtualPath="~/MasterPages/MainLayout.Master" %>

<asp:Content ID="childContent" ContentPlaceHolderID="mainContent" runat="server">

    <div>
            <asp:Image ID="imgProfilePic"
                runat="server"
                Height="225px"
                Width="225px"
                CssClass="img-circle"
                ImageUrl="~/Images/defaultProfileImage1.png" /><br />


            
            <ajaxToolkit:AsyncFileUpload ID="fUploadProfilePic"
                        runat="server"
                        OnUploadedComplete="fUploadProfilePic_UploadedComplete"
                        OnClientUploadComplete="onFileUploadProfilePic" UploaderStyle="Modern" />
            

            <asp:Label ID="lblFirstname"
                runat="server"
                AssociatedControlID="txtFirstname"
                Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtFirstname"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblMiddlename"
                runat="server"
                AssociatedControlID="txtMiddlename"
                Text="Middle Name: "></asp:Label>
            <asp:TextBox ID="txtMiddlename"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblLastname"
                runat="server"
                Text="Last Name: "
                AssociatedControlID="txtLastname"></asp:Label>
            <asp:TextBox ID="txtLastname"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblDateofbirth"
                runat="server"
                AssociatedControlID="txtDateofbirth"
                Text="Date of Birth: "></asp:Label>
            <asp:TextBox ID="txtDateofbirth"
                runat="server"></asp:TextBox><br />
        
        
       

            <asp:Label ID="lblHouseno"
                runat="server"
                AssociatedControlID="txtHouseno"
                Text="House no"></asp:Label>
            <asp:TextBox ID="txtHouseno"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblStreetname"
                runat="server"
                Text="Street Name: "
                AssociatedControlID="txtStreetname"></asp:Label>
            <asp:TextBox ID="txtStreetname"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblSuburb"
                runat="server"
                Text="Suburb: "
                AssociatedControlID="txtSuburb"></asp:Label>
            <asp:TextBox ID="txtSuburb"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblCity"
                runat="server"
                Text="City: "
                AssociatedControlID="txtCity"></asp:Label>
            <asp:TextBox ID="txtCity"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPostcode"
                runat="server"
                Text="Postcode: "
                AssociatedControlID="txtPostcode"></asp:Label>
            <asp:TextBox ID="txtPostcode"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblContactnumber"
                runat="server"
                Text="Contact Number: "
                AssociatedControlID="txtContactnumber"></asp:Label>
            <asp:TextBox ID="txtContactnumber"
                runat="server"></asp:TextBox><br />
            <asp:Label ID="lblEmail"
                runat="server"
                Text="Email: "
                AssociatedControlID="txtEmail"></asp:Label>
            <asp:TextBox ID="txtEmail"
                runat="server"></asp:TextBox><br />

       

        <asp:UpdatePanel ID="uPanelProfilePicUpload"
                runat="server">

            <ContentTemplate>
                <asp:Label ID="lblEmployeetype"
                    runat="server"
                    Text="Employee Type: "
                    AssociatedControlID="dListEmpType"></asp:Label>
          
                <asp:DropDownList ID="dListEmpType"
                    runat="server"
                    AutoPostBack="true"></asp:DropDownList><br />
            </ContentTemplate>

        </asp:UpdatePanel>
        
        
        <asp:Label ID="lblStartDate"
            runat="server"
            Text="Employee StartDate: "
            AssociatedControlID="txtStartdate"></asp:Label>
        <asp:TextBox ID="txtStartdate"
            runat="server"></asp:TextBox><br />
        
        <asp:UpdatePanel ID="uPanelEmployeeTitle"
            runat="server">

            <ContentTemplate>
                <asp:Label ID="lblEmployeeTitle"
                    runat="server" Text="Employee Title: "
                    AssociatedControlID="dListEmployeeTitle"></asp:Label>
                <asp:DropDownList ID="dListEmployeeTitle"
                    runat="server" AutoPostBack="true"></asp:DropDownList><br />
            </ContentTemplate>

        </asp:UpdatePanel>

        <asp:UpdatePanel ID="uPanelDepartment"
            runat="server">

            <ContentTemplate>
                <asp:Label ID="lblDepartment"
                    runat="server"
                    AssociatedControlID="dListDepartment"
                    Text="Department: "></asp:Label>
                <asp:DropDownList ID="dListDepartment"
                    runat="server"
                    AutoPostBack="true"></asp:DropDownList><br />
            </ContentTemplate>

        </asp:UpdatePanel>
        
        <asp:UpdatePanel ID="uPanelManager"
            runat="server">

            <ContentTemplate>
                <asp:Label ID="lblManager"
                    runat="server"
                    Text="Immediate Supervisor: "
                    AssociatedControlID="dListManager"></asp:Label>
                <asp:DropDownList ID="dListManager"
                    runat="server"
                    AutoPostBack="true"></asp:DropDownList>
            </ContentTemplate>

        </asp:UpdatePanel>
        

        <asp:Button ID="btnCreateEmployee"
            runat="server"
            Text="Next"
            OnClick="btnCreateEmployee_Click" />
           
    </div>

</asp:Content>


<asp:Content ID="childFooterContent" ContentPlaceHolderID="footerContent" runat="server">
    <script type="text/javascript">

        function getRandomNumber() {

            var randomNumber = Math.random(10000);
            return randomNumber;
        }

        function onFileUploadProfilePic(sender, args) {

            var handlerPage = '<%= Page.ResolveClientUrl("~/Handlers/ImageHandler.ashx")%>';
            var queryString = '?randomno=' + getRandomNumber();
            var src = handlerPage + queryString;
            var clientID = '<%= imgProfilePic.ClientID%>';
            document.getElementById(clientID).setAttribute("src", src);
        }

    </script>
</asp:Content>

