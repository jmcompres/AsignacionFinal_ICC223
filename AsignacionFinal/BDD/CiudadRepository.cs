using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using AsignacionFinal.Modelos;

namespace AsignacionFinal.BDD
{
    public static class CiudadRepository
    {
        public static DataTable GetAll()
        {
            var dt = new DataTable();
            // Conexión a la base de datos
            using var conn = new SqlConnection(ConfigHelper.ConnectionString);
            // Consulta SQL para obtener todas las ciudades
            using var cmd = new SqlCommand("SELECT IdCiudad, NombreCiudad FROM Ciudad", conn);
            conn.Open();
            using var rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            return dt;
        }
    }
}
