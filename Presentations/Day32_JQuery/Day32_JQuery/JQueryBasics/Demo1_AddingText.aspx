<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo1_AddingText.aspx.cs" Inherits="Demo1_AddingText" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#div1").text("Hello World...");
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
    
    </div>
    </form>
</body>
</html>
