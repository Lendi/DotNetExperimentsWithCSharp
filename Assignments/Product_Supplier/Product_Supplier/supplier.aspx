<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="supplier.aspx.cs" Inherits="Product_Supplier.supplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Supplier ID "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbSupID" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" Height="26px" 
            OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Supplier Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
        <asp:TextBox ID="tbSupName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Supplier Address"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbSupAddr" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbSupCity" runat="server" 
            OnTextChanged="tbSuplierID0_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Contact No"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbSupContact" runat="server" 
            OnTextChanged="tbSuplierID0_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbSupEmail" runat="server" 
            OnTextChanged="tbSuplierID0_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
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
    
    </div>
    </form>
</body>
</html>
