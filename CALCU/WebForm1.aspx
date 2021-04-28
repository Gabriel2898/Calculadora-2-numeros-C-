<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CALCU.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        

        <table class="auto-style1">
            <tr>
                <td colspan="4">
                    <asp:TextBox ID="txtpantalla" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="1" OnClick="Button1_Click" /></td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="2" OnClick="Button2_Click" /></td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="3" OnClick="Button3_Click" /></td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="-" OnClick="Button4_Click" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button5" runat="server" Text="4" OnClick="Button5_Click" /></td>
                <td>
                    <asp:Button ID="Button6" runat="server" Text="5" OnClick="Button6_Click" /></td>
                <td>
                    <asp:Button ID="Button7" runat="server" Text="6" OnClick="Button7_Click" /></td>
                <td>
                    <asp:Button ID="Button8" runat="server" Text="*" OnClick="Button8_Click" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button9" runat="server" Text="7" OnClick="Button9_Click" /></td>
                <td>
                    <asp:Button ID="Button10" runat="server" Text="8" OnClick="Button10_Click" /></td>
                <td>
                    <asp:Button ID="Button11" runat="server" Text="9" OnClick="Button11_Click" /></td>
                <td>
                    <asp:Button ID="Button12" runat="server" Text="/" OnClick="Button12_Click" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button13" runat="server" Text="." OnClick="Button13_Click" /></td>
                <td>
                    <asp:Button ID="Button14" runat="server" Text="0" OnClick="Button14_Click" /></td>
                <td>
                    <asp:Button ID="Button15" runat="server" Text="=" OnClick="Button15_Click" /></td>
                <td>
                    <asp:Button ID="Button16" runat="server" Text="+" OnClick="Button16_Click" /></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Button ID="Button17" runat="server" Text="Limpiar" /></td>
            </tr>
        </table>
        

    </form>
</body>
</html>
