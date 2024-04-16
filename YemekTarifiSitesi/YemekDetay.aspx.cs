using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class YemekDetay : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string YemekId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            YemekId = Request.QueryString["Yemek_id"];
            SqlCommand cmd = new SqlCommand("Select Yemek_ad From Yemekler Where Yemek_id = @p1", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", YemekId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Label3.Text = dr[0].ToString();
            }

            SqlCommand cmd2 = new SqlCommand("Select * From Yorumlar Where Yemek_id = @p1 and Yorum_onay = 1", conn.baglanti());
            cmd2.Parameters.AddWithValue("@p1", YemekId);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataList2.DataSource = dr2;
            DataList2.DataBind();

            conn.baglanti().Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Yorumlar (Yorum_adsoyad, Yorum_mail, Yorum_icerik, Yemek_id) Values (@p1, @p2, @p3, @p4)", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@p3", TextBox3.Text);
            cmd.Parameters.AddWithValue("@p4", YemekId);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
        }
    }
}