<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Learning_Web_Forms.Default"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<%--
    <form runat ="server">
        <asp:Label runat="server" ID="l1" Text="name"></asp:Label>
        <asp:TextBox runat="server" ID="name" TextMode="MultiLine" Rows="4"></asp:TextBox>
        
        <br />

        <asp:Label runat="server" ID="l2" Text="Hobbies"></asp:Label>
        <asp:CheckBox ID="c2" runat="server" Text="C++"/>
        <asp:CheckBox ID="c1" runat="server" Text="Java"/>

        <br />

        <asp:Label ID="gen" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButton text="Male" GroupName ="gender" runat="server" ID="male"/>
        <asp:RadioButton text="Female" GroupName ="gender" runat="server" ID="female"/>
        
        <br />

        <asp:Image ImageUrl="~/image/1.png" Width="150px" AlternateText="none" runat="server" ID="img"/>
    
        <br />

        <asp:HyperLink runat="server" ID="hp" NavigateUrl="www.cbthakrar.com" Text="C B THAKRAR" Target="_blank"/>
    
        <br />

         <asp:DropDownList ID="drop" runat="server" AutoPostBack="true">
            <asp:ListItem Text="computer"></asp:ListItem>
            <asp:ListItem Text="it"></asp:ListItem>
        </asp:DropDownList>

        <br/>
        <asp:ListBox ID="ls" runat="server" Rows="2" SelectionMode="Multiple">
            <asp:ListItem Text="Fortuner"></asp:ListItem>
            <asp:ListItem Text="X7"></asp:ListItem>
        </asp:ListBox>

        <br />
        <asp:Button text="Submit" ID="btn" runat="server"/>
    </form>
--%>
<form id="form" runat="server">
    <div style="margin: 50px;">
       <asp:AdRotator ID ="ad" runat="server" OnAdCreated="ad_AdCreated" AdvertisementFile="~/Ads.xml" />
        <br />
        <br />
        <asp:Label ID="sponsor" runat="server" Font-Bold="true" ForeColor="Blue"></asp:Label>

        <asp:DataGrid ID="dg" runat="server" AutoGenerateColumns="true" AllowPaging="true" PageSize="2" OnPageIndexChanged="dg_PageIndexChanged"></asp:DataGrid>
        <br />
        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="true" DataKeyNames="Roll No." AllowPaging="true" PageSize="2" OnPageIndexChanging="gv_PageIndexChanging"></asp:GridView>
    </div>
</form>
</body>
</html>
