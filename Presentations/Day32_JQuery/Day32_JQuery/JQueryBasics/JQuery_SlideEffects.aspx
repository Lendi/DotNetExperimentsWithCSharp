<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_SlideEffects.aspx.cs" Inherits="JQuery_SlideEffects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#a1").click(function () {
                $("#divTestArea21").slideUp(4000);
            });
            $("#b1").click(function () {
                $("#divTestArea21").slideDown(4000);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
   <div id="divTestArea21" style="width: 300px; height: 300px;  
background-color: #89BC38; border-radius:30px">
       
       <a href="#" id="a1" style="float:right">SlideUp</a>
       <h3>Sample Text</h3>
   </div>
        <div>
<input type="button" id="b1" value="SlideDown" />
            </div>
    </form>
</body>
</html>
