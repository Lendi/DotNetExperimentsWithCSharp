<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="Employee_AssetRequest.aspx.cs" Inherits="WebApplication2.Account.Employee.Employee_AssetRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

<asp:Label ID="Label2" runat="server" AssociatedControlID="AssetsList">AssetName</asp:Label>
    <asp:DropDownList ID="AssetsList" runat="server">
    </asp:DropDownList><br />

<asp:Label ID="Label1" runat="server" AssociatedControlID="Comments">Remarks/Comments</asp:Label>
                            <asp:TextBox ID="Comments" runat="server" TextMode="MultiLine"></asp:TextBox><br />
                            <asp:Button ID="Submit" runat="server" Text="Submit" 
        OnClick="Submit_Click" />
                            <br />
    <asp:Label ID="sts" runat="server" CssClass="field-validation-error"></asp:Label>
    
</asp:Content>
