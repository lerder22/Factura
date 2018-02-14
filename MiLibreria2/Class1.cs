using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MiLibreria2;

namespace MiLibreria//Las librerias .dll nos brindan la facilidad de incluir en ellas funciones que vamos a usar muchas veces, de esta forma evitamos repetir el mismo codigo varias veces y si futuramente tenemos la necesidad de cambiar alguna de estas funciones (ejemplo la ruta de conexion al serividor SQL), solamente debemos editar dicha libreria.
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source = LEX-PC\\SQLEXPRESS; Initial Catalog = Administracion; Integrated Security = True");
            Con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);
            DP.Fill(DS);
            Con.Close();
            return DS;
        }
        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider errorProvider)
        {
            Boolean hayErrores = false;
            foreach(Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;

                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            errorProvider.SetError(Obj, "No puede estar vacio.");
                        }
                    }
                    else
                    {
                        errorProvider.SetError(Obj, "");
                    }
                }
            }
            return hayErrores;
        }
        
    }
}
