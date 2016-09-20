<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HandsOnRedirectBetweenPages.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
            height: 378px;
        }
        .auto-style2
        {
            width: 135px;
        }
        .auto-style3
        {
            width: 135px;
            height: 30px;
        }
        .auto-style4
        {
            height: 30px;
        }
        .auto-style5
        {
            width: 135px;
            height: 39px;
        }
        .auto-style6
        {
            height: 39px;
        }
        .auto-style7
        {
            width: 135px;
            height: 36px;
        }
        .auto-style8
        {
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">FirstName *</td>
                <td>
                    <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="FieldValidatorFname" runat="server" 
                        ControlToValidate="tbFirstName" ErrorMessage="First Name Required" 
                        ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">LastName</td>
                <td>
                    <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Age</td>
                <td>
                    <asp:TextBox ID="tbAge" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="tbAge" ErrorMessage="Enter age within the range of 18-34" 
                        ForeColor="#FF3300" MaximumValue="34" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">MobileNo</td>
                <td style="margin-left: 160px">
                    <asp:TextBox ID="tbMobileNo" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="tbMobileNo" ErrorMessage="Invalid Mobile No" 
                        ForeColor="#FF3300" ValidationExpression="[789]\d{9}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td>
                    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="tbEmail" ErrorMessage="Invalid Email ID" ForeColor="#FF3300" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Login Details</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Uname *</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbUname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="FieldValidatorUname" runat="server" 
                        ControlToValidate="tbUname" ErrorMessage="User name Required" 
                        ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Pwd *</td>
                <td>
                    <asp:TextBox ID="tbPwd" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="FieldValidatorPassword" runat="server" 
                        ControlToValidate="tbPwd" ErrorMessage="Password Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                        ControlToValidate="tbPwd" ErrorMessage=" Enter 6-8 alphanumerics" 
                        ValidationExpression="[a-z0-9]{6,8}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Confirm Pwd</td>
                <td class="auto-style8">
                    <asp:TextBox ID="tbConfirmPwd" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="tbPwd" ControlToValidate="tbConfirmPwd" 
                        ErrorMessage="Passwords Mismatch" ForeColor="#FF3300"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" 
                        Text="Submit" />
                    <asp:Button ID="btnReset" runat="server" CausesValidation="False" 
                        Text="Reset" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
