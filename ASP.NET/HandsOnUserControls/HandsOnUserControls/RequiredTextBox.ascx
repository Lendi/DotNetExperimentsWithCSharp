<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RequiredTextBox.ascx.cs" Inherits="HandsOnUserControls.RequiredTextBox" %>
<asp:TextBox ID="tbReqTb" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
    ControlToValidate="tbReqTb" ErrorMessage="Please fill this field" 
    ForeColor="#FF3300"></asp:RequiredFieldValidator>

