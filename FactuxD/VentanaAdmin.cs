using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiLibreria;

namespace FactuxD
{
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin() => InitializeComponent();


        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where id_usuario = " + VentanaLogin.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            lblAdAdmin.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
            lblUsAdmin.Text = DS.Tables[0].Rows[0]["account"].ToString().Trim();
            lblCodigoAdmin.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString().Trim();
            pictureBox1.Image = Image.FromFile(url);
        }
        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal ConP = new ContenedorPrincipal();
            this.Hide();
            ConP.Show();
        }
    }
}
