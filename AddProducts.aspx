<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="ReceiptTask.AddProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Descraption</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txt_descrption" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td>Quantity</td>
                <td>
                    <asp:TextBox ID="txt_quantity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Price</td>
                <td>
                    <asp:TextBox ID="txt_price" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Postion</td>
                <td>
                    <asp:TextBox ID="txt_postion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl_stetus" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_addProduct" runat="server" OnClick="btn_addProduct_Click" Text="Add Product" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
