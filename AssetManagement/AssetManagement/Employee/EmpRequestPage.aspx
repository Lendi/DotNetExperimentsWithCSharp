<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard.Master"  AutoEventWireup="true" CodeBehind="EmpRequestPage.aspx.cs" Inherits="AssetManagement.Employee.EmpRequestPage" %>

<asp:Content ID="content2" ContentPlaceHolderID="navbar" runat="server">   
          <li><asp:LinkButton ID="lbRequests" runat="server" 
                  PostBackUrl="~/Employee/EmpRequestPage.aspx" Height="40px" style="margin-left: 0px" 
                  Width="175px" OnClick="lbRequests_Click">Requests</asp:LinkButton>
       </li>       
            <li><asp:LinkButton ID="lbAssets" runat="server" PostBackUrl="~/Employee/EmpAssetPage.aspx" Height="40px" Width="175px">Assets</asp:LinkButton>
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


<asp:Content ID="content" ContentPlaceHolderID="content" runat="server">
    

    




    <asp:Label ID="Label1" runat="server" Text="Asset :"></asp:Label>
&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Laptop</asp:ListItem>
        <asp:ListItem>Mobile</asp:ListItem>
        <asp:ListItem>Datacard</asp:ListItem>
        <asp:ListItem>Sim</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Justification :&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="tbComments" runat="server" TextMode="MultiLine" Height="74px"></asp:TextBox> 
    &nbsp;&nbsp;&nbsp;&nbsp;


    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
        OnClick="Submit_Click" />
    

    &nbsp;&nbsp;&nbsp;
    

    <asp:Label ID="RequestSubmission" runat="server"></asp:Label>
    

    <br />
<br />
<br />
<br />
    





    




    <asp:GridView ID="GridView1" runat="server" Width="663px" 
        AutoGenerateColumns="False" DataKeyNames="request_id" 
        DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="request_id" HeaderText="Request ID" ReadOnly="True" 
                SortExpression="request_id" />
            <asp:BoundField DataField="short_id" HeaderText="Username" 
                SortExpression="short_id" />
            <asp:BoundField DataField="asset_name" HeaderText="Asset Name" 
                SortExpression="asset_name" />
            <asp:BoundField DataField="request_date" HeaderText="Request Date" 
                SortExpression="request_date" />
            <asp:BoundField DataField="manager_approved_date" 
                HeaderText="Manager Approved Date" SortExpression="manager_approved_date" />
            <asp:BoundField DataField="remarks" HeaderText="Manager Remarks" 
                SortExpression="remarks" />
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%#((int)Eval("request_status")==5)?"Approved":((int)Eval("request_status")==4)?"reject":"Pending" %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>




    </asp:GridView>
    

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:AssetManagementConnectionString %>" 
        SelectCommand="SELECT [request_id], [short_id], [asset_name], [request_status], [request_date], [manager_approved_date], [remarks] FROM [RequestInfo] WHERE ([emp_id] = @emp_id)">
        <SelectParameters>
            <asp:SessionParameter Name="emp_id" SessionField="Eid" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    

</asp:Content>