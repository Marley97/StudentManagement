<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Personnes.aspx.cs" Inherits="Personnes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="bootstrap.min.css" rel="stylesheet" />
<link href="StyleSheet.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div class="form-container">
    <div class="form">
        <div class="form-group">
            <h3>Page Pour Enregistrer Personnes</h3>
            <div class="row">
            <div>
                <div class="input">
                    <asp:Label ID="Label2" CssClass="label-form" style ="color:white;" runat="server" Text="code"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
                <div class="input">
                    <asp:Label ID="nom" CssClass="label-form" runat="server" Text="NOM"></asp:Label>
                    <asp:TextBox ID="nominput" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input">
                    <asp:Label ID="prenom" CssClass="label-form" runat="server" Text="PRENOM"></asp:Label>
                    <asp:TextBox ID="prenominput" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input">
                    <asp:Label ID="statut" CssClass="label-form" runat="server" Text="STATUT"></asp:Label>
                    <asp:DropDownList CssClass="form-control" ID="statutinput" runat="server"  OnSelectedIndexChanged="statutinput_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>Choisir le statut</asp:ListItem>
                        <asp:ListItem>Etudiant</asp:ListItem>
                        <asp:ListItem>User</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div>
                <div class="input">
                    <asp:Label ID="password" CssClass="label-form" runat="server" Text="PASSWORD"></asp:Label>
                    <asp:TextBox class="form-control" ID="passwordinput" runat="server"  TextMode="Password"></asp:TextBox>
                </div>
                <div class="input">
                    <asp:Label ID="genre" CssClass="label-form" runat="server" Text="GENRE"></asp:Label>
                    <asp:TextBox class="form-control" ID="genreinput" runat="server"></asp:TextBox>
                </div>
                <div class="input">
                    <asp:Label ID="age" CssClass="label-form" runat="server" Text="AGE"></asp:Label>
                    <asp:TextBox class="form-control" ID="ageinput" runat="server" ></asp:TextBox>
                </div>  
            </div>
            <div>
                <div class="input">
                    <asp:Label ID="departement" CssClass="label-form" runat="server" Text="Departement"></asp:Label>
                    <asp:DropDownList class="form-control" ID="departementinput" runat="server"  OnSelectedIndexChanged="departementinput_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                <div class="input">
                    <asp:Label ID="aa" CssClass="label-form" runat="server" Text="A/A"></asp:Label>
                    <asp:TextBox class="form-control" ID="aainput" runat="server"  TextMode="Date"></asp:TextBox>
                </div>
                <div class="input">
                    <asp:Label ID="profil" CssClass="label-form" runat="server" Text="PROFIL"></asp:Label>
                    <asp:DropDownList class="form-control" ID="profilinput" runat="server" AutoPostBack="True">
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Utilisateur</asp:ListItem>
                    </asp:DropDownList>
                </div>  
            </div>
            </div>
            <div class="button">
                <asp:Button class="btn btn-success" ID="Button1" runat="server" OnClick="Button1_Click" Text="CONNEXION" />

                <asp:Button class="btn btn-success" ID="Button2" runat="server" Text="MODIFIER" OnClick="Button2_Click1" />
            </div>
            <a href="menu.aspx">home</a>
        </div>  
    </div>
    </div>
    </form>
</body>
</html>
	