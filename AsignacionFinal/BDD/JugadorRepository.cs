using System;
using System.Data;
using Microsoft.Data.SqlClient;
using AsignacionFinal.Modelos;
using System.Windows.Forms;

namespace AsignacionFinal.BDD
{
    public static class JugadorRepository
    {
        public static DataTable GetAll()
        {
            var dt = new DataTable();
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(
                    "SELECT IdJugador, IdEquipo, IdCiudadNacimiento, FechaNacimiento, NumeroJugador, NombreJugador FROM Jugador", conn);
                conn.Open();
                using var rdr = cmd.ExecuteReader();
                dt.Load(rdr);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error al cargar jugadores: " + exc.Message);
            }
            return dt;
        }

        public static bool Insert(Jugador j)
        {
            try
            {
                const string sql = @"INSERT INTO Jugador
                    (IdJugador, IdEquipo, IdCiudadNacimiento, FechaNacimiento, NumeroJugador, NombreJugador)
                    VALUES (@i, @e, @c, @f, @n, @nj)";
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@i", j.IdJugador);
                cmd.Parameters.AddWithValue("@e", j.IdEquipo);
                cmd.Parameters.AddWithValue("@c", j.IdCiudadNacimiento);
                cmd.Parameters.AddWithValue("@f", j.FechaNacimiento);
                cmd.Parameters.AddWithValue("@n", j.NumeroJugador);
                cmd.Parameters.AddWithValue("@nj", j.NombreJugador);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar jugador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Delete(string id)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand("DELETE FROM Jugador WHERE IdJugador = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update(Jugador j, string previd)
        {
            try
            {
                using var conn = new SqlConnection(ConfigHelper.ConnectionString);
                using var cmd = new SqlCommand(
                    @"UPDATE Jugador SET 
                        IdJugador = @i, 
                        IdEquipo = @e, 
                        IdCiudadNacimiento = @c, 
                        FechaNacimiento = @f, 
                        NumeroJugador = @n, 
                        NombreJugador = @nj
                      WHERE IdJugador = @id", conn);
                cmd.Parameters.AddWithValue("@i", j.IdJugador);
                cmd.Parameters.AddWithValue("@e", j.IdEquipo);
                cmd.Parameters.AddWithValue("@c", j.IdCiudadNacimiento);
                cmd.Parameters.AddWithValue("@f", j.FechaNacimiento);
                cmd.Parameters.AddWithValue("@n", j.NumeroJugador);
                cmd.Parameters.AddWithValue("@nj", j.NombreJugador);
                cmd.Parameters.AddWithValue("@id", previd);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}