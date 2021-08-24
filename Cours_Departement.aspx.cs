using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Cours_Departement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string requete;
        requete = "";
        requete = "select idfaculte,nomdepartement from Faculte,Departement where Departement.faculteid = Faculte.idfaculte";
        SqlCommand pat = new SqlCommand(requete, n);
        SqlDataReader dr = pat.ExecuteReader();
        while (dr.Read())
        {
            departementinput.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1));
        }
        n.Close();
        n.Open();

        requete = "select idcours,nomcours from Cours";
        SqlCommand ant = new SqlCommand(requete, n);
        SqlDataReader dr1 = ant.ExecuteReader();
        while (dr1.Read())
        {
            coursinput.Items.Add(dr1.GetInt32(0) + " " + dr1.GetString(1));
        }
        n.Close();
    }
 
    protected void departementinput_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void coursinput_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string dep = departementinput.SelectedItem.ToString();
        string [] depart = dep.Split(' ');
        string crs = coursinput.SelectedItem.ToString();
        string [] cour = crs.Split(' ');
        string crdep = "insert into Cours_Departement(cours,departement)values("+cour[0]+","+depart[0]+")";
        SqlCommand com = new SqlCommand(crdep, n);
        com.ExecuteNonQuery();
        Response.Write("<script>alert('enregistrement reussi avec success')</script>");

    }
}