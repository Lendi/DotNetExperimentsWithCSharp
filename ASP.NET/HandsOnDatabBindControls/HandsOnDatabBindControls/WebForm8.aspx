<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="HandsOnDatabBindControls.WebForm8" %>

<!DOCTYPE html>

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
            width: 199px;
        }
        .auto-style3
        {
            width: 199px;
            height: 114px;
        }
        .auto-style4
        {
            height: 114px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style2">EmpID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Upload Image</td>
                <td>
                    <asp:FileUpload ID="FileUploadBrowse" runat="server" />
                    <asp:Button ID="btnPreview" runat="server" OnClick="Button1_Click" 
                        Text="Preview" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    <asp:Image ID="Image1" runat="server" Height="210px" Width="215px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Upload" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
