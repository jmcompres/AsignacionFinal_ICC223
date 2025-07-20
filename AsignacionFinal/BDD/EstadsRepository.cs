using Microsoft.Data.SqlClient;
using AsignacionFinal.Modelos;
using System.Data;

namespace AsignacionFinal.BDD
{
    internal class EstadsRepository
    {
        public static DataTable GetAll()
        {
            var dt = new DataTable();
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT * FROM Estadistica", conn);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                dt.Load(rdr);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al cargar estadísticas: " + exc.Message);
            }

            return dt;
        }

        public static int getCantEstadJuego(string idJuego, string idEstad, string idJugador)
        {
            try
            {
                var dt = new DataTable();
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("SELECT Cantidad " +
                                               "FROM EstadJuego as ej " +
                                               "WHERE ej.IdJuego = @ij and ej.IdEstadistica = @ie and ej.IdJugador = @ijug", conn);
                cmd.Parameters.AddWithValue("@ij", idJuego);
                cmd.Parameters.AddWithValue("@ie", idEstad);
                cmd.Parameters.AddWithValue("@ijug", idJugador);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                dt.Load(rdr);

                int num;
                if (dt.Rows.Count == 0) num = 0;
                else num = Convert.ToInt32(dt.Rows[0]["Cantidad"]);
                return num;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al cargar estadísticas: " + exc.Message);
                return 0;
            }
        }

        public static bool Insert(string idJuego, string idEstad, string idJugador, int cant)
        {
            try
            {
                const string sql = "INSERT INTO EstadJuego(IdJuego, IdEstadistica, IdJugador, Cantidad) VALUES(@ij, @ie, @ijug, @c)";
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ij", idJuego);
                cmd.Parameters.AddWithValue("@ie", idEstad);
                cmd.Parameters.AddWithValue("@ijug", idJugador);
                cmd.Parameters.AddWithValue("@c", cant);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException exc)
            {
                Console.WriteLine("Error al insertar la estadística de juego: " + exc.Message);
                return false;
            }
        }

        public static bool Delete(string idJuego, string idEstad, string idJugador)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("DELETE FROM EstadJuego WHERE IdJuego = @ij and IdEstadistica = @ie and IdJugador = @ijug", conn);
                cmd.Parameters.AddWithValue("@ij", idJuego);
                cmd.Parameters.AddWithValue("@ie", idEstad);
                cmd.Parameters.AddWithValue("@ijug", idJugador);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar estadística de juego: " + ex.Message);
                return false;
            }
        }

        public static bool Update(string idJuego, string idEstad, string idJugador, int neoCant)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(
                    "UPDATE EstadJuego SET Cantidad = @c WHERE IdJuego = @ij and IdEstadistica = @ie and IdJugador = @ijug",
                    conn
                );
                cmd.Parameters.AddWithValue("@ij", idJuego);
                cmd.Parameters.AddWithValue("@ie", idEstad);
                cmd.Parameters.AddWithValue("@ijug", idJugador);
                cmd.Parameters.AddWithValue("@c", neoCant);
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
    }
}
