<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="AssetManagement.Admin.AdminDashboard1" %>

<asp:Content ID="content1" ContentPlaceHolderID="content" runat="server"> 
    <p> Welcome Admin!   </p>
    </asp:Content>
            
      <asp:Content ID="content2" ContentPlaceHolderID="navbar" runat="server">   
          <li><asp:LinkButton ID="lbCreateUser" runat="server" 
                  OnClick="lbCreateUser_Click" Height="40px" style="margin-left: 0px" 
                  Width="175px">Create User</asp:LinkButton>
       </li>       
            <li><asp:LinkButton ID="lbModifyUser" runat="server" 
                  OnClick="lbModifyUser_Click" Height="40px" Width="175px">Modify User</asp:LinkButton>
        </li>

          <li><asp:LinkButton ID="lbDeactivateUser" runat="server" 
                        OnClick="lbDeactivateUser_Click" Height="40px" Width="175px">De(Re)activate User</asp:LinkButton>

          </li>    
            
             <li style="height: 31px; width: 0px">
                 <asp:LinkButton ID="lbViewUsers" runat="server" Height="37px" 
                     OnClick="lbViewUsers_Click" Width="98px">View Users</asp:LinkButton>
                 <asp:LinkButton ID="lbChangePwd" runat="server" 
                   OnClick="lbChangePwd_Click" Height="40px" Width="175px">Change Password</asp:LinkButton>

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
