using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class Yemekler : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string id = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                id = Request.QueryString["Yemek_id"];
                islem = Request.QueryString["islem"];

                SqlCommand cmd2 = new SqlCommand("Select * From Kategoriler", conn.baglanti());
                SqlDataReader dr2 = cmd2.ExecuteReader();
                DropDownList1.DataTextField = "Kategori_ad";
                DropDownList1.DataValueField = "Kategori_id";

                DropDownList1.DataSource = dr2;
                DropDownList1.DataBind();
            }
            Panel2.Visible = false;
            Panel4.Visible = false;
            SqlCommand cmd = new SqlCommand("Select * From Yemekler", conn.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();

            if (islem == "sil")
            {
                SqlCommand cmdsil = new SqlCommand("Delete From Yemekler Where Yemek_id = @p1", conn.baglanti());
                cmdsil.Parameters.AddWithValue("@p1", id);
                cmdsil.ExecuteNonQuery();
            }

            conn.baglanti().Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel4.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Yemekler (Yemek_ad, Yemek_malzeme, Yemek_tarif, Kategori_id) Values (@p1, @p2, @p3, @p4)", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@p3", TextBox3.Text);
            cmd.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Update Kategoriler Set Kategori_adet = Kategori_adet + 1 Where Kategori_id = @p1", conn.baglanti());
            cmd2.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            cmd2.ExecuteNonQuery();

            conn.baglanti().Close();
        }
    }
}