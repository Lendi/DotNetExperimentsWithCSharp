<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="HandsOnDatabBindControls.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
        <h2>Employee Information</h2>
        </HeaderTemplate>

        <ItemTemplate>
        Eid:<%#Eval("Eid")%><br />
        Ename:<%#Eval("Ename")%><br />
        Desig:<%#Eval("desig")%><br />
        Salary:<%#Eval("sal")%><br />
        DeptID:<%#Eval("did")%><br />
        </ItemTemplate>

        <AlternatingItemTemplate>
        <div style="color:blue"> 
        Eid:<%#Eval("Eid")%><br />
        Ename:<%#Eval("Ename")%><br />
        Desig:<%#Eval("desig")%><br />
        Salary:<%#Eval("sal")%><br />
        DeptID:<%#Eval("did")%><br />
        </div>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
        <hr />
        </SeparatorTemplate>
        </asp:Repeater>
    
    </div>
    </form>
</body>
</html>
