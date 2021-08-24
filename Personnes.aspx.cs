using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Personnes : System.Web.UI.Page
{
    public static int personneid;
    public static string statuts = " ";
    protected void Page_Load(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string requete = " select iddepartement,nomdepartement from Departement";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            departementinput.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1));
        }
        n.Close();
        n.Open();
        requete = "select idpersonne from Personnes";
        SqlCommand com1 = new SqlCommand(requete, n);

        SqlDataReader dr1 = com1.ExecuteReader();
        DropDownList1.Items.Clear();
        while (dr1.Read())
        {
            DropDownList1.Items.Add(dr1.GetInt32(0).ToString());
        }
        n.Close();

    }
    protected void statutinput_SelectedIndexChanged(object sender, EventArgs e)
    {

        Personnes.statuts = statutinput.SelectedItem.ToString();
        if(statuts=="Etudiant"){
            string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
            SqlConnection n = new SqlConnection(ch);
            n.Open();
            string requete = "select idpersonne,idetudiant from Personnes,Etudiants where Etudiants.personneetudiant = Personnes.idpersonne";
            SqlCommand com9 = new SqlCommand(requete, n);
            SqlDataReader dr7 = com9.ExecuteReader();
            DropDownList1.Items.Clear();
            while (dr7.Read())
            {
                DropDownList1.Items.Add(dr7.GetInt32(0).ToString());
            }
            n.Close();
            nom.Visible = true;
            prenom.Visible = true;
            nominput.Visible = true;
            prenominput.Visible = true;
            statut.Visible = true;
            statutinput.Visible = true;
            genre.Visible = true;
            genreinput.Visible = true;
            age.Visible = true;
            ageinput.Visible = true;
            aa.Visible = true;
            aainput.Visible = true;
            departement.Visible = true;
            departementinput.Visible = true;
            password.Visible = false;
            passwordinput.Visible = false;
            profil.Visible = false;
            profilinput.Visible = false;     
        }
        else if(statuts=="User"){
            nom.Visible = true;
            prenom.Visible = true;
            nominput.Visible = true;
            prenominput.Visible = true;
            statut.Visible = true;
            statutinput.Visible = true;
            password.Visible = true;
            passwordinput.Visible = true;
            profil.Visible = true;
            profilinput.Visible = true;
            genre.Visible = false;
            genreinput.Visible = false;
            age.Visible = false;
            ageinput.Visible = false;
            aa.Visible = false;
            aainput.Visible = false;
            departement.Visible = false;
            departementinput.Visible = false;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        if(statuts=="Etudiant"){
            string dep = departementinput.SelectedItem.ToString();
            string[] depart = dep.Split(' ');
            string requete ="insert into Personnes(nom,prenom,statut)values('"+nominput.Text+"','"+prenominput.Text+"','"+statuts+"')";
            SqlCommand com = new SqlCommand(requete, n);
            com.ExecuteNonQuery();
            Response.Write("Etudiant Enregistrer avec success");
            n.Close();
            n.Open();
            string persAct = "select max(idpersonne) as 'id' from Personnes";
            com = new SqlCommand(persAct, n);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    personneid = dr.GetInt32(0);
                }
            }
            n.Close();
            n.Open();
            string etud = "insert into Etudiants(personneetudiant,departementid,genre,age,anneeacademique)values(" + personneid + ",'"+depart[0]+"','" + genreinput.Text + "','" + ageinput.Text + "','" + aainput.Text + "')";
            com = new SqlCommand(etud, n);
            com.ExecuteNonQuery();
            n.Close();
            n.Open();
        }
        if(statuts=="User"){
            string requete = "insert into Personnes(nom,prenom,statut)values('"+ nominput.Text+"','" + prenominput.Text + "','" +statuts+ "')";
            SqlCommand com = new SqlCommand(requete, n);
            com.ExecuteNonQuery();
            Response.Write("Utilisateur Enregistrer avec success");
            n.Close();
            n.Open();
            string persAct = "select max(idpersonne) as 'id' from Personnes";
            com = new SqlCommand(persAct, n);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    personneid = dr.GetInt32(0);
                }
            }
            n.Close();
            n.Open();
            string ut = "insert into Utilisateur(personneuser,profil,password)values('" + personneid + "','" + profilinput.Text + "','" + passwordinput.Text + "')";
            com = new SqlCommand(ut, n);
            com.ExecuteNonQuery();
            n.Close();
            n.Open();

        }
    }
    protected void departementinput_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        int a = Int32.Parse(DropDownList1.SelectedItem.ToString());
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);

        Personnes.statuts = DropDownList1.SelectedItem.ToString();
        string requete4 = "";
        if (Personnes.statuts == "Etudiant")
        {
            n.Open();
            
            requete4 = "update Etudiants set anneeacademique,genre,age = '" + aainput.Text + "' '"+genreinput.Text+"' '"+ageinput.Text+"' where personneetudiant =" + a + "";
            SqlCommand com5 = new SqlCommand(requete4, n);
            com5.ExecuteNonQuery();
            n.Close();
            n.Open();
            requete4 = "update Personnes set nom = '" + nominput.Text + "',prenom = '" + prenominput.Text + "' WHERE Personne.idpersonne = "+DropDownList1.SelectedItem.Value+"";
            SqlCommand com6 = new SqlCommand(requete4, n);
            com6.ExecuteNonQuery();
            n.Close();
        }

        if (Personnes.statuts == "Utilisateur")
        {
            n.Open();
            requete4 = "update Utilisateur set Profil = '" + profilinput.SelectedItem + "', password ='" + passwordinput.Text + "' where idutilisateur =" + a + "";
            SqlCommand com7 = new SqlCommand(requete4, n);
            com7.ExecuteNonQuery();
            n.Close();

            n.Open();
            requete4 = "update Personnes set nom = '" + nominput.Text + "',prenom = '" + prenominput.Text + "' WHERE Personne.idpersonne = " + DropDownList1.SelectedItem.Value + "";
            SqlCommand com8 = new SqlCommand(requete4, n);
            com8.ExecuteNonQuery();
            n.Close();

        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int a = Int32.Parse(DropDownList1.SelectedItem.ToString());
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string requete3 = "";
        requete3 = "select nom,prenom,age,genre,anneeacademique from Personnes,Etudiants where Etudiants.idetudiant = " + a + " and Personnes.idpersonne = Etudiants.personneetudiant";
        SqlCommand com3 = new SqlCommand(requete3, n);
        SqlDataReader dr5 = com3.ExecuteReader();

        if (dr5.Read())
        {
           nominput.Text = dr5.GetString(0);
           prenominput.Text= dr5.GetString(1);
           ageinput.Text = dr5.GetString(2);
           genreinput.Text = dr5.GetString(3);
          aainput.Text = dr5.GetString(4);
        }
        n.Close();

        n.Open();
        requete3 = "select u.password,u.profil,p.nom,p.prenom from Utilisateur u,Personne p where Utilisateur.iduser = " + a + " and Personne.idpersonne = Utilisateur.personneuser";
        SqlCommand com4 = new SqlCommand(requete3, n);
        SqlDataReader dr6 = com4.ExecuteReader();
        if (dr6.Read())
        {
            passwordinput.Text = dr6.GetString(0);
            profilinput.Items.Add(dr6.GetInt32(1).ToString());
            nominput.Text = dr6.GetString(2);
            prenominput.Text = dr6.GetString(3);   
        }
        n.Close();
    }
}