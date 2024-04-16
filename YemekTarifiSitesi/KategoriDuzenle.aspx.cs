using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class KategoriAdminDetay : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Kategori_id"];

            if (Page.IsPostBack == false)
            {
                SqlCommand cmd = new SqlCommand("Select * From Kategoriler Where Kategori_id = @p1", conn.baglanti());
                cmd.Parameters.AddWithValue("@p1", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                }
            }
            conn.baglanti().Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Kategoriler Set Kategori_ad = @p1, Kategori_adet = @p2 Where Kategori_id = @p3", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@p3", id);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
        }
    }
}