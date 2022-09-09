<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.Net-28.aspx.cs" Inherits="Demo_Project.Asp_Net_28" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="CountriesBulletedList" runat="server"
                BulletStyle="Circle" DisplayMode="LinkButton" OnClick="CountriesBulletedList_Click" Target="_search">
                <asp:ListItem Text="Google" Value="http://google.com"></asp:ListItem>
                <asp:ListItem Text="Youtube" Value="http://Youtube.com"></asp:ListItem>
                <asp:ListItem Text="Blogger" Value="http://Blooger.com"></asp:ListItem>
                <asp:ListItem Text="Gmail" Value="http://Gmail.com"></asp:ListItem>
            </asp:BulletedList>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
