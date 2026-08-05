<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Practical_4.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h2>Registration Form</h2>
    <hr />
    <form id="form1" runat="server">
        <table style="border-collapse: separate; border-spacing: 0px 15px">
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Label">Name:</asp:Label></td>
                <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Label">Email:</asp:Label></td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label8" runat="server" Text="Label">Enrollment No:</asp:Label></td>
                <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Label">Address:</asp:Label></td>
                <td><asp:TextBox ID="TextBox3" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Label">Gender:</asp:Label></td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Female" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label">Country:</asp:Label></td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Text="Select Country" Value="" />
                        <asp:ListItem Text="INDIA" Value="INDIA" />
                        <asp:ListItem Text="Canada" Value="Canada" />
                        <asp:ListItem Text="UK" Value="UK" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Label">Hobbies:</asp:Label></td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Reading" /><br />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Writing" /><br />
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Drawing" />
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server" Text="Label">Event:</asp:Label></td>
                <td><asp:Image ID="Image1" runat="server" Height="233px" ImageUrl="~/Images/GSA.png" Width="184px" /></td>    
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
            </tr>
        </table>
        <br />
        <hr />
        <h3>Details</h3>
        <p>
            <asp:Label ID="Label9" runat="server"></asp:Label></p>
    </form>
</body>
</html>
