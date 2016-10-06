<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="Manager_PendingRequest.aspx.cs" Inherits="WebApplication2.Account.Manager.Manager_PendingRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style3
        {
            width: 20%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <h3>New Asset Requests</h3>
 
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" ForeColor="Black" Width="226px" 
        Height="16px" CellSpacing="4" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle"
         >
        <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BorderStyle="Solid"  BackColor="Black" Font-Bold="True" 
            ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle"/>
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White"  />
    <SortedAscendingCellStyle BorderStyle="Solid" BackColor="#F1F1F1"  BorderWidth="3px"
            BorderColor="Black" HorizontalAlign="Center"/>
        <Columns>
        
            <asp:TemplateField HeaderText="Select">
                <ItemTemplate>
                    <asp:CheckBox ID="Select" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Emp_ID" HeaderText="EID" />
            <asp:BoundField DataField="Request_ID" HeaderText="Rid" />
            <asp:BoundField DataField="Short_ID" HeaderText="ShortId" />
            <asp:BoundField DataField="AssetName" HeaderText="Asset Name" />
            <asp:BoundField DataField="RequestDate" HeaderText="Requested Date" />
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                <fieldset>
                <legend>Action</legend>
                    <table align="center" class="auto-style3">
                        <tr>
                            <td>
                                <asp:RadioButton ID="Reject" runat="server" GroupName="Action" Text="Reject" />
                            </td>
                            <td>
                                <asp:RadioButton ID="SendBack" runat="server" GroupName="Action" 
                                    Text="SendBack" />
                            </td>
                            <td>
                                <asp:RadioButton ID="Approve" runat="server" GroupName="Action" 
                                    Text="Approve" />
                            </td>
                        </tr>
                    </table>
                        </fieldset>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    
        <h3>Transfer Request</h3>
       
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" CellSpacing="2" ForeColor="Black">
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <Columns>
        
            <asp:TemplateField HeaderText="Select">
                <ItemTemplate>
                    <asp:CheckBox ID="Select_1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="From_Emp_ID" HeaderText="From" />
            <asp:BoundField DataField="Transfer_ID" HeaderText="tid" />
            <asp:BoundField DataField="AssetName" HeaderText="Asset Name" />
            <asp:BoundField DataField="To_Emp_ID" HeaderText="To" />
            <asp:TemplateField HeaderText="Action_1">
                <ItemTemplate>
                <fieldset>
                <legend>Action</legend>
                    <table align="center" class="auto-style3">
                        <tr>
                            <td>
                                <asp:RadioButton ID="Reject_t" runat="server" GroupName="Action_t" Text="Reject" />
                            </td>
                            <td>
                                <asp:RadioButton ID="Approve_t" runat="server" GroupName="Action_t" 
                                    Text="Approve" />
                            </td>
                        </tr>
                    </table>
                        </fieldset>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    
        
       
    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        <br />

    </asp:Content>
