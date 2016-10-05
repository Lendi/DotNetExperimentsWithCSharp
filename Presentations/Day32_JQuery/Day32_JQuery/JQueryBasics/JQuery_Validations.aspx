<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_Validations.aspx.cs" Inherits="JQuery_Validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        
        .text {
            width:200px;
            height:20px;
        }
         .auto-style1 {
             width: 50%;
         }
    </style>
   
    <link href="Content/validationEngine.jquery.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.6.min.js"></script>
    <script src="Scripts/jquery.validationEngine-en.js"></script>
    <script src="Scripts/jquery.validationEngine.js"></script>
    <script>
  $(document).ready(function () {
            $("#form1").validationEngine();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
  <div>
       <br /><br />
        <table align="center" class="auto-style1" cellspacing="20" >
            <tr>
                <td>Enter Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="validate[required] text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="validate[required,custom[integer],max[30],min[10]] text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>DOB</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="validate[required,custom[date]] text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>EmalId</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="validate[required,custom[email]] text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>MobileNo</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="validate[required,custom[phone] text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">Login Details</td>
            </tr>
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="validate[required,custom[password] text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Re-Type Password</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="validate[equals[TextBox6]] text"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
       
   </div>
    </form>
</body>
</html>
