﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Employee.Master" AutoEventWireup="true" CodeBehind="Employee_AssetRequest.aspx.cs" Inherits="WebApplication2.Account.Employee.Employee_AssetRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

<asp:Label ID="Label2" runat="server" AssociatedControlID="DropDownList1">AssetName</asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Mobile</asp:ListItem>
        <asp:ListItem>Laptop</asp:ListItem>
        <asp:ListItem>DataCard</asp:ListItem>
        <asp:ListItem>SimCard</asp:ListItem>
    </asp:DropDownList><br />

<asp:Label ID="Label1" runat="server" AssociatedControlID="Comments">Remarks/Comments</asp:Label>
                            <asp:TextBox ID="Comments" runat="server" TextMode="MultiLine"></asp:TextBox><br />
                            <asp:Button ID="Submit" runat="server" Text="Submit" 
        OnClick="Submit_Click" />
                            <br />
    <asp:Label ID="sts" runat="server"></asp:Label>
    
</asp:Content>
