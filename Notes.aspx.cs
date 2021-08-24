using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Notes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string requete = " select idcours,nomcours from Cours";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();
        while (dr.Read())
        {
            coursinput.Items.Add(dr.GetInt32(0) + " " + dr.GetString(1)); 
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
        string crs = coursinput.SelectedItem.ToString();
        string[] cour = crs.Split(' ');
        string requete = "insert into Note(coursid,noteobtenu,type)values('" + cour[0] + "','" +noteinput.Text+ "','"+typeinput.Text+"')";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        Response.Write("Note enregistre avec success");
        n.Close();
        n.Open();
    }
}