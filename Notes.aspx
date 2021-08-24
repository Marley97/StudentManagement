<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Notes.aspx.cs" Inherits="Notes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 349px">
    <form id="form1" runat="server">
    <div style="height: 348px">
    
        <asp:Label ID="Label1" runat="server" Text="PAGE POUR ENREGISTRER LES NOTES"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cours"></asp:Label>
        <asp:DropDownList ID="coursinput" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="NoteObtenu"></asp:Label>
&nbsp;
        <asp:TextBox ID="noteinput" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Type"></asp:Label>
        <asp:TextBox ID="typeinput" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
