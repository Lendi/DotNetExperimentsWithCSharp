<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_AddingCss.aspx.cs" Inherits="JQuery_AddingCss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#b1").click(function () {
                $("p").css("color", "red");
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Click a Button to Change Color</p>
        <input type="button" id="b1" value="ClickMe" />
    </div>
    </form>
</body>
</html>
