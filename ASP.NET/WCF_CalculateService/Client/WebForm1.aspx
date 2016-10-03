<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Client.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        No 1
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        No 2
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" 
            Text="Add" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDiv" runat="server" OnClick="ButtonDiv_Click" 
            Text="Div" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
