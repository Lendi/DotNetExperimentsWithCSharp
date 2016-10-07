<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AssetManagement.Login.Login" %>

<!DOCTYPE html>
<html>

<head>

  <meta charset="UTF-8">

  <title>Welcome - Asset Management</title>

  <link rel='stylesheet' href='http://codepen.io/assets/libs/fullpage/jquery-ui.css'>

    <link rel="stylesheet" href="css/style.css" media="screen" type="text/css" />

</head>

<body>

  <div class="login-card">
    <h1>Sign In</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br>
      <form id="form1" runat="server">
&nbsp;<asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
          <br />
          &nbsp;



<%--<input type="text" name="user" placeholder="Username">
    <input type="password" name="pass" placeholder="Password">
    <input type="submit" name="login" class="login login-submit" value="login">--%>
    

          <asp:TextBox ID="tbUname"  runat="server" Height="28px" 
               Width="229px" ></asp:TextBox>
          <br />
          &nbsp;<asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
          <br />
          &nbsp;
          <asp:TextBox ID="tbPwd" runat="server" Height="28px" 
               Width="230px" TextMode="Password" ></asp:TextBox>
          <br />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnLogin" runat="server" Text="Submit" 
              OnClick="btnLogin_Click" value="login"/>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
          <br />
          <br />
          <br />
      </form>

</div>

<!-- <div id="error"><img src="https://dl.dropboxusercontent.com/u/23299152/Delete-icon.png" /> Your caps-lock is on.</div> -->

  <script src='http://codepen.io/assets/libs/fullpage/jquery_and_jqueryui.js'></script>

</body>

</html>