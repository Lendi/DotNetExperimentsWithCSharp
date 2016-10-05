<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Validations.aspx.cs" Inherits="Validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
    </style>
     <link href="Content/validationEngine.jquery.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.6.min.js"></script>
    <script src="Scripts/jquery.validationEngine-en.js"></script>
    <script src="Scripts/jquery.validationEngine.js"></script>
    <script type="text/javascript">
        $(function () {
           
            //$("#form1").validationEngine();
            $("#div1").validationEngine();
          
            
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
    <br /><br />
        <table align="center" class="auto-style1">
            <tr>
                <td>Enter Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="validate[required]"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="validate[required,custom[integer],min[18],max[34]]"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>DOB</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="validate[custom[date]]"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="validate[custom[email]]"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>MobileNo</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="validate[custom[phone]]"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">Login Details</td>
            </tr>
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="validate[required,custom[onlyLetterSp]]"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="validate[required,custom[password]]"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="validate[required,equals[TextBox8]]"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Submit"  />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
