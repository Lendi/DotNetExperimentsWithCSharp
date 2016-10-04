<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="AssetManagement.Admin.ViewUsers" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   


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