<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LinkKS.UI.ASPNet._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Şifre"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="txtResult" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnGetir" runat="server" Text="Bilgileri Getir" OnClick="btnGetir_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
