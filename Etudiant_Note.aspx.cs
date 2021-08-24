using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Etudiant_Note : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string requete;
        requete = "";
        requete = "select idetudiant,nom,prenom from Personnes,Etudiants where Etudiants.personneetudiant = Personnes.idpersonne";
        SqlCommand pat = new SqlCommand(requete, n);
        SqlDataReader dr = pat.ExecuteReader();
        while (dr.Read())
        {
            etudiantinput.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1) + " "+ dr.GetString(2));
        }
        n.Close();
        n.Open();

        requete = "select idnote,nomcours,noteobtenu from Cours,Note where Note.coursid = Cours.idcours;";
        SqlCommand ant = new SqlCommand(requete, n);
        SqlDataReader dr1 = ant.ExecuteReader();
        while (dr1.Read())
        {
            noteinput.Items.Add(dr1.GetInt32(0) + " " + dr1.GetString(1) + " " + dr1.GetString(2));
        }
        n.Close();

    }
    protected void etudiantinput_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void etudiantinput_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string etud = etudiantinput.SelectedItem.ToString();
        string[] etudiant = etud.Split(' ');
        string not = noteinput.SelectedItem.ToString();
        string[] note = not.Split(' ');
        string crdep = "insert into Etudiant_Note(etudiant,note)values(" + etudiant[0] + "," + note[0] + ")";
        SqlCommand com = new SqlCommand(crdep, n);
        com.ExecuteNonQuery();
        Response.Write("<script>alert('enregistrement reussi avec success')</script>");
    }
}