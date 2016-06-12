using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Entidades;

namespace Dao
{
    public class CiudadDao : Conexion
    {
        public static List<CiudadEntidad> consultarCiudad()
        {
            List<CiudadEntidad> listaCiudad = new List<CiudadEntidad>();
            string query = "Select * FROM Ciudad";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CiudadEntidad ciudad = new CiudadEntidad();
                ciudad.idCiudad = int.Parse(dr["idCiudad"].ToString());
                ciudad.nombre = dr["nombre"].ToString();
                ciudad.idPais = int.Parse(dr["idPais"].ToString());
                listaCiudad.Add(ciudad);
            }
            dr.Close();
            cmd.Connection.Close();
            return listaCiudad;
        }
    }
}
