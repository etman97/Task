<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Market.aspx.cs" Inherits="ReceiptTask.Market" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Product </td>
                    <td>
                        <asp:DropDownList ID="ddl_productsItems" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Quantity </td>
                    <td>
                        <asp:TextBox ID="txt_quantity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_addorderItem" runat="server" OnClick="btn_addorderItem_Click" Text="ADD" />
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td>Print Receipt </td>
                <td>
                    <asp:Button ID="btn_receipt" runat="server" OnClick="btn_receipt_Click" Text="Print" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gv_orderItems" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gv_order" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="btn_logout" runat="server" OnClick="btn_logout_Click" Text="log out" />
    </form>
</body>
</html>
