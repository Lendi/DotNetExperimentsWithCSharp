<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="HandsOnLinqtoSql.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 50%;
        }
        .auto-style2
        {
            width: 106px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Eid</td>
                <td>
                    <asp:TextBox ID="tbID" runat="server"></asp:TextBox>
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" 
                        Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Ename</td>
                <td>
                    <asp:TextBox ID="tbEname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Desig</td>
                <td>
                    <asp:TextBox ID="tbDesig" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Salary</td>
                <td>
                    <asp:TextBox ID="tbSal" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Hiredate</td>
                <td>
                    <asp:TextBox ID="tbHiredate" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Did</td>
                <td>
                    <asp:DropDownList ID="ddlDid" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" 
                        Text="Update" />
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" 
                        Text="Delete" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
