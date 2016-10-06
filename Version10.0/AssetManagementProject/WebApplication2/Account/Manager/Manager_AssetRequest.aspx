<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Manager_AssetRequest.aspx.cs" Inherits="WebApplication2.Account.Manager.Manager_AssetRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<asp:Label ID="Label2" runat="server" AssociatedControlID="DropDownList1">AssetName</asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        
    </asp:DropDownList><br />

<asp:Label ID="Label1" runat="server" AssociatedControlID="Comments">Remarks/Comments</asp:Label>
                            <asp:TextBox ID="Comments" runat="server" TextMode="MultiLine"></asp:TextBox><br />
                            <asp:Button ID="Submit" runat="server" Text="Submit" 
        OnClick="Submit_Click" />
                            <br />
    <asp:Label ID="sts" runat="server"></asp:Label>

</asp:Content>
