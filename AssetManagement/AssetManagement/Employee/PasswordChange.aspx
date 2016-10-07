<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="AssetManagement.Employee.PasswordChange" %>

<asp:Content ID="content2" ContentPlaceHolderID="navbar" runat="server">   
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
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">logout</asp:LinkButton>           

        </asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    
    
   
    <br />
    <asp:Label ID="Label1" runat="server" Text="Old Password"></asp:Label>
&nbsp;&nbsp;
<asp:TextBox ID="tbOldPwd" runat="server" OnTextChanged="tbOldPwd_TextChanged" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;<asp:Label ID="Label5" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="lbPwdChangeCancel" runat="server" OnClick="lbPwdChangeCancel_Click">cancel</asp:LinkButton>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />


    <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
&nbsp;&nbsp;
<asp:TextBox ID="tbNewPwd" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


    <br />
    &nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;
<asp:TextBox ID="tbConfirmPwd" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    

</asp:Content>