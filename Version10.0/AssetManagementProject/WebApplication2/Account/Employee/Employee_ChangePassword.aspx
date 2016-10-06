<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="Employee_ChangePassword.aspx.cs" Inherits="WebApplication2.Account.Employee.Employee_ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style2
    {
        width: 50%;
    }
</style>
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
                    ErrorMessage="Enter Valid Password"   CssClass="field-validation-error"
                    ValidationExpression="[a-zA-Z0-9]{5,8}" ControlToValidate="NewPassword"></asp:RegularExpressionValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="field-validation-error"
                    ControlToValidate="NewPassword" ErrorMessage="New Password is Required"></asp:RequiredFieldValidator>
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
                    ControlToCompare="NewPassword" ControlToValidate="ConfirmPassword" CssClass="field-validation-error"
                    ></asp:CompareValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="field-validation-error"
                    ControlToValidate="ConfirmPassword" 
                    ErrorMessage="Confirm Pasword Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Status" runat="server" CssClass="field-validation-error"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
            </td>
        </tr>
    </table>

</fieldset>
</asp:Content>
