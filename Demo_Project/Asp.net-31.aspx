<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.net-31.aspx.cs" Inherits="Demo_Project.Asp_net_31" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator AdvertisementFile="~/Advertise.xml" ID="AdRotator1" Target="_blank" KeywordFilter="" runat="server" />
        </div>
    </form>
</body>
</html>
