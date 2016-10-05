<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_Animation.aspx.cs" Inherits="JQuery_Animation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#img1").css("opacity", 0.5);
            $("#img1").hover(function () {
                $(this).animate({opacity:1.0},2000)
            }, function () {
                $(this).animate({opacity:0},2000)
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <img src="Penguins.jpg" id="img1" width="200" height="200" />
    </div>
    </form>
</body>
</html>
