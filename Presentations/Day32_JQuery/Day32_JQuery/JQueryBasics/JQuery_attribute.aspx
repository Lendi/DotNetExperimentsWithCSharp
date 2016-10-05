<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_attribute.aspx.cs" Inherits="JQuery_attribute" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            
            $("[title]").css("color", "blue");
            $("[title=Title3]").css("color", "green");
         
          
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <span title="Title1">Test 1</span><br />
<span>Test 2</span><br />
<span title="Title3">Test 3</span><br />
    </div>
    </form>
</body>
</html>
