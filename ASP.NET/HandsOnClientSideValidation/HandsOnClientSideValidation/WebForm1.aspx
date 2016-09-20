<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HandsOnClientSideValidation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btn1" runat="server" OnClick="Button1_Click" Text="B1" />
        <br />
        <asp:Button ID="btn2" runat="server" OnClick="btn2_Click" Text="B2" />
    <div>
    
        <asp:HiddenField ID="h1" runat="server" OnValueChanged="h1_ValueChanged" />
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
