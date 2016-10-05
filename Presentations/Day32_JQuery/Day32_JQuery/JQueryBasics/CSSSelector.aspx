<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CSSSelector.aspx.cs" Inherits="CSSSelector" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .para1
        {
            background-color: Yellow;
        }
        .para2
        {
            background-color: Blue;
        }
    </style>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#p1").click(function () {
                $(".para1").css("background-color", "green");
                $(".para1").css("color", "white");
            });
            $("#p2").click(function () {
                $(".para2").css({ "background-color": "red", "color": "white" });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p id="p1" class="para1">This is paragraph1</p>
    <p id="p2" class="para2">This is paragraph2</p>
    </div>
    </form>
</body>
</html>
