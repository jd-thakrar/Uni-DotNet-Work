<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Leave.aspx.cs" Inherits="Practical_5.Leave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <h2>Fill The Application</h2>
          <table>
              <tr>
                  <td>Enter the Name: </td>
                  <td><asp:TextBox ID="Name" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                  <td>Enter the ID:</td>
                  <td><asp:TextBox ID="ID" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                 <td>Enter the Reason:</td>
                 <td><asp:TextBox ID="Reason" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                  <td>Entered Date: </td>
                  <td><asp:Label ID="Date" runat="server" Text="Label"></asp:Label></td>
              </tr>
              <tr>
                 <td>Enter the Reason:</td>
                 <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                  <td>Enter the swap faculty: </td>
                  <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                  <td><asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" /></td>
                  <td><asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" /></td>
              </tr>
          </table>
    </form>
    
    <br />
    <hr />

    <h3>Details</h3>
    <p>
    <asp:Label ID="Label9" runat="server"></asp:Label></p>

</body>
</html>
