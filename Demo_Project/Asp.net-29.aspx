﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.net-29.aspx.cs" Inherits="Demo_Project.Asp_net_29" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
               <%-- <asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>--%>
            </asp:DropDownList>
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <%--<asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>--%>
            </asp:CheckBoxList>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatLayout="OrderedList">
                <%--<asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>--%>
            </asp:RadioButtonList>
            <br />
            <asp:ListBox ID="ListBox1" runat="server">
                <%--<asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>--%>
            </asp:ListBox>
            <br />
            <asp:BulletedList ID="BulletedList1" runat="server">
               <%-- <asp:ListItem Text="Item1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Item2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Item3" Value="3"></asp:ListItem>--%>
            </asp:BulletedList>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
