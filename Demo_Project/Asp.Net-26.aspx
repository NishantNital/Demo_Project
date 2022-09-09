<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.Net-26.aspx.cs" Inherits="Demo_Project.Asp_Net_26" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server"
                RepeatDirection="Horizontal" AutoPostBack="True"
                OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                <asp:ListItem Text="Diploma" Value="1"></asp:ListItem>
                <asp:ListItem Text="Graduate" Value="2"></asp:ListItem>
                <asp:ListItem Text="Post Graduate" Value="3"></asp:ListItem>
                <asp:ListItem Text="Doctrate" Value="4"></asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="78px" Width="127px"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
