<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Practical_4.Index" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration Form</title>

</head>
<body style="background-color: #e2e8f0">
    <div style="display:flex; justify-content:center">
        <form id="form1" runat="server">
            <table style="border-collapse: separate; border-spacing: 0px 15px; border: 1px solid #cbd5e1; background-color: #ffffff; border-radius: 8px; padding: 15px 25px; box-shadow: 0 4px 6px -1px rgba(0, 0, 0, 0.05);">
                <tr>
                    <td colspan="3" style="text-align: center; font-weight: 500; border-bottom: 2px solid black"><h2>Student Registration Form</h2></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Label">Name:</asp:Label></td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Enter the student name" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Label">Email:</asp:Label></td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter the Email Address" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter the Valid email address" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label11" runat="server" Text="Label">Password</asp:Label></td>
                    <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter the passwrod" ControlToValidate="TextBox6" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label12" runat="server" Text="Label">Confirm Password</asp:Label></td>
                    <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter the Confirm passwrod" ControlToValidate="TextBox6" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password and Confirm Password shoud be same" ControlToCompare="TextBox6" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                   <td><asp:Label ID="Label10" runat="server" Text="Label">Number:</asp:Label></td>
                   <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                   <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter the mobile number" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label8" runat="server" Text="Label">Enrollment No:</asp:Label></td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter the enrollement number" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Label">Address:</asp:Label></td>
                    <td><asp:TextBox ID="TextBox3" runat="server" Rows="5" TextMode="MultiLine"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter the Address" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:Label ID="Label4" runat="server" Text="Label">Gender:</asp:Label></td>
                    <td class="auto-style1">
                        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender" Text="Male" />
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="Female" />
                    </td>
                    <td class="auto-style1"><asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Select the Gender" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator></td>
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
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Select the Country" ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label6" runat="server" Text="Label">Hobbies:</asp:Label></td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Reading" /><br />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Writing" /><br />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Drawing" />
                    </td>
                    <td><asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Select the hobbies" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label13" runat="server" Text="Label">Date:</asp:Label></td>
                    <td><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
                    <td><asp:CustomValidator ID="DateValid" runat="server" ErrorMessage="You must choose a date." ForeColor="Red" OnServerValidate="DateValid_ServerValidate"></asp:CustomValidator></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label7" runat="server" Text="Label">Event:</asp:Label></td>
                    <td><asp:Image ID="Image1" runat="server" Height="233px" ImageUrl="~/Images/GSA.png" Width="184px" /></td>    
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" style="background-color: #1e1e1e; color: #ffffff; border: none; padding: 10px 24px; font-size: 14px; font-weight: 600; border-radius: 6px; cursor: pointer; box-shadow: 0 2px 4px rgba(0,0,0,0.1);"/>
                    </td>
                </tr>
            </table>
            <br />
            <hr />
            <h3>Details</h3>
            <p>
                <asp:Label ID="Label9" runat="server"></asp:Label></p>
        </form>
    </div>
</body>
</html>
