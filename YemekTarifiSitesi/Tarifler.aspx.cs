using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class Tarifler : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel4.Visible = false;
            SqlCommand cmd = new SqlCommand("Select * From Tarifler Where Tarif_durum = 1", conn.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            SqlCommand cmd2 = new SqlCommand("Select * From Tarifler Where Tarif_durum = 0", conn.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
            DataList2.DataSource = dr2;
            DataList2.DataBind();
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