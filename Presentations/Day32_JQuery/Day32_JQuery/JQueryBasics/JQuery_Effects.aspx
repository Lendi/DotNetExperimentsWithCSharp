<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_Effects.aspx.cs" Inherits="JQuery_Effects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#b1").click(function () {
                $("p").hide("slow");
            });
            $("#b2").click(function () {
                $("p").show(3000);
            });
            $("#b3").click(function () {
                $("p").toggle(3000);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>I am goint to hide when u click button</p>
        <input type="button" id="b1" value="hide" />
        <input type="button" id="b2" value="show" />
        <input type="button" id="b3" value="toggle" />
    </div>
    </form>
</body>
</html>
