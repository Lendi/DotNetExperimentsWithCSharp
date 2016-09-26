<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="HandsOnAjax.WebForm5" %>

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
    
    </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                <br />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1"  EventName="Click" />
                <asp:PostBackTrigger ControlID= "Button2" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
