using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using MiLibreria;


namespace FactuxD
{
    public partial class VentanaLogin : System.Windows.Forms.Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static string Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * from Usuarios where account = '{0}' and password = '{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());//Trim hace que si hay un espacio en la cadena lo junta todo como una unica cadena.
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();


                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())//Si el usuario coloco correctamente el nombre de cuenta y la contrasenia debemos entrar a la cuenta.
                {
                    if(Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]))
                    {
                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();
                        VenAd.Show();
                    }
                    else
                    {
                        VentanaUser VenUs = new VentanaUser();
                        this.Hide();
                        VenUs.Show();
                    }
                    
                }
                
            }
            catch //(Exception error)
            {
                MessageBox.Show("Usuario o contrasena incorrecta");
               
            }
            
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
