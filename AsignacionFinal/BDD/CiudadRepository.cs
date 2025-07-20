using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using AsignacionFinal.Modelos;
using System.Linq.Expressions;

namespace AsignacionFinal.BDD
{
    public static class CiudadRepository
    {
        public static DataTable GetAll()
        {
            var dt = new DataTable();
            // Conexión a la base de datos
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                // Consulta SQL para obtener todas las ciudades
                using var cmd = new SqlCommand("SELECT IdCiudad, Nombre FROM Ciudad", conn);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                dt.Load(rdr);
            }
            catch(Exception exc){
                Console.WriteLine("Error al cargar clientes: " + exc.Message);
            }

            return dt;
        }

        public static bool Insert(Ciudad c)
        {
            try
            {
                const string sql = "INSERT INTO Ciudad(IdCiudad, Nombre) VALUES(@i, @n)";
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@i", c.idCiudad);
                cmd.Parameters.AddWithValue("@n", c.nombre);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception exc)
            {
                return false;
            }
        }

        public static bool Delete(string id)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("DELETE FROM Ciudad WHERE IdCiudad = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Update(Ciudad c, string previd)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(
                    "UPDATE Ciudad SET IdCiudad = @i, Nombre = @n WHERE IdCiudad = @id",
                    conn
                );
                cmd.Parameters.AddWithValue("@i", c.idCiudad);
                cmd.Parameters.AddWithValue("@n", c.nombre);
                cmd.Parameters.AddWithValue("@id", previd);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }

}
