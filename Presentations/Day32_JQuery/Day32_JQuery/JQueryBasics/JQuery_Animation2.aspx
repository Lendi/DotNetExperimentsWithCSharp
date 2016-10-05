<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_Animation2.aspx.cs" Inherits="JQuery_Animation2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("p").click(function () {
                $(this).animate({opacity:0.4}, 5000);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>I am goint to Animate...</p>
    </div>
    </form>
</body>
</html>
