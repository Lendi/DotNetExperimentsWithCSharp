<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_ModifyUser.aspx.cs" Inherits="WebApplication2.Account.Admin.Admin_ModifyUser" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Label ID="lab" runat="server" AssociatedControlID="Emp">EMployee id</asp:Label>
                                <asp:DropDownList ID="Emp" runat="server" 
        Height="17px" Width="80px">
    </asp:DropDownList>
    
    <asp:Button ID="S" runat="server" Text="GetDetails"  
        CausesValidation="False" OnClick="S_Click" Height="37px" Width="156px" />
        <asp:Button ID="Deactivate" runat="server" Text="De-Activate" 
        OnClick="Deactivate_Click" />
        <asp:Label ID="Status" runat="server"></asp:Label>
 <asp:Panel ID="Panel1" runat="server">
<fieldset >

                        <legend>Create User/Employee</legend>
                        <ol>
                           
                            <li>
                                <asp:Label ID="Label1" runat="server" AssociatedControlID="FirstName">First Name</asp:Label>
                                <asp:TextBox runat="server" ID="FirstName" />
                                <asp:RequiredFieldValidator ID="FirstName_valid" runat="server" ControlToValidate="FirstName"
                                    CssClass="field-validation-error" ErrorMessage="The First name field is required." />
                            </li>
                            <li>
                                <asp:Label ID="Label7" runat="server" AssociatedControlID="LastName">Last Name</asp:Label>
                                <asp:TextBox runat="server" ID="LastName" />
                                <asp:RequiredFieldValidator ID="LastName_valid" runat="server" ControlToValidate="LastName"
                                    CssClass="field-validation-error" ErrorMessage="The Last name field is required." />
                            </li>
                            <li>
                                <asp:Label ID="Label2" runat="server" AssociatedControlID="Email_ID">Email address</asp:Label>
                                <asp:TextBox runat="server" ID="Email_ID" TextMode="Email" />
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ErrorMessage="Email is not valid" ControlToValidate="Email_ID" ForeColor="Red" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>    
                            </li>
                            
                            <li>
                                <asp:Label ID="Label5" runat="server" AssociatedControlID="Designation">Designation</asp:Label>
                                <asp:DropDownList ID="Designation" runat="server" Height="16px" Width="150px">
                                    <asp:ListItem>Team Leader</asp:ListItem>
                                    <asp:ListItem>Employee</asp:ListItem>
                                    <asp:ListItem>Manager</asp:ListItem>
                                    <asp:ListItem>Support</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Designation"
                                    CssClass="field-validation-error" ErrorMessage="The Designation is required." />
                            </li>
                            <li>
                                <asp:Label ID="Label6" runat="server" AssociatedControlID="Manager_ID">Manager ID</asp:Label>
                                <asp:DropDownList ID="Manager_ID" runat="server" Height="16px" Width="150px"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="Manager_ID_valid" runat="server" ControlToValidate="Manager_ID"
                                    CssClass="field-validation-error" ErrorMessage="The Manager_ID is required." />
                            </li>
                            <li>
                                <asp:Label ID="Label8" runat="server" AssociatedControlID="Mobile_No">Mobile No:</asp:Label>
                                <asp:TextBox runat="server" ID="Mobile_No" TextMode="Phone" />
                                <asp:RequiredFieldValidator ID="Mobile_No_valid" runat="server" ControlToValidate="Mobile_No"
                                    CssClass="field-validation-error" ErrorMessage="The email address field is required." />
                            </li>
                            
                        </ol>
                        <asp:Button ID="Button1" runat="server" Text="Change" 
                            OnClick="Button1_Click" />
                        <asp:Label ID="Sts" runat="server"></asp:Label>
                    </fieldset>
    </asp:Panel>
                
    
                
</asp:Content>
