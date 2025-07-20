using Microsoft.Data.SqlClient;
using AsignacionFinal.Modelos;
using System.Data;

namespace AsignacionFinal.BDD
{
    public static class JuegoRepository
    {
        public static DataTable GetAll()
        {
            var dt = new DataTable();
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT j.IdJuego as ID, j.Descripcion, eqa.Nombre as EquipoA, eqb.Nombre as EquipoB, j.Fecha_Y_Hora " +
                                               "FROM Juego as j " +
                                               "JOIN Equipo as eqa ON j.IdEquipoA = eqa.IdEquipo " +
                                               "JOIN Equipo as eqb ON j.IdEquipoB = eqb.IdEquipo", conn);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                dt.Load(rdr);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al cargar juegos: " + exc.Message);
            }

            return dt;
        }

        public static bool Insert(Juego j)
        {
            try
            {
                const string sql = "INSERT INTO Juego(IdJuego, Descripcion, IdEquipoA, IdEquipoB, Fecha_Y_Hora) VALUES(@ij, @d, @ia, @ib, @f)";
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ij", j.idJuego);
                cmd.Parameters.AddWithValue("@d", j.descripcion);
                cmd.Parameters.AddWithValue("@ia", j.idEquipoA);
                cmd.Parameters.AddWithValue("@ib", j.idEquipoB);
                cmd.Parameters.AddWithValue("@f", j.fechaYHora.ToString("yyyy-MM-dd HH:mm:ss"));
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al insertar el juego: " + exc.Message);
                return false;
            }
        }

        public static bool Delete(string id)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("DELETE FROM Juego WHERE IdJuego = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar juego: " + ex.Message);
                return false;
            }
        }

        public static bool Update(Juego j, string previd)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(
                    "UPDATE Juego SET IdJuego = @ij, Descripcion = @d, IdEquipoA = @ia, IdEquipoB = @ib, Fecha_Y_Hora = @f WHERE IdJuego = @id",
                    conn
                );
                cmd.Parameters.AddWithValue("@ij", j.idJuego);
                cmd.Parameters.AddWithValue("@d", j.descripcion);
                cmd.Parameters.AddWithValue("@ia", j.idEquipoA);
                cmd.Parameters.AddWithValue("@ib", j.idEquipoB);
                cmd.Parameters.AddWithValue("@f", j.fechaYHora.ToString("yyyy-MM-dd HH:mm:ss"));
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

        public static string GetIdEqA(string idJuego)
        {
            string idEqA = "";
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT j.IdEquipoA " +
                                               "FROM Juego as j " +
                                               "WHERE j.IdJuego = @ij", conn);
                cmd.Parameters.AddWithValue("@ij", idJuego);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                if (rdr.Read()) idEqA = rdr["IdEquipoA"].ToString().Trim();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al encontrar el equipo A del juego: " + exc.Message);
            }

            return idEqA;
        }

        public static string GetIdEqB(string idJuego)
        {
            string idEqB = "";
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT j.IdEquipoB " +
                                               "FROM Juego as j " +
                                               "WHERE j.IdJuego = @ij", conn);
                cmd.Parameters.AddWithValue("@ij", idJuego);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                if (rdr.Read()) idEqB = rdr["IdEquipoB"].ToString().Trim();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al encontrar el equipo B del juego: " + exc.Message);
            }

            return idEqB;
        }

        public static bool existEquipoEstad(string idJuego, string idEquipo)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT '' " +
                                               "FROM EstadJuego as ej " +
                                               "JOIN Jugador as j ON ej.IdJugador = j.IdJugador " +
                                               "WHERE ej.IdJuego = @ij " +
                                               "AND j.IdEquipo = @ie", conn);
                cmd.Parameters.AddWithValue("@ij", idJuego);
                cmd.Parameters.AddWithValue("@ie", idEquipo);
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
