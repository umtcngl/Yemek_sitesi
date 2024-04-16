using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class YorumDetay : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Yorum_id"];

            if (Page.IsPostBack == false)
            {
                SqlCommand cmd = new SqlCommand("Select Yorum_adsoyad, Yorum_mail, Yorum_icerik, Yemek_ad From Yorumlar yorum Inner Join Yemekler yemek On yemek.Yemek_id = yorum.Yemek_id Where Yorum_id = @p1", conn.baglanti());
                cmd.Parameters.AddWithValue("@p1", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[0].ToString();
                    TextBox2.Text = dr[1].ToString();
                    TextBox3.Text = dr[2].ToString();
                    TextBox4.Text = dr[3].ToString();
                }
            }
            conn.baglanti().Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Yorumlar Set Yorum_icerik = @p1, Yorum_onay = @p2 Where Yorum_id = @p3", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", TextBox3.Text);
            cmd.Parameters.AddWithValue("@p2", "True");
            cmd.Parameters.AddWithValue("@p3", id);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
        }
    }
}