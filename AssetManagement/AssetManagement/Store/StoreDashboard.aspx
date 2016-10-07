<%@ Page Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="StoreDashboard.aspx.cs" Inherits="AssetManagement.Store.StoreDashboard" %>




<asp:Content ID="content2" ContentPlaceHolderID="navbar" runat="server">  
      <li><asp:LinkButton ID="lbStore" runat="server" PostBackUrl="~/Store/StoreDashboard.aspx" Height="40px" style="margin-left: 0px" 
                  Width="175px" OnClick="lbProfile_Click">Requests</asp:LinkButton>
       </li>  
          <li>
       </li>       
            <li>
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
            
        </asp:Content>

<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
  

    <br />
    <asp:GridView ID="GridView1" runat="server" Width="507px">
    </asp:GridView>
    <br />
    <br />
  

</asp:Content>

