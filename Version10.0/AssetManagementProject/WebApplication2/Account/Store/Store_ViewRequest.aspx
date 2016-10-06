<%@ Page Title="" Language="C#" MasterPageFile="~/Store.Master" AutoEventWireup="true" CodeBehind="Store_ViewRequest.aspx.cs" Inherits="WebApplication2.Account.Store.Store_ViewRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
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
<asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
</asp:Content>
