<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AttributesDemo.aspx.cs" Inherits="AttributesDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#img1").attr("src", "Images/Koala.jpg");
            $("#img1").mouseover(function () {
                $(this).attr("src", "Images/Hydrangeas.jpg");
            });
            $("#img1").mouseout(function () {
                $(this).attr("src", "Images/Jellyfish.jpg");
                $(this).attr("width", "400");
            });


        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <img id="img1"  width="200" height="200"
    />
    </div>
    </form>
</body>
</html>
