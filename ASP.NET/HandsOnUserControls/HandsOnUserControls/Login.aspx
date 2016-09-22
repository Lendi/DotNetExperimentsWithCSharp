<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HandsOnUserControls.Login" %>

<%@ Register Src="~/HeaderControl.ascx" TagPrefix="My" TagName="Header" %>
<%@ Register src="RequiredTextBox.ascx" tagname="RequiredTextBox" tagprefix="uc1" %>
<!--using register directory we can register user control or custom control-->
<!-- the tags we register above should be used below in the body-->
<!-- can give our own tagname and tag prefix-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 50%;
        }
        .auto-style2
        {
            width: 167px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
    <div>

    <My:Header runat="server" ID="HeaderControl" />

    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Uname</td>
                <td>
                    <uc1:RequiredTextBox ID="RequiredTextBox1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Pwd</td>
                <td>
                    <uc1:RequiredTextBox ID="RequiredTextBox2" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
