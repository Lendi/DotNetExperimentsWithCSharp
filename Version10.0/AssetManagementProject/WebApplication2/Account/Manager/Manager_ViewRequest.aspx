<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Manager_ViewRequest.aspx.cs" Inherits="WebApplication2.Account.Manager.Manager_ViewRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Height="202px" Width="488px">
        <Columns>
            <asp:BoundField DataField="AssetName" HeaderText="Asset Name" />
            <asp:BoundField DataField="ManagerApprovedDate" HeaderText="Approved Date" />
            <asp:TemplateField HeaderText="Status">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%#((int)Eval("Status")==5)?"Approved":((int)Eval("Status")==4)?"reject":"Pending" %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
        </Columns>
</asp:GridView>
   
</asp:Content>
