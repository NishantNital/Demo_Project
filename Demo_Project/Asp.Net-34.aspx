﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.Net-34.aspx.cs" Inherits="Demo_Project.Asp_Net_34" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server" />
<table>
    <tr>
        <td>Name:</td>
        <td>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>Gender:</td>
        <td>
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>Department:</td>
        <td>
            <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
            </td>
    </tr>
</table>
<asp:Button ID="Button1" runat="server" Text="Update Employee" 
    onclick="Button1_Click" />&nbsp;
<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
    Text="Load Employee" />


        </div>
    </form>
</body>
</html>
