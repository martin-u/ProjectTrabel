using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Dao
{
    public class TipoDocumentoDao: Conexion
    {

        public static List<TipoDocumentoEntidad> consultarEntidad()
        {
            List<TipoDocumentoEntidad> listaTipoDocumento = new List<TipoDocumentoEntidad>();
            string query = "SELECT * FROM TipoDocumento";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoDocumentoEntidad tipo = new TipoDocumentoEntidad();
                tipo.idTipoDocumento = int.Parse(dr["idTipoDocumetno"].ToString());
                tipo.nombre = dr["nombre"].ToString();
                listaTipoDocumento.Add(tipo);
            }
            dr.Close();
            cmd.Connection.Close();

            return listaTipoDocumento;
        }

    }
}
