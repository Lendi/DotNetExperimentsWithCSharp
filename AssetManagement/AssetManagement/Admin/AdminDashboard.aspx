<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="AssetManagement.Admin.AdminDashboard1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1
        {
            width: 139px;
            float: left;
            height: 375px;
            margin-right: 10px;
            margin-top: 0px;
        }
        .auto-style2
        {
            width: 185px;
        }
       .auto-style3
       {
           width: 185px;
           height: 66px;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table  class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbCreateUser" runat="server" OnClick="lbCreateUser_Click">Create User</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbModifyUser" runat="server" OnClick="lbModifyUser_Click">Modify User</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbDeactivateUser" runat="server" 
                        OnClick="lbDeactivateUser_Click">De(Re)activate User</asp:LinkButton>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbViewUser" runat="server" OnClick="lbViewUser_Click">View Users</asp:LinkButton>
                </td>
            </tr>
           
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbChangePwd" runat="server" OnClick="lbChangePwd_Click">Change Password</asp:LinkButton>
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
    

</asp:Content>
