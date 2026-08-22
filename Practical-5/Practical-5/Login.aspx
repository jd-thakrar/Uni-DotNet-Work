<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Practical_5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h3>Login</h3>
         <table>
             <tr>
                  <td><asp:Label ID="Label1" runat="server" Text="Label">Username</asp:Label></td>
                  <td><asp:TextBox ID="Username" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                  <td><asp:Label ID="Label2" runat="server" Text="Label">Password</asp:Label></td>
                  <td><asp:TextBox ID="Password" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                 <td></td>
                 <td><asp:CheckBox ID="Remember" runat="server" />Remember</td>
              </tr>
              <tr>
                  <td colspan="2"><asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></td>
              </tr>
         </table>
    </form>
</body>
</html>
