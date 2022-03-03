<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ReceiptTask.register" %>

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
                    <td>Customer Name</td>
                    <td>
                        <asp:TextBox ID="txt_cutomerName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Frist Name</td>
                    <td>
                        <asp:TextBox ID="txt_fname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Last name</td>
                    <td>
                        <asp:TextBox ID="txt_lname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Phone Number</td>
                    <td>
                        <asp:TextBox ID="txt_phonenumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txt_address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Postal Code</td>
                    <td>
                        <asp:TextBox ID="txt_postalCode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbl_stetus" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnregister" runat="server" OnClick="btnregister_Click" Text="Register" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
