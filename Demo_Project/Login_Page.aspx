<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="Demo_Project.Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 109px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label Text="First Name " runat ="server"/>
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:TextBox ID="first_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Last Name" runat ="server"/>
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:TextBox ID="last_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Contact" runat ="server"/>
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:TextBox ID="contact" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Gender" runat ="server"/>
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="1">Male</asp:ListItem>
                            <asp:ListItem Value="2">Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Address" runat ="server"/>
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:TextBox ID="address" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="User Name" runat ="server"/>
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Password" runat ="server"/>
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text=" Confirm Password" runat ="server"/>
                    </td>
                    <td colspan="2" class="auto-style1">
                        <asp:TextBox ID="confirmpassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2" class="auto-style1">
                    <asp:Button ID="Button1" runat="server" Text="Submit " OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Sign Up" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Log In " />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
