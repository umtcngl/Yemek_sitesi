using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Mesaj_id"];
            SqlCommand cmd = new SqlCommand("Select * From Mesajlar Where Mesaj_id = @p1", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", id);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TextBox1.Text = dr[4].ToString();
                TextBox2.Text = dr[1].ToString();
                TextBox3.Text = dr[2].ToString();
                TextBox4.Text = dr[3].ToString();
            }
            conn.baglanti().Close();
        }
    }
}