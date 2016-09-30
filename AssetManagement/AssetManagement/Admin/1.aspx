<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="AssetManagement.Admin.AdminDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 18%;
            float: left;
            height: 445px;
            margin-right: 10px;
            margin-top: 4px;
        }
        .auto-style2
        {
            width: 185px;
        }
    </style>
</head>
<div class="Menu">
<table align="left" class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbCreateUser" runat="server"  
                         OnClick="~/CreateUser.aspx">Create User</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbModifyUser" runat="server">Modify User</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbDeactivateUser" runat="server">Deactivate User</asp:LinkButton>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbReactivateUser" runat="server">Reactivate User</asp:LinkButton>
                </td>
            </tr>
           
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbViewUser" runat="server">View User</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbChangePwd" runat="server">Change Password</asp:LinkButton>
                </td>
            </tr>
        </table>
    
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
</div>


<body>
    </body>
</html>
