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
            string strcn = @"Data Source=fd90:671c:8820:1100:d475:44c2:9183:3252,49170;Initial Catalog=MTravel;Persist Security Info=True;User ID=sa;Password=artemisa";
            SqlConnection cnn = new SqlConnection(strcn);
            cnn.Open();
            return cnn;
        }
    }
}
