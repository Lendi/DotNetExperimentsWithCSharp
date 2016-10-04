<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="AssetManagement.Admin.CreateUser" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 50%;
        }
        .auto-style2
        {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>--%>



    <asp:Content ID="Content1" runat="server" contentplaceholderid="head">
        <style type="text/css">
        .auto-style2
        {
            height: 38px;
        }
    </style>
</asp:Content>


    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
                    <asp:TextBox ID="tbPassword" runat="server" Width="196px"></asp:TextBox>
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
                    <asp:DropDownList ID="ddlDesignation" runat="server" 
                        DataSourceID="ObjectDataSource1" DataTextField="designation" 
                        DataValueField="designation">
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
                        DataSourceID="ObjectDataSource1" DataTextField="active" DataValueField="active" 
                        >
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
<%--    </div>
    </form>
</body>
</html>--%>


