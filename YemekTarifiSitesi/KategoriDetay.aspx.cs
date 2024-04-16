using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace YemekTarifiSitesi
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        SqlBaglanti conn = new SqlBaglanti();
        string kategoriId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            kategoriId = Request.QueryString["Kategori_id"];
            SqlCommand cmd = new SqlCommand("Select * From Yemekler Where Kategori_id = @p1", conn.baglanti());
            cmd.Parameters.AddWithValue("@p1", kategoriId);
            SqlDataReader dr = cmd.ExecuteReader();
            DataList2.DataSource = dr;
            DataList2.DataBind();
            conn.baglanti().Close();
        }
    }
}