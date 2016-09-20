<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HandsOnRedirectBetweenPages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Username
        <asp:TextBox ID="tbUname" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="tbUname" ErrorMessage="Username Required">*</asp:RequiredFieldValidator>
        <br />
        Password<asp:TextBox ID="tbPwd" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="FieldValidatorPwd" runat="server" 
            ControlToValidate="tbPwd" ErrorMessage="Pwd is required">*</asp:RequiredFieldValidator>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            ShowMessageBox="True" ShowSummary="False" />
        <asp:Label ID="labelLoginPage" runat="server"></asp:Label>
        <br />
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">New User? Sign Up</asp:HyperLink>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
