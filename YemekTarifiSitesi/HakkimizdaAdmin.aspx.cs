using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class HakkimizdaAdmin : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            if (Page.IsPostBack == false)
            {
                SqlCommand cmd = new SqlCommand("Select Metin From Hakkimizda Where Id = 1", conn.baglanti());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TextBox1.Text = dr[0].ToString();
                }
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
            SqlCommand cmd = new SqlCommand("Update Hakkimizda Set Metin = @p1 Where Id = 1", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.ExecuteNonQuery();
            conn.baglanti().Close();
        }
    }
}