<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="HandsOnDatabBindControls.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            OnPageIndexChanging="GridView1_PageIndexChanging" 
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="3">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
