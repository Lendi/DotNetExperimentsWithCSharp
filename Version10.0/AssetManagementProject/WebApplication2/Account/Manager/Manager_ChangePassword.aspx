<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Manager_ChangePassword.aspx.cs" Inherits="WebApplication2.Account.Manager.Manager_ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <fieldset>
<legend>Change Password</legend>

    <table class="auto-style2">
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="NewPassword" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ErrorMessage="Enter Valid Password" ForeColor="Red" 
                    ValidationExpression="[a-zA-Z0-9]{5,8}" ControlToValidate="NewPassword"></asp:RegularExpressionValidator>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ErrorMessage="New password and confirmpassword are not same" 
                    ControlToCompare="NewPassword" ControlToValidate="ConfirmPassword" 
                    ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Status" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
            </td>
        </tr>
    </table>

</fieldset>
</asp:Content>
