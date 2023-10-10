using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using MySql.Data.MySqlClient;
using Entidades;

namespace Datos
{
    public class D_Categorias
    {
        public DataTable listar_ca(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable MiTabla = new DataTable();
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion = Conexion.GetInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_ca", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
                conexion.Open();
                Resultado = Comando.ExecuteReader();
                MiTabla.Load(Resultado);
                return MiTabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public string Guardar_ca(int Opcion, E_Categorias oCa)
        {
            string Rpta = "";
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion = Conexion.GetInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Guardar_ca", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pOpcion", MySqlDbType.Int32).Value = Opcion;
                Comando.Parameters.Add("pCodigo_ca", MySqlDbType.Int32).Value = oCa.Codigo_ca;
                Comando.Parameters.Add("pDescripcion_ca", MySqlDbType.VarChar).Value = oCa.Descripcion_ca;
                conexion.Open();
                int filasAfectadas = Comando.ExecuteNonQuery();

                // Verificar si se insertó o actualizó correctamente
                if (filasAfectadas > 0)
                {
                    Rpta = "OK";
                }
                else
                {
                    Rpta = "No se realizó ninguna operación en la base de datos";
                }
            }
            catch (Exception ex)
            {
                Rpta = "Error: " + ex.Message; // Captura y registra el mensaje de excepción
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return Rpta;
        }


        public string Eliminar_ca(int Codigo)
        {
            string Rpta = "";
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion = Conexion.GetInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Eliminar_ca", conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("pCodigo", MySqlDbType.Int32).Value = Codigo;
                conexion.Open();
                int filasAfectadas = Comando.ExecuteNonQuery();

                // Verificar si se insertó o actualizó correctamente
                if (filasAfectadas > 0)
                {
                    Rpta = "OK";
                }
                else
                {
                    Rpta = "No se pudo eliminar el registro";
                }
            }
            catch (Exception ex)
            {
                Rpta = "Error: " + ex.Message; // Captura y registra el mensaje de excepción
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return Rpta;
        }

    }
}
