<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WaterMarkEffect.aspx.cs" Inherits="WaterMarkEffect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        div {
            margin-left:200px;
            position:fixed;
            width:400px;
            height:400px;
            border:2px solid;
            border-radius:25px;
            text-align:center;
           background-color:azure;
       
        }
        .text {
            width:200px;
            height:30px;
        }
    </style>
    <script src="Scripts/jquery-1.7.1.js" type="text/javascript"></script>
    <script type="text/javascript">
        var v;
        $(function () {
            $("#t1").val("Pls Enter Name");
            $("#t1").focus(function () {
                v=$(this).val();
                if (v == "Pls Enter Name")
                $(this).val(null);
            });
            $("#t1").blur(function () {
                if($(this).val()=="")
                    $("#t1").val("Pls Enter Name");
            });
            $("#t2").val("Pls Enter Mobile");
            $("#t3").val("Pls Enter EmailId");
            $("#t4").val("Pls Enter Dob");
            $("input:text").css("color", "gray");
           
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <p><asp:TextBox ID="t1" runat="server" CssClass="text"></asp:TextBox></p>
        <p><asp:TextBox ID="t2" runat="server" CssClass="text"></asp:TextBox></p>
         <p><asp:TextBox ID="t3" runat="server" CssClass="text"></asp:TextBox></p>
         <p><asp:TextBox ID="t4" runat="server" CssClass="text"></asp:TextBox></p>
    </div>
    </form>
</body>
</html>
