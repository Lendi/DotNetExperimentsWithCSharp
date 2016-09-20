<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Name<asp:TextBox ID="tbName" runat="server" style="margin-left: 16px" 
            Width="195px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
            style="margin-left: 0px" Text="Click" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
