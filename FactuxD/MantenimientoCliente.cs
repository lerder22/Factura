using MiLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuxD
{
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {

        }
        public override bool Guardar()
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizaClientes {0}, '{1}', '{2}'", txtIdCli.Text.Trim(), txtNomCli.Text.Trim(), txtApCli.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado correctamente.");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha occurrido um error " + error.Message);

                    return false;

                }
            }
            else
            {
                return false;
            }
        }
        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarClientes '{0}'", txtIdCli.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado correctamente.");

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha occurrido um error: " + error.Message);



            }
        }
    }
}
