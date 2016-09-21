<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PayRoll.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                    <asp:TextBox ID="tbDid" runat="server"></asp:TextBox>
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
                    &nbsp;</td>
                <td>
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
