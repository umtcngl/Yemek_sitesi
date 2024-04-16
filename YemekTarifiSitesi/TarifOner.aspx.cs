using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class TarifOner : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert Into Tarifler (Tarif_ad, Tarif_malzeme, Tarif_yapilis, Tarif_resim, Tarif_sahip, Tarif_sahip_mail) Values (@t1,@t2,@t3,@t4,@t5,@t6)", conn.baglanti());
            cmd.Parameters.AddWithValue("@t1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@t2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@t3", TextBox3.Text);
            cmd.Parameters.AddWithValue("@t4", FileUpload1.FileName);
            cmd.Parameters.AddWithValue("@t5", TextBox4.Text);
            cmd.Parameters.AddWithValue("@t6", TextBox5.Text);
            cmd.ExecuteNonQuery();
            Response.Write("Tarifiniz alınmıştır.");
            conn.baglanti().Close();
        }
    }
}