using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Dao
{
    public class HotelDao: Conexion
    {
        public static void registrarHotel(HotelEntidad hotel)
        {
            string query = "INSERT INTO Hotel(nombre, telefono, cuit, idTemporada, precio, idCategoria, idCiudad) VALUE(@nom, @tel, @Cuit, @temp, @pre, @categoria, @ciudad)";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            cmd.Parameters.AddWithValue(@"nom",hotel.nombre);
            cmd.Parameters.AddWithValue(@"tel", hotel.telefono);
            cmd.Parameters.AddWithValue(@"Cuit", hotel.cuit);
            cmd.Parameters.AddWithValue(@"temp", hotel.idTemporada);
            cmd.Parameters.AddWithValue(@"pre", hotel.precio);
            cmd.Parameters.AddWithValue(@"categoria", hotel.idCategoria);
            cmd.Parameters.AddWithValue(@"ciudad", hotel.idCiudad);
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }

        public static List<HotelEntidad> consultarHotel()
        {
            List<HotelEntidad> listaHotel = new List<HotelEntidad>();
            string query = "SELECT * FROM Hotel";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                HotelEntidad hotel = new HotelEntidad();
                hotel.idHotel = int.Parse(dr["idHotel"].ToString());
                hotel.cuit = int.Parse(dr["cuit"].ToString());
                hotel.idCategoria = int.Parse(dr["idCategoria"].ToString());
                hotel.idCiudad = int.Parse(dr["idCiudad"].ToString());
                hotel.idTemporada = int.Parse(dr["idTemporada"].ToString());
                hotel.nombre = dr["nombre"].ToString();
                hotel.precio = float.Parse(dr["precio"].ToString());
                hotel.telefono = int.Parse(dr["telefono"].ToString());
                listaHotel.Add(hotel);

            }
            dr.Close();
            cmd.Connection.Close();
            return listaHotel;
        }

    }
}
