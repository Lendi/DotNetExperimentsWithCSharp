<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="HandsOnDatabBindControls.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
            Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging" 
            Width="125px">
        </asp:DetailsView>
        <br />
        <br />
        Enter ID:
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" 
            Text="Search" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" 
            Text="Delete" />
    
    </div>
    </form>
</body>
</html>
