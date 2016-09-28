<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="HandsOnDatabBindControls.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
            OnPageIndexChanging="FormView1_PageIndexChanging">

         <ItemTemplate>
        Eid:<%#Eval("Eid")%><br />Ename:<%#Eval("Ename")%><br />Desig:<%#Eval("desig")%><br />Salary:<%#Eval("sal")%><br />DeptID:<%#Eval("did")%><br />
        </ItemTemplate>

        </asp:FormView>
    </div>
    </form>
</body>
</html>
