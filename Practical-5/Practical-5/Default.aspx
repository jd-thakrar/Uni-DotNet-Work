<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practical_5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <h2>Select the date of Leave:</h2>
        <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender"></asp:Calendar>
      <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="height: 26px" />
    </form>
</body>
</html>
