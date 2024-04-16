using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class SqlBaglanti
{
    public SqlConnection baglanti()
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-174N2S2\SQLEXPRESS;Initial Catalog=yemek_tarifi;Integrated Security=True;Max Pool Size=100;Connect Timeout=60");
        baglan.Open();
        return baglan;
    }
}