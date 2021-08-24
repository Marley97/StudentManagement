<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Authentification.aspx.cs" Inherits="Authentification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="materialdesignicons.min.css" rel="stylesheet" />
<link href="forms.css" rel="stylesheet" />
<link href="mdi/css/materialdesignicons.min.css" rel="stylesheet" />
<title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
		    <div class="header">
			    <h1>Login</h1>
                <a href="Notes.aspx"></a>
		    </div>
		    <div class="main">
			    <span>
                    <asp:TextBox ID="TextBox1" placeholder="Username" runat="server"></asp:TextBox>
			    </span>
			    <span>
                    <asp:TextBox ID="TextBox2" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
			    </span>
			    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Connexion" />
		    </div>
	    </div>
    </form>
    
</body>
</html>
