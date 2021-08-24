<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cours_Departement.aspx.cs" Inherits="Cours_Departement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 402px">
    
        <br />
        <asp:Label ID="Label3" runat="server" Text="Page Cours_Association"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Departement"></asp:Label>
&nbsp;<asp:DropDownList ID="departementinput" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="departementinput_SelectedIndexChanged" Width="249px">
        </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Cours"></asp:Label>
        <asp:DropDownList ID="coursinput" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="coursinput_SelectedIndexChanged1" Width="299px">
        </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
