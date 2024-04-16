using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string id = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                id = Request.QueryString["Kategori_id"];
                islem = Request.QueryString["islem"];
            }
            Panel2.Visible = false;
            Panel4.Visible = false;
            SqlCommand cmd = new SqlCommand("Select * From Kategoriler", conn.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();

            if (islem == "sil")
            {
                SqlCommand cmdsil = new SqlCommand("Delete From Kategoriler Where Kategori_id = @p1", conn.baglanti());
                cmdsil.Parameters.AddWithValue("@p1", id);
                cmdsil.ExecuteNonQuery();
            }

            conn.baglanti().Close();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Kategoriler (Kategori_ad) Values (@p1)", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.ExecuteNonQuery();
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
    }
}