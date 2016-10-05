<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApplyingStylesDemo.aspx.cs" Inherits="ApplyingStylesDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      .selected { color:red; }
      .highlight { background:yellow; }
  </style>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("em").addClass("Selected");
            $("#myid").addClass("highlight");
            $("#b1").click(function () {
                $("em").toggleClass("Selected");
                $("#myid").toggleClass("highlight");
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <em title="Bold and Brave">This is first paragraph.</em>
   <p id="myid">This is second paragraph.</p>
   <input type="button" id="b1" value="Toggle" />
    </div>
    </form>
</body>
</html>
