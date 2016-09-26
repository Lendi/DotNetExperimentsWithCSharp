<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="HandsOnDatabBindControls.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
            CellPadding="3" CellSpacing="1" DataSourceID="ObjectDataSource1" 
            GridLines="None" AllowPaging="True">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="Eid" HeaderText="Eid" SortExpression="Eid" />
                <asp:BoundField DataField="Ename" HeaderText="Ename" SortExpression="Ename" />
                <asp:BoundField DataField="Desig" HeaderText="Desig" SortExpression="Desig" />
                <asp:BoundField DataField="Sal" HeaderText="Sal" SortExpression="Sal" />
                <asp:BoundField DataField="hiredate" HeaderText="hiredate" 
                    SortExpression="hiredate" />
                <asp:BoundField DataField="Did" HeaderText="Did" SortExpression="Did" />
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GetEmployees" 
            TypeName="HandsOnDatabBindControls.DataLayer.EmployeeDAO" 
            UpdateMethod="UpdateEmployee">
            <UpdateParameters>
                <asp:Parameter Name="eid" Type="Int32" />
                <asp:Parameter Name="ename" Type="String" />
                <asp:Parameter Name="desig" Type="String" />
                <asp:Parameter Name="sal" Type="Decimal" />
                <asp:Parameter Name="hiredate" Type="DateTime" />
                <asp:Parameter Name="did" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
