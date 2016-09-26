<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HandsOnAjax.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                Panel 1<br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <br />
                Panel 2
                <br />
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                <br />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
