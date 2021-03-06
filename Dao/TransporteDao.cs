﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Dao
{
    public class TransporteDao:Conexion
    {
        public static List<TransporteEntidad> consultarTransporte()
        {
            List<TransporteEntidad> TransporteEntidad = new List<TransporteEntidad>();
            string query = "Select * FROM Transporte";
            SqlCommand cmd = new SqlCommand(query, obtenerDB());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TransporteEntidad transporte = new TransporteEntidad();
                transporte.idTransporte = int.Parse(dr["idTransporte"].ToString());
                transporte.nombre = dr["nombre"].ToString();
                transporte.empresa = dr["empresa"].ToString();
                TransporteEntidad.Add(transporte);
            }
            dr.Close();
            cmd.Connection.Close();
            return TransporteEntidad;
        }
    }
}
