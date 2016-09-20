<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HandsOnClientSideValidation.WebForm2" %>
<!--to disable viewstate to all pages, EnableViewstate set to false in the line above. VS not important

in mvc, its not required -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="B1" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="B2" />
        <br />
        <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
