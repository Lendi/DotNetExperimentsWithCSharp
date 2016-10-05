<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Animation.aspx.cs" Inherits="Animation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/jscript" src="Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#btnAnimate").click(function () {
                $("div").animate(
            {
                width: "350px",
                opacity: 0.5,
                fontSize: "26px",
               height:"200px"

            }, 3800);
            });
        });

    </script>
    <style type="text/css">
        div {
        background-color:#D5EDEF;
        color:#4f6b72;
        width:200px;
        border: 1px solid #C1DAD7;
 
      }
 </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input id="btnAnimate" type="button" value="Animate" />
       
        <h1>Some sample text in this panel</h1>      
       
    </div>
    </form>
</body>
</html>


