using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Categorias
    {
        public static DataTable listar_ca(string cTexto)
        {
            D_Categorias Datos = new D_Categorias();  
            return  Datos.listar_ca(cTexto);    
        }

        public static string Guardar_ca(int Opcion, E_Categorias oca)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Guardar_ca(Opcion, oca);
        }




    }
}
