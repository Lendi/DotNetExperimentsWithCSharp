<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="HandsOnDatabBindControls.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="681px" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:TemplateField HeaderText="Eid">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" Text= '<%# Eval("Eid") %>' PostBackUrl= '<%#"~/EmpDetails.aspx?id="+Eval("Eid") %>'     > </asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Ename" HeaderText="Employee Name" />
                <asp:BoundField DataField="desig" HeaderText="Designation" />
                <asp:BoundField DataField="Sal" HeaderText="Salary" />
                <asp:TemplateField HeaderText="HireDate">
                    <EditItemTemplate>
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("hiredate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DepartmentID">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" 
                            DataSourceID="ObjectDataSource1" DataTextField="Did" DataValueField="Did">
                        </asp:DropDownList>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Did") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            DataObjectTypeName="HandsOnDatabBindControls.Employee" 
            DeleteMethod="DeleteEmployee" InsertMethod="AddEmployee" 
            SelectMethod="GetEmployees" 
            TypeName="HandsOnDatabBindControls.DataLayer.EmployeeDAO" 
            UpdateMethod="UpdateEmployee">
            <DeleteParameters>
                <asp:Parameter Name="eid" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="eid" Type="Int32" />
                <asp:Parameter Name="ename" Type="String" />
                <asp:Parameter Name="desig" Type="String" />
                <asp:Parameter Name="sal" Type="Decimal" />
                <asp:Parameter Name="hiredate" Type="DateTime" />
                <asp:Parameter Name="did" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
