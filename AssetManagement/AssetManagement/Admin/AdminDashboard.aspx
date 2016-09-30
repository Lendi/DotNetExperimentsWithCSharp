<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="AssetManagement.Admin.AdminDashboard1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <style type="text/css">
        .auto-style1
        {
            width: 18%;
            float: left;
            height: 377px;
            margin-right: 10px;
            margin-top: 4px;
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
                    <asp:LinkButton ID="lbCreateUser" runat="server"  
                        PostBackUrl="~/CreateUser.aspx" OnClick="~/CreateUser.aspx.cs">Create User</asp:LinkButton>
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
                <td class="auto-style3">
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
    

</asp:Content>
