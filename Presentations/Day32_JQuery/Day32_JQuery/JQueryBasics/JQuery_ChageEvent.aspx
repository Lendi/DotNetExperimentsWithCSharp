<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JQuery_ChageEvent.aspx.cs" Inherits="JQuery_ChageEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        var count = 1;
        ac = 10;
        ac1 = ac;
        $(function () {
            function updateCount() {
                var qText = $("#t1").val();

                if (qText.length <= 10) {
                    $("#s1").text(10 - qText.length);
                } 
                
            }

            $("#t1").keyup(function () {
                updateCount();
            });
//            $("#t1").keypress(function () {
//                updateCount();
//            });
//            $("#t1").keydown(function () {
//                updateCount();
//            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <span>Count:</span><span id="s1">10</span><br />
       <%-- <asp:TextBox ID="t1" runat="server" MaxLength="10" TextMode="MultiLine"></asp:TextBox>--%>
    <textarea id="t1" maxlength="10"></textarea>
    </div>
    </form>
</body>
</html>
