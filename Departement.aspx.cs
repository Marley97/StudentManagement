using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class Departement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string requete = " select idfaculte,nomfaculte from Faculte";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            faculteinput.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1)); 
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string dep = faculteinput.SelectedItem.ToString();
        string[] depart = dep.Split(' ');
        string requete = "insert into Departement(faculteid,nomdepartement)values('" + depart[0] + "','"+TextBox1.Text+"')";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        n.Close();
        n.Open();
    }
}