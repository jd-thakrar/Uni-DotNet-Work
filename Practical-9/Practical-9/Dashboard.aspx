
<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Dashboard.aspx.cs"
    Inherits="Practical_9.Dashboard" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Placement Dashboard</title>
</head>
<body>
    <form id="form1" runat="server">

        <h2>Placement Dashboard</h2>

        <table border="1">
            <tr>
                <th>Total Students</th>
                <th>Students Placed</th>
                <th>Students Not Placed</th>
            </tr>
            <tr>
                <td><asp:Label ID="lblTotal" runat="server" /></td>
                <td><asp:Label ID="lblPlaced" runat="server" /></td>
                <td><asp:Label ID="lblNotPlaced" runat="server" /></td>
            </tr>
        </table>

        <h2>Student Details</h2>

        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <ul>
                    <li>
                        <b>ID:</b> <%# Eval("Id") %><br />
                        <b>GR No:</b> <%# Eval("GRNo") %><br />
                        <b>Name:</b> <%# Eval("Name") %><br />
                        <b>Department:</b> <%# Eval("Department") %><br />
                        <b>Placement Status:</b> <%# Eval("PlacementStatus") %>
                    </li>
                </ul>
            </ItemTemplate>
        </asp:Repeater>

        <br />

        <asp:HyperLink ID="lnkDashboard" runat="server"
     NavigateUrl="Placement.aspx">
     View Placement
 </asp:HyperLink>

    </form>
</body>
</html>
