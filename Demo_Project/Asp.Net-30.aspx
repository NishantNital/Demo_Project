<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.Net-30.aspx.cs" Inherits="Demo_Project.Asp_Net_30" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnUpload" runat="server" Text="Upload File"
                OnClick="btnUpload_Click" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblMessage" Font-Bold="true" runat="server">
            </asp:Label>

        </div>
    </form>
</body>
</html>
