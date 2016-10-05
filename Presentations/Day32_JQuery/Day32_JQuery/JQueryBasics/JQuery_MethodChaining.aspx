<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_MethodChaining.aspx.cs" Inherits="JQuery_MethodChaining" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .blue {
            color:blue;
        }
        .red {
            color:red;
        }
    </style>
    <script src="Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            $("#s1").text("Hello World").addClass("blue");
            $("#b1").click(function () {
             
                $("#s1").removeClass("blue").addClass("red");
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
        <span id="s1"></span>
    <input type="button" id="b1" value="Click" />
    </div>
    </form>
</body>
</html>
