<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQueryEffects.aspx.cs" Inherits="JQueryEffects" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/jscript" src="Scripts/jquery-1.4.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#b1").click(function () {
                $("p").hide(3000);
            });
            $("#b2").click(function () {
                $("p").show(3000);
            });
            $("#b3").click(function () {
                $("p").toggle(3000);
            });
            $("#b4").click(function () {
                $("p").fadeIn(3000);
            });
            $("#b5").click(function () {
                $("p").fadeOut(3000);
            });
            $("#b6").click(function () {
                $("p").after(" I am Paragraph3");
            });


        });
        </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>I am a paragraph 1</p>
     <p>I am a paragraph 2</p>
     <input type="button" id="b1" value="Hide" />
     <input type="button" id="b2" value="Show" />
     <input type="button" id="b3" value="Toggle" />
      <input type="button" id="b5" value="FadeOut" />
     <input type="button" id="b4" value="FadeIn" />
       <input type="button" id="b6" value="AddAfter" />
      <input type="button" id="b7" value="Addbefore" />
    </div> 
    </form>
</body>
</html>
