<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="Demo_Project.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Load Data" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Clear Cache" />
        </div>
    </form>
</body>
</html>
