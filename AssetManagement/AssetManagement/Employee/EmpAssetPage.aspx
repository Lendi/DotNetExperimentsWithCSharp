<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master"  AutoEventWireup="true" CodeBehind="EmpAssetPage.aspx.cs" Inherits="AssetManagement.Employee.EmpAssetPage" %>


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
  

    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    CellPadding="4" DataKeyNames="asset_id" DataSourceID="SqlDataSource1" 
    ForeColor="#333333" GridLines="None" 
        OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="624px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="asset_id" HeaderText="asset_id" InsertVisible="False" ReadOnly="True" SortExpression="asset_id" />
            <asp:BoundField DataField="assetname" HeaderText="assetname" SortExpression="assetname" />
            <asp:BoundField DataField="emp_id" HeaderText="emp_id" SortExpression="emp_id" />
            <asp:BoundField DataField="request_id" HeaderText="request_id" SortExpression="request_id" />
            <asp:BoundField DataField="issueddate" HeaderText="issueddate" SortExpression="issueddate" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AssetManagementConnectionString %>" SelectCommand="SELECT * FROM [AssetInfo] WHERE ([emp_id] = @emp_id)">
        <SelectParameters>
            <asp:SessionParameter Name="emp_id" SessionField="Eid" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
  

</asp:Content>

