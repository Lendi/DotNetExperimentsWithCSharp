<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HandsOnServersideStateManagement.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" 
            Text="Click" />
    
    </div>
    </form>
</body>
</html>
