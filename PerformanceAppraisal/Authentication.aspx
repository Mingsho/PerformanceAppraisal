<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Authentication.aspx.cs" Inherits="PerformanceAppraisal.Authentication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%: System.Web.Optimization.Styles.Render("CoreStyles") %>
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
            FailureText="There was an error while trying to log you in.">

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
                                            CssClass="btn btn-lg btn-success btn-block"/>

                                    </fieldset>

                                </div>
                            </div>

                            <div id="errorDiv" class="alert alert-danger fade in" role="alert">
                                <a href="#" class="close" data-dismiss="alert">&times;</a>
                                <!--The literal displays the error text.-->
                                <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
                            </div>
                        </div> <!--end col-md-4-->

                    </div> <!-- end row-->

                </div> <!-- end container-->
                
            </LayoutTemplate>
        </asp:Login>

    </div>
    </form>

    <%: System.Web.Optimization.Scripts.Render("CoreScripts") %>
    <%: System.Web.Optimization.Scripts.Render("ValidationScripts") %>

    <%--<script type="text/javascript">

        $(document).ready(function () {

            $("#errorDiv").hide();

            
        });
    </script>--%>

</body>
</html>
