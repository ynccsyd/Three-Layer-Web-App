<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BlockchainWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 407px;
            height: 221px;
        }
        .auto-style2 {
            color: #FF3300;
            font-size: x-large;
            text-align: center;
        }
        .auto-style5 {
            text-align: right;
            width: 123px;
        }
        .auto-style6 {
            width: 287px;
        }
        .auto-style7 {
            width: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1" style="border: thin solid #008080">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>Blockchain User Information</strong></td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>Username:</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtUsername" runat="server" Width="262px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>UserType:</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtUsertype" runat="server" Width="262px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>Address:</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="textAddress" runat="server" Width="262px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>ProducedEnergy:</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtProducedEnergy" runat="server" Width="262px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>ConsumedEnergy:</strong></td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtConsumedEnergy" runat="server" Width="262px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style6"> 
                        <asp:Button ID="BtnSave" runat="server" Text="SAVE" OnClick="BtnSave_Click1" />
                        <asp:Button ID="BtnUpdate" runat="server" Text="UPDATE" OnClick="BtnUpdate_Click"/>
                        <asp:Button ID="BtnDelete" runat="server" Text="DELETE" OnClick="BtnDelete_Click"/>
                    
                    </td>
                    
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="380px">
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

