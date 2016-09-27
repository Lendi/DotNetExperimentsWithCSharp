<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="Product_Supplier.product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Product ID"></asp:Label>
&nbsp;
        <asp:TextBox ID="tbProdID" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" Height="26px" 
            OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Prod Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="tbProdName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Supplier ID"></asp:Label>
&nbsp;
        <asp:TextBox ID="tbSuplierID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" Text="Update" 
            OnClick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" 
            OnClick="btnDelete_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
