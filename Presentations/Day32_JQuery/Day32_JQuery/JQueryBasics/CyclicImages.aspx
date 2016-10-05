<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CyclicImages.aspx.cs" Inherits="CyclicImages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #background_cycler{padding:0;margin:0;width:100%;position:absolute;top:0;left:0;z-index:-1}
#background_cycler img{position:absolute;left:0;top:0;width:100%;z-index:1}
#background_cycler img.active{z-index:3}

    </style>
    <script src="Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        function cycleImages() {
            var $active = $('#background_cycler .active');
            var $next = ($('#background_cycler .active').next().length > 0) ? $('#background_cycler .active').next() : $('#background_cycler img:first');
            $next.css('z-index', 2);//move the next image up the pile
            $active.fadeOut(1500, function () {//fade out the top image
                $active.css('z-index', 1).show().removeClass('active');//reset the z-index and unhide the image
                $next.css('z-index', 3).addClass('active');//make the next image the top one
            });
        }

        $(window).load(function () {
            $('#background_cycler').fadeIn(1500);//fade the background back in once all the images are loaded
            // run every 7s
            setInterval('cycleImages()', 7000);
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" />
   <div id="background_cycler" >

<script type="text/javascript">
    $('#background_cycler').hide();//hide the background while the images load, ready to fade in later
</script>

<img class="active" src="Images/Koala.jpg" alt=""/>
<img src="Images/Chrysanthemum.jpg" alt=""   />
<img src="Images/Chrysanthemum.jpg" alt=""  />
<img src="Images/Desert.jpg" alt=""/>		
<img src="Penguins.jpg" alt=""  />
</div>
        
    </form>
</body>
</html>
