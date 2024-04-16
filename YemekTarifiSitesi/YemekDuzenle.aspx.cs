using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class YemekDuzenle : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Yemek_id"];

            if (Page.IsPostBack == false)
            {
                SqlCommand cmd = new SqlCommand("Select * From Yemekler Where Yemek_id = @p1", conn.baglanti());
                cmd.Parameters.AddWithValue("@p1", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox3.Text = dr[3].ToString();
                }

                SqlCommand cmd2 = new SqlCommand("Select * From Kategoriler", conn.baglanti());
                SqlDataReader dr2 = cmd2.ExecuteReader();
                DropDownList1.DataTextField = "Kategori_ad";
                DropDownList1.DataValueField = "Kategori_id";

                DropDownList1.DataSource = dr2;
                DropDownList1.DataBind();
            }
            conn.baglanti().Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Resim/" + FileUpload1.FileName));

            SqlCommand cmd = new SqlCommand("Update Yemekler Set Yemek_ad = @p1, Yemek_malzeme = @p2, Yemek_tarif = @p3, Kategori_id = @p4, Yemek_resim = @p6 Where Yemek_id = @p5", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@p3", TextBox3.Text);
            cmd.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@p5", id);
            cmd.Parameters.AddWithValue("@p6", "~/Resim/" + FileUpload1.FileName);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Yemek durumunu sorgula
            SqlCommand cmd = new SqlCommand("SELECT Durum FROM Yemekler WHERE Yemek_id = @p1", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", id);
            bool durum = Convert.ToBoolean(cmd.ExecuteScalar());

            // Durumu tersine çevir ve güncelle
            bool yeniDurum = !durum;
            SqlCommand cmdUpdate = new SqlCommand("UPDATE Yemekler SET Durum = @p1 WHERE Yemek_id = @p2", conn.baglanti());
            cmdUpdate.Parameters.AddWithValue("@p1", yeniDurum);
            cmdUpdate.Parameters.AddWithValue("@p2", id);
            cmdUpdate.ExecuteNonQuery();

            // Veritabanı bağlantısını kapat
            conn.baglanti().Close();
        }
    }
}