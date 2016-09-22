<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HandsOnMasterPages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Username<asp:TextBox ID="tbUname" runat="server"></asp:TextBox>
    </p>
    <p>
        Password<asp:TextBox ID="tbPwd" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnLogin" runat="server" Text="Login" />
    </p>
</asp:Content>
