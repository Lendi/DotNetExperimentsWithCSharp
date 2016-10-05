<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_FadeEffects.aspx.cs" Inherits="JQuery_FadeEffects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#b1").click(function () {
                $("#img1").fadeOut(3000);
            });
            $("#b2").click(function () {
                $("#img1").fadeIn(3000);
            });
            $("#b3").click(function () {
                $("#img1").fadeToggle(3000);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <img src="Penguins.jpg" id="img1" width="200" height="200" />
      <input type="button" id="b1" value="FadeOut" />
      <input type="button" id="b2" value="FadeIn" />
      <input type="button" id="b3" value="Toggle" />
       
    </div>
    </form>
</body>
</html>
