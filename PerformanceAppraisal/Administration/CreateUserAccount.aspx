<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/MainLayout.Master" CodeBehind="CreateUserAccount.aspx.cs" Inherits="PerformanceAppraisal.Administration.CreateUserAccount" %>



<asp:Content ID="childMainContent" ContentPlaceHolderID="mainContent" runat="server">

    <div class="panel panel-default">
        <div class="panel-heading">

        </div>
        <div class="panel-body">
            <div class="row">

                <div class="col-lg-6">

                    <asp:createuserwizard ID="createPaUserWizard"
                        runat="server"
                        CompleteSuccessText="User account has been successfully created!"
                        LoginCreatedUser="False"
                        OnCreatedUser="createPaUserWizard_CreatedUser" 
                        ContinueDestinationPageUrl="~/Administration/AdminIndex.aspx">
                        
                        <WizardSteps>
                            <asp:CreateUserWizardStep ID="createPaUserWizardStep1" runat="server"/>
                            <asp:CompleteWizardStep ID="CompletePaUserWizardStep1" runat="server"/>
                        </WizardSteps>
                    </asp:createuserwizard>
                </div>

            </div>
        </div>
    </div>
</asp:Content>


