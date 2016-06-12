using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Dao
{
    public class Conexion
    {
        protected static SqlConnection obtenerDB()
        {
            string strcn = @"Data Source=2001:0:9d38:6abd:855:107e:411e:dc4d,49170;Initial Catalog=MTravel;Persist Security Info=True;User ID=sa;Password=artemisa";
            SqlConnection cnn = new SqlConnection(strcn);
            cnn.Open();
            return cnn;
        }
    }
}
