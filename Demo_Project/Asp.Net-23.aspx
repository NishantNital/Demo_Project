﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.Net-23.aspx.cs" Inherits="Demo_Project.Asp_Net_23" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="checkboxListEducation" runat="server" 
            RepeatDirection="Horizontal">
            <asp:ListItem Text="Diploma" Value="1"></asp:ListItem>
            <asp:ListItem Text="Graduate" Value="2"></asp:ListItem>
            <asp:ListItem Text="Post Graduate" Value="3"></asp:ListItem>
            <asp:ListItem Text="Doctrate" Value="4"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        </div>
    </form>
</body>
</html>
