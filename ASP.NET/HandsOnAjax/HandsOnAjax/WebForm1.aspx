<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HandsOnAjax.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div>
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <br />
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </form>
</body>
</html>
