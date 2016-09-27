<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultPage.aspx.cs" Inherits="HandsOnFormsAuthentication.DefaultPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SendRequest.aspx">Send Request</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" 
            NavigateUrl="~/Admin/AddUser.aspx">Add user</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" 
            NavigateUrl="~/Manager/RequestDetails.aspx">Request Details</asp:HyperLink>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
        <asp:LinkButton ID="LinkButtonSignOut" runat="server" 
            OnClick="LinkButtonSignOut_Click">Sign Out</asp:LinkButton>
    </form>
</body>
</html>
