<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_ClassSelector.aspx.cs" Inherits="JQuery_ClassSelector" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .bold {
            color:red;
            font-family:Arial,'Bookman Old Style';
            font-weight:bold;
        }
    </style>
     <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#b1").click(function () {
                $(".bold").css("color", "blue");
            });
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p class="bold">Paragraph1</p>
    <p class="bold">Paragraph2</p>
    <p>Paragraph3</p>
    <input type="button" id="b1" value="ClickMe" />
    </div>
    </form>
</body>
</html>
