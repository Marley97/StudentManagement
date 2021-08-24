using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Authentification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string requete = "select * from Utilisateur where iduser = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'";
        SqlCommand com = new SqlCommand(requete, n);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("menu.aspx");
        }
        else
        {
            Response.Write("<script>alert('echec de connection')</script>");
        }
    }
}