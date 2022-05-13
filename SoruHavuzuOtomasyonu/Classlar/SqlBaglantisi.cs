using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SoruHavuzuOtomasyonu.Classlar
{
    public class SqlBaglantisi
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BUB2ROC;Initial Catalog=SinavProjesi;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }

    }
}
