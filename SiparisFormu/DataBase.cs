using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace SiparisFormu
{
    public class DataBase
    {
        public SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-FGPFH37;Initial Catalog=StokTakip;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
