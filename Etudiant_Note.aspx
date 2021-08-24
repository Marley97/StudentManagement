<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Etudiant_Note.aspx.cs" Inherits="Etudiant_Note" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 471px">
    
        <asp:Label ID="Label1" runat="server" Text="PAGE POUR ENREGISTRE LES NOTES DES ETUDIANTS"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Etudiant"></asp:Label>
&nbsp;<asp:DropDownList ID="etudiantinput" runat="server" AutoPostBack="True" Height="28px" Width="253px" OnSelectedIndexChanged="etudiantinput_SelectedIndexChanged1">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Notes"></asp:Label>
        <asp:DropDownList ID="noteinput" runat="server" Height="16px" Width="260px" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
