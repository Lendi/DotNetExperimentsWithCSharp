<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="AssetManagement.Admin.ViewUsers" %>

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
            
             <li>
                 <asp:LinkButton ID="lbViewUsers" runat="server" OnClick="lbViewUsers_Click1">View Users</asp:LinkButton>

             </li>       
               
                
           <li style="height: 31px; width: 3px"><asp:LinkButton ID="lbChangePwd" runat="server" 
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





<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">   


            <asp:Repeater ID="Repeater1" runat="server" 
                OnItemCommand="Repeater1_ItemCommand">

                        <HeaderTemplate>
        <h2>Employee Information</h2>
        </HeaderTemplate>

        <ItemTemplate>
        Employee ID:<%#Eval("emp_id")%><br />Username:<%#Eval("short_id")%><br />FirstName:<%#Eval("fname")%><br />LastName:<%#Eval("lname")%><br />Email:<%#Eval("email_id")%><br />MangagerID:<%#Eval("manager_id")%><br />Designation:<%#Eval("designation")%><br />Mobile:<%#Eval("mobile")%><br />Joining Date:<%#Eval("date_of_join")%><br />Account Status:<%#Eval("active")%><br />
        </ItemTemplate>

        <AlternatingItemTemplate>
        <div style="color:maroon"> 
        Employee ID:<%#Eval("emp_id")%><br />Username:<%#Eval("short_id")%><br />FirstName:<%#Eval("fname")%><br />LastName:<%#Eval("lname")%><br />Email:<%#Eval("email_id")%><br />MangagerID:<%#Eval("manager_id")%><br />Designation:<%#Eval("designation")%><br />Mobile:<%#Eval("mobile")%><br />Joining Date:<%#Eval("date_of_join")%><br />Account Status:<%#Eval("active")%><br /></div>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
        <hr />
        </SeparatorTemplate>

            </asp:Repeater>


            </asp:Content>