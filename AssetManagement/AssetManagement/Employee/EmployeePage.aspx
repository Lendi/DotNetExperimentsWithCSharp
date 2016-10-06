<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="EmployeePage.aspx.cs" Inherits="AssetManagement.Employee.EmployeePage" %>

<asp:Content ID="content2" ContentPlaceHolderID="navbar" runat="server">   
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


<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    
    &nbsp;<asp:DetailsView ID="DetailsView1" runat="server" Height="23px" 
        Width="629px" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="emp_id" 
        DataSourceID="SqlDataSource1" GridLines="Vertical" 
        OnPageIndexChanging="DetailsView1_PageIndexChanging">
        <AlternatingRowStyle BackColor="Gainsboro" />
        <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="emp_id" HeaderText="emp_id" ReadOnly="True" 
                SortExpression="emp_id" />
            <asp:BoundField DataField="short_id" HeaderText="short_id" 
                SortExpression="short_id" />
            <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
            <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
            <asp:BoundField DataField="email_id" HeaderText="email_id" 
                SortExpression="email_id" />
            <asp:BoundField DataField="user_password" HeaderText="user_password" 
                SortExpression="user_password" />
            <asp:BoundField DataField="manager_id" HeaderText="manager_id" 
                SortExpression="manager_id" />
            <asp:BoundField DataField="designation" HeaderText="designation" 
                SortExpression="designation" />
            <asp:BoundField DataField="mobile" HeaderText="mobile" 
                SortExpression="mobile" />
            <asp:BoundField DataField="date_of_join" HeaderText="date_of_join" 
                SortExpression="date_of_join" />
            <asp:BoundField DataField="active" HeaderText="active" 
                SortExpression="active" />
        </Fields>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:AssetManagementConnectionString %>" 
        SelectCommand="SELECT * FROM [users] WHERE ([emp_id] = @emp_id)">
        <SelectParameters>
            <asp:SessionParameter Name="emp_id" SessionField="Eid" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
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

