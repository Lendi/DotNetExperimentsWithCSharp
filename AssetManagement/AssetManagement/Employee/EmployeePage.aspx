<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="EmployeePage.aspx.cs" Inherits="AssetManagement.Employee.EmployeePage" %>

<asp:Content ID="content2" ContentPlaceHolderID="navbar" runat="server">
          <li><asp:LinkButton ID="lbProfile" runat="server" PostBackUrl="~/Employee/EmployeePage.aspx" Height="40px" style="margin-left: 0px" 
                  Width="175px">Profile</asp:LinkButton>
       </li>    
          <li><asp:LinkButton ID="lbRequests" runat="server" PostBackUrl="~/Employee/EmpRequestPage.aspx" Height="40px" style="margin-left: 0px" 
                  Width="175px">Requests</asp:LinkButton>
       </li>       
            <li><asp:LinkButton ID="lbAssets" runat="server" PostBackUrl="~/Employee/EmpAssetPage.aspx" Height="40px" Width="175px">Assets</asp:LinkButton>
        </li>

                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />
                 <br />


</asp:Content>

<asp:Content ID="logoutbar" ContentPlaceHolderID="logoutbar" runat="server"> 
            
        </asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="emp_id" DataSourceID="SqlDataSource1" GridLines="Vertical" Height="50px" Width="644px">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="emp_id" HeaderText="Employee ID" InsertVisible="False" ReadOnly="True" SortExpression="emp_id" />
            <asp:BoundField DataField="short_id" HeaderText="Username" SortExpression="short_id" />
            <asp:BoundField DataField="fname" HeaderText="FirstName" SortExpression="fname" />
            <asp:BoundField DataField="lname" HeaderText="LastName" SortExpression="lname" />
            <asp:BoundField DataField="email_id" HeaderText="Email" SortExpression="email_id" />
            <asp:TemplateField HeaderText="Password" SortExpression="user_password">
                <ItemTemplate>
                    <asp:LinkButton ID="lbPwdChange" runat="server" OnClick="lbPassword_Click" PostBackUrl="~/Employee/PasswordChange.aspx" >**********</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="manager_id" HeaderText="Manager ID" SortExpression="manager_id" />
            <asp:BoundField DataField="designation" HeaderText="Designation" SortExpression="designation" />
            <asp:BoundField DataField="mobile" HeaderText="Mobile" SortExpression="mobile" />
            <asp:BoundField DataField="date_of_join" HeaderText="Joining Date" SortExpression="date_of_join" />
            <asp:BoundField DataField="active" HeaderText="active" SortExpression="active" />
        </Fields>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
</asp:DetailsView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AssetManagementConnectionString %>" SelectCommand="SELECT * FROM [users] WHERE ([emp_id] = @emp_id)">
    <SelectParameters>
        <asp:SessionParameter Name="emp_id" SessionField="Eid" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    

</asp:Content>

