<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Admin_CreateUser.aspx.cs" Inherits="WebApplication2.Account.Admin.Admin_CreateUser" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <fieldset>
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
                                    ErrorMessage="Email is not valid" ControlToValidate="Email_ID"    CssClass="field-validation-error"
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>    
                            </li>
                            
                            <li>
                                <asp:Label ID="Label3" runat="server" AssociatedControlID="Password">Password</asp:Label>
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Password"
                                    CssClass="field-validation-error" ErrorMessage="The password field is required." />
                            </li>
                            <li>
                                <asp:Label ID="Label4" runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
                                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                            </li>
                            <li>
                                <asp:Label ID="Label5" runat="server" AssociatedControlID="Designation">Designation</asp:Label>
                                <asp:DropDownList ID="Designation" runat="server" Height="30px" Width="174px">
                                    <asp:ListItem>Team Leader</asp:ListItem>
                                    <asp:ListItem>Employee</asp:ListItem>
                                    <asp:ListItem>Manager</asp:ListItem>
                                    <asp:ListItem>Support</asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Designation"
                                    CssClass="field-validation-error" ErrorMessage="The Designation is required." />
                            </li>
                            <li>
                                <asp:Label ID="Label6" runat="server" AssociatedControlID="Manager_ID">Manager Name</asp:Label>
                                <asp:DropDownList ID="Manager_ID" runat="server" Height="30px" Width="174px"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="Manager_ID_valid" runat="server" ControlToValidate="Manager_ID"
                                    CssClass="field-validation-error" ErrorMessage="The Manager_ID is required." />
                            </li>
                            <li>
                                <asp:Label ID="Label8" runat="server" AssociatedControlID="Mobile_No">Mobile No:</asp:Label>
                                <asp:TextBox runat="server" ID="Mobile_No" TextMode="Phone" />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" CssClass="field-validation-error"
                                    ErrorMessage="Invalid Mobile no" ControlToValidate="Mobile_No" 
                                    ValidationExpression="[789]{1}[0-9]{9}"></asp:RegularExpressionValidator>
                            </li>
                            <li>
                                <asp:Label ID="Label9" runat="server" AssociatedControlID="Date_OF_Joining">Date OF Joining:</asp:Label>
                                <asp:TextBox runat="server" ID="Date_OF_Joining" TextMode="Date" />
                                <asp:RequiredFieldValidator ID="Date_OF_Joining_valid" runat="server" ControlToValidate="Date_OF_Joining"
                                    CssClass="field-validation-error" ErrorMessage="The Doj is required." />
                            </li>
                        </ol>
                        <asp:Button ID="Button1" runat="server" Text="Register" 
                            OnClick="Button1_Click" />
                        <asp:Label ID="Sts" runat="server"></asp:Label>
                    </fieldset>
                
</asp:Content>
