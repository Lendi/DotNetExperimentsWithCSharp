﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="HandsOnDatabBindControls.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" 
            OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" 
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
            OnRowCancelingEdit="GridView1_RowCancelingEdit" 
            OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Eid" HeaderText="EmpID" ReadOnly="true" />
                <asp:BoundField DataField="Ename" HeaderText="EmpName" ReadOnly= "true" />
                <asp:BoundField DataField="Desig" HeaderText="Desig" />
                <asp:BoundField DataField="sal" HeaderText="Salary" />
                <asp:BoundField DataField="hiredate" HeaderText="HireDate" />
                <asp:BoundField DataField="did" HeaderText="DeptID" />
                <asp:TemplateField HeaderText="ProfilePic">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="111px" 
                            ImageUrl='<%# "~/Images/"+Eval("ProfilePic") %>' Width="125px" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
