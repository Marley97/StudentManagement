<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Faculte.aspx.cs" Inherits="Faculte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 235px">
    
        <asp:Label ID="Label1" runat="server" Text="PAGE POUR ENREGISTRER FACULTE"></asp:Label>
        <br />
        <br />
        <asp:Label ID="nom" runat="server" Text="NOM"></asp:Label>
&nbsp;
        <asp:TextBox ID="nominput" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
