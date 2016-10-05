<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Manager_TransferAsset.aspx.cs" Inherits="WebApplication2.Account.Manager.Manager_TransferAsset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style3
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
<table class="auto-style3">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="To Empployee Id:"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="To_EmpId" runat="server" Width="135px"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="EmpId" runat="server" 
                ErrorMessage="Employee Number is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Select Assets"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="AssetNameDDL" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
        </td>
        <td>
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Button1_Click" />
        </td>
    </tr>
</table>
</asp:Content>
