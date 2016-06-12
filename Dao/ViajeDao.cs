using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Dao
{
    public class ViajeDao: Conexion
    {

        public static void registrarViaje(ViajeEntidad viaje)
        {
            string query = "INSERT INTO Viaje(idCiudadOrigen, idCiudadDestino, fechaDesde, fechaHasta,soloIda,precioTotal,idTransporte,idTemporada) VALUES(@origen, @destino, @fDesde,@fHasta,@ida,@precio,@trans,@temp)";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            cmd.Parameters.AddWithValue(@"origen",viaje.idCiudadOrigen);
            cmd.Parameters.AddWithValue(@"destino", viaje.idCiudadDestino);
            cmd.Parameters.AddWithValue(@"fDesde", viaje.fechaDesde);
            cmd.Parameters.AddWithValue(@"fHasta", viaje.fechaHasta);
            cmd.Parameters.AddWithValue(@"ida", viaje.soloIda);
            cmd.Parameters.AddWithValue(@"precio", viaje.precioTotal);
            cmd.Parameters.AddWithValue(@"trans", viaje.idTransporte);
            cmd.Parameters.AddWithValue(@"temp", viaje.idTemporada);
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }

    }
}
