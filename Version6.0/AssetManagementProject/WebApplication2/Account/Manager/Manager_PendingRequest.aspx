<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Manager_PendingRequest.aspx.cs" Inherits="WebApplication2.Account.Manager.Manager_PendingRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    
 
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="415px">
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
    <HeaderStyle BorderStyle="Solid" Wrap="true" BackColor="#333333" Font-Bold="True" 
            ForeColor="White"/>
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BorderStyle="Solid" BackColor="#F7F7F7" />
        <Columns>
        
            <asp:TemplateField HeaderText="Select">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Emp_ID" HeaderText="EID" />
            <asp:BoundField DataField="Request_ID" HeaderText="Rid" />
            <asp:BoundField DataField="Short_ID" HeaderText="ShortId" />
            <asp:BoundField DataField="AssetName" HeaderText="Asset Name" />
            <asp:BoundField DataField="RequestDate" HeaderText="Requested Date" />
            <asp:TemplateField HeaderText="Action"></asp:TemplateField>
        </Columns>
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
    
        <asp:DropDownList ID="DropDownList1" runat="server" 
        ></asp:DropDownList><br />
         <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br />
          <asp:Label ID="Label1" runat="server" Text="Reject"></asp:Label>   <asp:RadioButton ID="Reject" runat="server"  GroupName="request"  />
        <asp:Label ID="Label2" runat="server" Text="Accept"></asp:Label> <asp:RadioButton ID="Accept" runat="server" GroupName="request" />
       
        
       
   
       
    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        <br />

    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
    
</asp:Content>
