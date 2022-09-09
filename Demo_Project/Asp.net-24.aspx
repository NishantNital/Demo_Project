<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.net-24.aspx.cs" Inherits="Demo_Project.Asp_net_24" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="buttonSelectAll" runat="server" Text="Select All" 
    onclick="buttonSelectAll_Click" /> 
&nbsp; 
<asp:Button ID="buttonDeselectAll" runat="server" Text="De-Select All" 
    onclick="buttonDeselectAll_Click" />
<br />
<asp:CheckBoxList ID="CheckBoxList1" runat="server"
    RepeatDirection="Horizontal">
    <asp:ListItem Text="Diploma" Value="1"></asp:ListItem>
    <asp:ListItem Text="Graduate" Value="2"></asp:ListItem>
    <asp:ListItem Text="Post Graduate" Value="3"></asp:ListItem>
    <asp:ListItem Text="Doctrate" Value="4"></asp:ListItem>
</asp:CheckBoxList>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
&nbsp;</div>
    </form>
</body>
</html>
