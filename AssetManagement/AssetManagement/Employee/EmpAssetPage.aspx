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
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="asset_id" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="asset_id" HeaderText="asset_id" InsertVisible="False" ReadOnly="True" SortExpression="asset_id" />
            <asp:BoundField DataField="assetname" HeaderText="assetname" SortExpression="assetname" />
            <asp:BoundField DataField="emp_id" HeaderText="emp_id" SortExpression="emp_id" />
            <asp:BoundField DataField="request_id" HeaderText="request_id" SortExpression="request_id" />
            <asp:BoundField DataField="issueddate" HeaderText="issueddate" SortExpression="issueddate" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AssetManagementConnectionString %>" SelectCommand="SELECT * FROM [AssetInfo] WHERE ([emp_id] = @emp_id)">
        <SelectParameters>
            <asp:SessionParameter Name="emp_id" SessionField="Eid" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
  

</asp:Content>

