<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUserAccount.aspx.cs" Inherits="PerformanceAppraisal.Admin.CreateUserAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:createuserwizard ID="createPaUserWizard"
            runat="server" CompleteSuccessText="User account has been successfully created!">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server"/>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server"/>
            </WizardSteps>
        </asp:createuserwizard>

    </div>
    </form>
</body>
</html>

