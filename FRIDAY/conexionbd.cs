using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace FRIDAY
{
    class conexionbd
    {
         
            NpgsqlConnection conexion = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = KEVIN2001; Database = Dulces");
            void constructor()
            {
                    try
                    {
                        conexion.Open();
                    }
                    catch(Exception  e)
                    {
                MessageBox.Show(e.Message, "Error en la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);        
                    }
            }
            void manualC()
            {
                try
                {
                    conexion.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error en la conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            void cerrar()
            {
                    conexion.Close();
            }
             public NpgsqlDataAdapter comando(String comand)
             {
                NpgsqlDataAdapter lector = null;
                try
                {
                    NpgsqlCommand comando_sql = new NpgsqlCommand();
                    lector = new NpgsqlDataAdapter(comand, conexion);
                    
                }
                catch (Exception e)
            {
                MessageBox.Show(e.Message, "Pedo con el el adapter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                return lector;
        }
    }
}
