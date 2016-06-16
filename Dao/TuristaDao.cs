using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Dao
{
    public class TuristaDao: Conexion
    {
        public static List<TuristaEntidad> consultarTurista()
        {
            
            List<TuristaEntidad> listaTurista = new List<TuristaEntidad>();
            string query = "SELECT * FROM Turista";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TuristaEntidad turista = new TuristaEntidad();
                turista.idTipoDocumento = int.Parse(dr["idTipoDocumento"].ToString());
                turista.DNI = int.Parse(dr["DNI"].ToString());
                turista.nombre = dr["nombre"].ToString();
                turista.apellido = dr["apellido"].ToString();
                turista.telefono = int.Parse(dr["telefono"].ToString());
                turista.email = dr["email"].ToString();
                turista.fechaNacimiento = DateTime.Parse(dr["fechaNacimiento"].ToString());
                
                listaTurista.Add(turista);
            }
            dr.Close();
            cmd.Connection.Close();

            return listaTurista;
        
    }

        public static void registrarTurista(TuristaEntidad turista)
        {
            string query = "INSERT INTO Turista(DNI, idTipoDocumento,nombre,apellido,telefono,email,fechaNacimiento) VALUES (@dni,@tipo,@nom,@ape,@tel,@mail,@fecNac)";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());

            cmd.Parameters.AddWithValue(@"dni",turista.DNI);
            cmd.Parameters.AddWithValue(@"tipo", turista.idTipoDocumento);
            cmd.Parameters.AddWithValue(@"nom", turista.nombre);
            cmd.Parameters.AddWithValue(@"ape", turista.apellido);
            cmd.Parameters.AddWithValue(@"tel", turista.telefono);
            cmd.Parameters.AddWithValue(@"mail", turista.email);
            cmd.Parameters.AddWithValue(@"fecNac", turista.fechaNacimiento);


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


        public static List<TuristaEntidad> consultarTuristaXDNI(int dni)
        {

            List<TuristaEntidad> listaTurista = new List<TuristaEntidad>();
            string query = "SELECT * FROM Turista WHERE DNI = @dni";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            cmd.Parameters.AddWithValue(@"dni", dni);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TuristaEntidad turista = new TuristaEntidad();
                turista.idTipoDocumento = int.Parse(dr["idTipoDocumento"].ToString());
                turista.DNI = int.Parse(dr["DNI"].ToString());
                turista.nombre = dr["nombre"].ToString();
                turista.apellido = dr["apellido"].ToString();
                turista.telefono = int.Parse(dr["telefono"].ToString());
                turista.email = dr["email"].ToString();
                turista.fechaNacimiento = DateTime.Parse(dr["fechaNacimiento"].ToString());

                listaTurista.Add(turista);
            }
            dr.Close();
            cmd.Connection.Close();

            return listaTurista;

        }
    }
}
