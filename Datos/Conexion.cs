﻿using System;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        // Constructor privado para evitar la creación de instancias desde fuera de la clase
        private Conexion()
        {
            this.Base = "MiBaseDatos";
            this.Servidor = "Localhost";
            this.Usuario = "root";
            this.Clave = "";
        }

        // Constructor público para inicializar las credenciales
        public Conexion(string baseDatos, string servidor, string usuario, string clave)
        {
            this.Base = baseDatos;
            this.Servidor = servidor;
            this.Usuario = usuario;
            this.Clave = clave;
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + "; User Id=" + this.Usuario + "; Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                conexion = null;
                throw ex;
            }
            return conexion;
        }

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
