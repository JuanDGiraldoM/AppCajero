using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCajero.Formularios
{
    public partial class FrmMain : Form
    {
        string cedula;

        public FrmMain(string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            oleDbConnection1.ConnectionString = Program.connection;
            oleDbConnection1.Open();
            oleDbDataAdapter1.SelectCommand.CommandText = "select nombre from Clientes where cedula = '" + cedula + "'";
            oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
            OleDbDataReader usuario = oleDbDataAdapter1.SelectCommand.ExecuteReader();

            if (usuario.Read())
            {
                lblNombre.Text = usuario["nombre"].ToString();
            }
            else
            {
                Console.WriteLine("Ha ocurrido un error con la cédula");
            }
            oleDbConnection1.Close();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarContrasena_Click(object sender, EventArgs e)
        {
            new FrmActualizarContrasena(this, cedula).Show();
            SetVisibleCore(false);
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            new FrmTransferencia(this, cedula).Show();
            SetVisibleCore(false);
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            new FrmRetiro(this, cedula).Show();
            SetVisibleCore(false);
        }
    }
}
