using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class TarifOnerDetay : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["Tarif_id"];
            if (Page.IsPostBack == false)
            {
                SqlCommand cmd = new SqlCommand("Select * From Tarifler Where Tarif_id = @p1", conn.baglanti());
                cmd.Parameters.AddWithValue("@p1", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox3.Text = dr[3].ToString();
                    TextBox4.Text = dr[5].ToString();
                    TextBox5.Text = dr[6].ToString();
                }
                SqlCommand cmd2 = new SqlCommand("Select * From Kategoriler",conn.baglanti());
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
            SqlCommand cmd = new SqlCommand("Update Tarifler Set Tarif_durum = 1 Where Tarif_id = @p1", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();

            SqlCommand cmd2 = new SqlCommand("Insert Into Yemekler (Yemek_ad,Yemek_malzeme,Yemek_tarif,Kategori_id) Values (@p1,@p2,@p3,@p4)", conn.baglanti());
            cmd2.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd2.Parameters.AddWithValue("@p2", TextBox2.Text);
            cmd2.Parameters.AddWithValue("@p3", TextBox3.Text);
            cmd2.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
            cmd2.ExecuteNonQuery();
            conn.baglanti().Close();
        }
    }
}