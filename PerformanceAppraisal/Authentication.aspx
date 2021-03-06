﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authentication.aspx.cs" Inherits="PerformanceAppraisal.Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%: System.Web.Optimization.Styles.Render("CoreStyles") %>
    <%: System.Web.Optimization.Scripts.Render("CoreScripts") %>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Login ID="lgnUser"
            runat="server"
            OnAuthenticate="lgnUser_Authenticate"
            OnLoggedIn="lgnUser_LoggedIn"
            UserNameRequiredErrorMessage="test"
            RenderOuterTable="False"
            DisplayRememberMe="true"
            FailureText="Incorrect username or password. Please try again!">

            <LayoutTemplate>
                <div class="container">
                    <div class="row">
                        <div class="col-md-4 col-md-offset-4">
                            <div class="login-panel panel panel-default">
                                <div class="panel-heading">
                                    <h3 class="panel-title">Please sign-in</h3>
                                </div>
                                <div class="panel-body">

                                    <fieldset>

                                        <div class="form-group">
                                            <asp:TextBox ID="Username"
                                               runat="server"
                                               CssClass="form-control"
                                               placeholder="User Name"></asp:TextBox>

                                            <asp:RequiredFieldValidator ID="UserNameRequired"
                                                runat="server"
                                                ControlToValidate="Username" 
                                                ErrorMessage="* User Name is required." 
                                                ForeColor="Red"
                                                ToolTip="User Name is required." 
                                                ValidationGroup="lgnUser" />

                                        </div>

                                        <div class="form-group">
                                            <asp:TextBox ID="Password"
                                                runat="server"
                                                CssClass="form-control"
                                                placeholder="Password"
                                                TextMode="Password"></asp:TextBox>

                                            <asp:RequiredFieldValidator ID="PasswordRequired" 
                                                runat="server" 
                                                ControlToValidate="Password" 
                                                ErrorMessage="* Password is required."
                                                ForeColor="Red" 
                                                ToolTip="Password is required." 
                                                ValidationGroup="lgnUser" />
                                                
                                        </div>
                                        <div class="checkbox">
                                            <asp:Label ID="lblRememberMe"
                                                runat="server"
                                                AssociatedControlID="RememberMe">
                                            <asp:CheckBox ID="RememberMe"
                                                runat="server" />
                                                Remember me next time.
                                            </asp:Label>
                                        </div>

                                        <asp:Button ID="LoginButton"
                                            runat="server"
                                            CommandName="Login"
                                            Text="Log In"
                                            ValidationGroup="lgnUser"
                                            CssClass="btn btn-lg btn-primary btn-block"/>

                                    </fieldset>

                                </div>
                            </div>

                            <asp:Label ID="FailureText" 
                                runat="server"
                                CssClass="alert alert-danger"
                                Visible="false">
                            </asp:Label>

                        </div> <!--end col-md-4-->

                    </div> <!-- end row-->

                </div> <!-- end container-->
                
            </LayoutTemplate>
        </asp:Login>

    </div>
    </form>

    <script src="Scripts/Custom/PAppraisalScript.js"></script>

</body>
</html>
