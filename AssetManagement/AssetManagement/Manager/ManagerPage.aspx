<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Dashboard.Master" CodeBehind="ManagerPage.aspx.cs" Inherits="AssetManagement.Manager.ManagerPage" %>


<asp:Content ID="content2" ContentPlaceHolderID="navbar" runat="server">
          <li><asp:LinkButton ID="lbProfile" runat="server" 
                  PostBackUrl="~/Manager/ManagerPage.aspx" Height="40px" style="margin-left: 0px" 
                  Width="175px" OnClick="lbProfile_Click">Profile</asp:LinkButton>
       </li>    
          <li><asp:LinkButton ID="lbRequests" runat="server" 
                  PostBackUrl="~/Manager/ViewRequests.aspx" Height="40px" style="margin-left: 0px" 
                  Width="175px" OnClick="lbRequests_Click">Requests</asp:LinkButton>
       </li>       
            <li><asp:LinkButton ID="lbAssets" runat="server" 
                    PostBackUrl="~/Manager/ViewAssets.aspx" Height="40px" Width="175px" 
                    OnClick="lbAssets_Click">Assets</asp:LinkButton>
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
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" DataKeyNames="emp_id" DataSourceID="SqlDataSource1" 
        GridLines="Vertical" Height="50px" Width="644px" 
        OnPageIndexChanging="DetailsView1_PageIndexChanging">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="emp_id" HeaderText="emp_id" InsertVisible="False" 
                ReadOnly="True" SortExpression="emp_id" />
            <asp:BoundField DataField="short_id" HeaderText="short_id" 
                SortExpression="short_id" />
            <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
            <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
            <asp:BoundField DataField="email_id" HeaderText="email_id" 
                SortExpression="email_id" />
            <asp:TemplateField HeaderText="user_password">
                <ItemTemplate>
                    <asp:LinkButton ID="lbChangePwd" runat="server" Text="*********" 
                        OnClick="lbChangePwd_Click" PostBackUrl="~/Manager/PasswordChange.aspx"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
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

