<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="Employee_ViewRequest.aspx.cs" Inherits="WebApplication2.Account.Employee.Employee_MyRequestStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Height="202px" Width="488px">
        <Columns>
            <asp:BoundField DataField="AssetName" HeaderText="Asset Name" />
            <asp:BoundField DataField="ManagerApprovedDate" HeaderText="Approved date Date" />
            <asp:TemplateField HeaderText="Status">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%#((int)Eval("Status")==5)?"Approved":((int)Eval("Status")==4)?"reject":((int)Eval("Status")==1)?"Pending With Manager":((int)Eval("Status")==3)?"Pending with Store":"Sent Back" %>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField>
        </Columns>
</asp:GridView>
</asp:Content>
