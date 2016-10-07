<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="AssetManagement.Admin.CreateUser" %>



<%--

<asp:Content ID="navbar" ContentPlaceHolderID="navbar" runat="server">   
      <li><asp:LinkButton ID="lbCreateUser" runat="server" OnClick="lbCreateUser_Click" Height="40px" style="margin-left: 0px" 
                  Width="175px">Create User</asp:LinkButton>

      </li>       
            
         <li><asp:LinkButton ID="lbModifyUser" runat="server" OnClick="lbModifyUser_Click">Modify User</asp:LinkButton>
      </li>       
          
          <li><asp:LinkButton ID="lbDeactivateUser" runat="server" 
                        OnClick="lbDeactivateUser_Click">De(Re)activate User</asp:LinkButton>
           </li>    
               
          <li><asp:LinkButton ID="lbViewUsers" runat="server" OnClick="lbCreateUser_Click">View Users</asp:LinkButton>
         </li>  

           <li><asp:LinkButton ID="lbChangePwd" runat="server" OnClick="lbChangePwd_Click">Change Password</asp:LinkButton>
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
    <br />


</asp:Content>--%>
      <asp:Content ID="content2" ContentPlaceHolderID="navbar" runat="server">   
          <li><asp:LinkButton ID="LinkButton1" runat="server" 
                  OnClick="lbCreateUser_Click" Height="40px" style="margin-left: 0px" 
                  Width="175px">Create User</asp:LinkButton>
       </li>       
            <li><asp:LinkButton ID="LinkButton2" runat="server" 
                  OnClick="lbModifyUser_Click" Height="40px" Width="175px">Modify User</asp:LinkButton>
        </li>

          <li><asp:LinkButton ID="LinkButton3" runat="server" 
                        OnClick="lbDeactivateUser_Click" Height="40px" Width="175px">De(Re)activate User</asp:LinkButton>

          </li>    
            
             <li>
                 <asp:LinkButton ID="lbViewUsers" runat="server" Height="40px" 
                     OnClick="lbViewUsers_Click" Width="175px">View Users</asp:LinkButton>

             </li>       
               
                
           <li style="height: 31px; width: 12px"><asp:LinkButton ID="LinkButton5" runat="server" 
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
    <br />


</asp:Content>


    <asp:Content ID="content" ContentPlaceHolderID="content" runat="server">   

     
        <table  class="auto-style1" style="height: 629px; width: 275px">
            <tr>
                <td class="auto-style2">Employee ID</td>
                <td>                
                    <asp:TextBox ID="tbEmpID" runat="server" Width="196px" >
                       </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Short ID (Username)</td>
                <td>
                    <asp:TextBox ID="tbUname" runat="server" Width="196px" 
                        ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">First Name</td>
                <td>
                    <asp:TextBox ID="tbFirstname" runat="server" Width="196px" 
                        ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name</td>
                <td>
                    <asp:TextBox ID="tbLastName" runat="server" Width="196px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email ID</td>
                <td>
                    <asp:TextBox ID="tbEmailID" runat="server" Width="196px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td>
                    <asp:TextBox ID="tbPassword" runat="server" Width="196px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Manager ID</td>
                <td>
                    <asp:TextBox ID="tbManagerID" runat="server" Width="196px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Designation</td>
                <td>
                    <asp:DropDownList ID="ddlDesignation" runat="server">
                        <asp:ListItem>Software Developer</asp:ListItem>
                        <asp:ListItem>Software Engineer</asp:ListItem>
                        <asp:ListItem>Senior Developer</asp:ListItem>
                        <asp:ListItem>Tester</asp:ListItem>
                        <asp:ListItem>Team Leader</asp:ListItem>
                        <asp:ListItem>Project Manager</asp:ListItem>
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        SelectMethod="ViewUsers" TypeName="asset.datalayer.AdminDAO">
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone Number</td>
                <td>
                    <asp:TextBox ID="tbPhno" runat="server" Width="196px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Date of Joining</td>
                <td>
                    <asp:Calendar ID="CalendarDOJ" runat="server" Height="114px" 
                        OnSelectionChanged="CalendarDOJ_SelectionChanged"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Account Status</td>
                <td>
                    <asp:DropDownList ID="ddlAccountStatus" runat="server" 
                        >
                        <asp:ListItem Value="a">Active</asp:ListItem>
                        <asp:ListItem Value="i">Inactive</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="height: 94px">
                    <br />
                    <br />
                </td>
                <td style="height: 94px">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                        OnClick="btnSubmit_Click" />
                    &nbsp;
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
      
   
</asp:Content>


