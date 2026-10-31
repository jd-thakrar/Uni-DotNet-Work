
<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Placement.aspx.cs"
    Inherits="PlacementDashboard.Placement" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Placement Management</title>
</head>
<body>

    <form id="form1" runat="server">

        <h2>Placement Management</h2>

        <asp:Label ID="lblMessage" runat="server" />

        <br /><br />

        GR No:
        <asp:TextBox ID="txtGRNo" runat="server" />

        <br /><br />

        Name:
        <asp:TextBox ID="txtName" runat="server" />

        <br /><br />

        Department:
        <asp:TextBox ID="txtDepartment" runat="server" />

        <br /><br />

        Placement Status:
        <asp:DropDownList ID="ddlStatus" runat="server">
            <asp:ListItem Text="Placed" Value="Placed" />
            <asp:ListItem Text="Not Placed" Value="Not Placed" />
        </asp:DropDownList>

        <br /><br />

        <asp:Button ID="btnSave" runat="server"
            Text="Insert"
            OnClick="btnSave_Click" />

        <br /><br />

        <asp:HyperLink ID="lnkDashboard" runat="server"
            NavigateUrl="Dashboard.aspx">
            View Dashboard
        </asp:HyperLink>

        <hr />

        <h3>All Placement Records</h3>

        <asp:Repeater ID="Repeater1" runat="server"
            OnItemCommand="Repeater1_ItemCommand">

            <HeaderTemplate>
                <table border="1">
                    <tr>
                        <th>GR No</th>
                        <th>Name</th>
                        <th>Department</th>
                        <th>Placement Status</th>
                        <th>Action</th>
                    </tr>
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("GRNo") %></td>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Department") %></td>
                    <td><%# Eval("PlacementStatus") %></td>

                    <td>
                        <asp:Button ID="btnEdit" runat="server"
                            Text="Edit"
                            CommandName="EditRecord"
                            CommandArgument='<%# Eval("Id") %>' />

                        <asp:Button ID="btnDelete" runat="server"
                            Text="Delete"
                            CommandName="DeleteRecord"
                            CommandArgument='<%# Eval("Id") %>'
                            OnClientClick="return confirm('Are you sure you want to delete this record?');" />
                    </td>
                </tr>
            </ItemTemplate>

            <FooterTemplate>
                </table>
            </FooterTemplate>

        </asp:Repeater>

    </form>

</body>
</html>
