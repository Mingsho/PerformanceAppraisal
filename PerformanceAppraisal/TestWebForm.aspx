<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWebForm.aspx.cs" Inherits="PerformanceAppraisal.TestWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SiteMapDataSource ID="testSource"
            runat="server"
            ShowStartingNode="false" />
    <div>
        <asp:Repeater ID="testParentRepeater"
            runat="server"
            DataSourceID="testSource"
            OnItemDataBound="testParentRepeater_ItemDataBound">

           

            <ItemTemplate>
                <li>
                    <asp:HyperLink ID="hLnkFirstLvl"
                        runat="server"
                        NavigateUrl='<%# Eval("Url") %>'><%# Eval("Title") %></asp:HyperLink>

                    <asp:Repeater ID="testChildRepeater"
                        runat="server">

                        <ItemTemplate>
                            <li>
                                <asp:HyperLink ID="hLnkSecondLvl"
                                    runat="server"
                                    NavigateUrl='<%# Eval("Url") %>'><%# Eval("Title") %></asp:HyperLink>
                            </li>
                        </ItemTemplate>

                    </asp:Repeater>
                        
                </li>

            </ItemTemplate>
            
        </asp:Repeater>

        
    </div>
    </form>
</body>
</html>
