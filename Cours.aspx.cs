using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Cours : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source = AVELINPC;initial catalog = Etudiant;user id=Marley97 password=hermes97;Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string requete = "insert into Cours(nomcours,volume,prof)values('"+nomcinput.Text+"','"+volumeinput.Text+"','"+professeurinput.Text+"')";
        SqlCommand com = new SqlCommand(requete, n);
        com.ExecuteNonQuery();
        Response.Write("Cours Enregistre avec succes");
        n.Close();
        n.Open();
    }
}
