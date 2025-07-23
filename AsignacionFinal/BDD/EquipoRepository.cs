using Microsoft.Data.SqlClient;
using AsignacionFinal.Modelos;
using System.Data;

namespace AsignacionFinal.BDD
{
    public static class EquipoRepository
    {
        public static DataTable GetAll()
        {
            var dt = new DataTable();
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT eq.IdEquipo as ID, RTRIM(eq.Nombre) as Nombre, RTRIM(c.Nombre)+' ('+c.IdCiudad+')' as Ciudad " +
                                               "FROM Equipo as eq " +
                                               "JOIN Ciudad as c ON c.IdCiudad = eq.IdCiudad", conn);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                dt.Load(rdr);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al cargar equipos: " + exc.Message);
            }

            return dt;
        }

        public static bool Insert(Equipo e)
        {
            try
            {
                const string sql = "INSERT INTO Equipo(IdEquipo, Nombre, IdCiudad) VALUES(@ie, @n, @ic)";
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ie", e.idEquipo);
                cmd.Parameters.AddWithValue("@n", e.nombre);
                cmd.Parameters.AddWithValue("@ic", e.idCiudad);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al insertar equipo: " + exc.Message);
                return false;
            }
        }

        public static bool Delete(string id)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("DELETE FROM Equipo WHERE IdEquipo = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar equipo: " + ex.Message);
                return false;
            }
        }

        public static bool Update(Equipo e, string previd)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(
                    "UPDATE Equipo SET IdEquipo = @ie, Nombre = @n, IdCiudad = @ic WHERE IdEquipo = @id",
                    conn
                );
                cmd.Parameters.AddWithValue("@ie", e.idEquipo);
                cmd.Parameters.AddWithValue("@n", e.nombre);
                cmd.Parameters.AddWithValue("@ic", e.idCiudad);
                cmd.Parameters.AddWithValue("@id", previd);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static string GetIdCiudad(string idEquipo)
        {
            string idCiudad = "";
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT IdCiudad " +
                                               "FROM Equipo as eq " +
                                               "WHERE eq.IdEquipo = @ie", conn);
                cmd.Parameters.AddWithValue("@ie", idEquipo);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                if (rdr.Read()) idCiudad = rdr["IdCiudad"].ToString().Trim();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al encontrar la ciudad perteneciente al equipo: " + exc.Message);
            }

            return idCiudad;
        }

        public static bool existNumEnEquipo(string idEquipo, string num)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT '' " +
                                               "FROM Equipo as eq " +
                                               "JOIN Jugador as j ON eq.IdEquipo = j.IdEquipo " +
                                               "WHERE eq.IdEquipo = @ie " +
                                               "AND CAST(j.NumJugador AS INT) = CAST(@nj AS INT)", conn);
                cmd.Parameters.AddWithValue("@ie", idEquipo);
                cmd.Parameters.AddWithValue("@nj", num);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                return rdr.HasRows;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error: " + exc.Message);
                return false;
            }
        }
    }
}
