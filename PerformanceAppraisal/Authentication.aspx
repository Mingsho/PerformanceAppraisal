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
            OnLoggedIn="lgnUser_LoggedIn" RenderOuterTable="False">
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
                                            <asp:TextBox ID="UserName"
                                               runat="server"
                                               CssClass="form-control"
                                               placeholder="User Name"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired"
                                                runat="server"
                                                ControlToValidate="UserName" 
                                                ErrorMessage="User Name is required." 
                                                ToolTip="User Name is required." 
                                                ValidationGroup="lgnUser">*</asp:RequiredFieldValidator>
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
                                                ErrorMessage="Password is required." 
                                                ToolTip="Password is required." 
                                                ValidationGroup="lgnUser">*</asp:RequiredFieldValidator>
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
                                            CssClass="btn btn-lg btn-success btn-block" />

                                    </fieldset>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </LayoutTemplate>
        </asp:Login>
    </div>
    </form>

    <%: System.Web.Optimization.Scripts.Render("CoreScripts") %>
</body>
</html>
