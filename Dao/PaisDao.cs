using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Dao
{
    public class PaisDao: Conexion
    {
        public static List<PaisEntidad> consultarPais()
        {
            List<PaisEntidad> listaPais = new List<PaisEntidad>();
            string query = "SELECT * FROM Pais";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PaisEntidad pais = new PaisEntidad();
                pais.idPais = int.Parse(dr["idPais"].ToString());
                pais.nombre = dr["nombre"].ToString();
                listaPais.Add(pais);
            }
            dr.Close();
            cmd.Connection.Close();
            return listaPais; 
        }
    }
}

