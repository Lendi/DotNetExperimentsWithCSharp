<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TagSelector.aspx.cs" Inherits="TagSelector" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("p").css("color", "red");
            var pars = $("p");
            for(i=0;i<pars.length;i++)
            {
            alert("Found Paragraph: "+pars[i].innerHTML);
            }
           
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
     <div>
      <p class="myclass">This is a paragraph.</p>
      <p id="myid">This is second paragraph.</p>
      <p>This is third paragraph.</p>
   </div>
    </form>
</body>
</html>
