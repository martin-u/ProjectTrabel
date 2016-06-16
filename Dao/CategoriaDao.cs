using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Dao
{
    public class CategoriaDao: Conexion
    {
        public static List<CategoriaEntidad> consultarCategoria()
        {
            List<CategoriaEntidad> listaCategoria = new List<CategoriaEntidad>();
            string query = "SELECT * FROM Categoria";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CategoriaEntidad categoria = new CategoriaEntidad();
                categoria.idCategoria = int.Parse(dr["idCategoria"].ToString());
                categoria.nombre = dr["nombre"].ToString();
                listaCategoria.Add(categoria);
            }
            dr.Close();
            cmd.Connection.Close();
            return listaCategoria;
        }

    }
}
