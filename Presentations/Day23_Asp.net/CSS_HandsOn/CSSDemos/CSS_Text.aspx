<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CSS_Text.aspx.cs" Inherits="CSS_Text" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
h1 {
    text-decoration: overline;
    color:red;
    text-align:center;
     text-transform: lowercase;
}

h2 {
    text-decoration: line-through;
    color:blue;
    text-align:left;
        text-transform: uppercase;
}

h3 {
    text-decoration: underline;
    color:green;
    text-align:right;
     text-transform: capitalize;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>This is heading 1</h1>
    <h2>This is heading 2</h2>
    <h3>This is heading 3</h3>
    </div>
    </form>
</body>
</html>
