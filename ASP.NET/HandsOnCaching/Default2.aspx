<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<%@OutputCache Duration="5" VaryByParam="DropDownList1" %>

<!DOCTYPE html>
<!-- for every country, a cache page is created-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Select Country<asp:DropDownList 
            ID="DropDownList1" runat="server" AutoPostBack="True" 
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="hi-IN">India</asp:ListItem>
            <asp:ListItem Value="en-US">UnitedStates</asp:ListItem>
            <asp:ListItem Value="fr-FR">France</asp:ListItem>
            <asp:ListItem Value="te-IN">India</asp:ListItem>
        </asp:DropDownList>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
