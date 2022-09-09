<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asp.Net-33.aspx.cs" Inherits="Demo_Project.Asp_Net_33" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" DayNameFormat="Full" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" OnVisibleMonthChanged="Calendar1_VisibleMonthChanged" SelectionMode="DayWeekMonth" SelectMonthText="Select Month" SelectWeekText="Select Week" Width="511px">
            <DayHeaderStyle BackColor="Yellow" BorderColor="#00CC00" Font-Bold="True" Font-Size="8pt" />
            <DayStyle BackColor="#66FFFF" BorderColor="#990099" BorderStyle="Outset" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <SelectorStyle BackColor="#00FF99" BorderColor="#009999" BorderStyle="Solid" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
    </form>
</body>
</html>
