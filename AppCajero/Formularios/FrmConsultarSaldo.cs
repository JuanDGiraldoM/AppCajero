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
    public partial class FrmConsultarSaldo : Form
    {
        FrmMain frmMain;
        string cedula;

        public FrmConsultarSaldo(FrmMain frmMain, string cedula)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            this.cedula = cedula;
            oleDbConnection.ConnectionString = Program.connection;
            Conexion();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = DateTime.Now.ToString();
                string num_cuenta = cbxCuentaOrigen.SelectedItem.ToString();
                double saldo_cuenta;

                oleDbConnection.Open();
                oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
                oleDbDataAdapter.SelectCommand.CommandText = "select * from cuentas where numero_cuenta = '" + num_cuenta + "'";
                OleDbDataReader cuenta = oleDbDataAdapter.SelectCommand.ExecuteReader();

                if (cuenta.Read())
                {
                    saldo_cuenta = double.Parse(cuenta["saldo"].ToString());
                    MessageBox.Show("Transacción Consulta de Saldo\n\nCuenta :   " + num_cuenta + "\tSaldo: " + saldo_cuenta.ToString("C") + "\nFecha: " + fecha, "Comprobante");
                    oleDbConnection.Close();
                    Close();

                }
                else
                    MessageBox.Show("Ha ocurrido un error con la cuenta");

                oleDbConnection.Close();
            }
            catch (Exception exc)
            {
                oleDbConnection.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmConsultarSaldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Visible = true;
        }

        public void Conexion()
        {
            try
            {
                oleDbConnection.Open();
                oleDbDataAdapter.SelectCommand.CommandText = "select * from cuentas where cedula_cliente = '" + cedula + "'";
                oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
                OleDbDataReader cuenta = oleDbDataAdapter.SelectCommand.ExecuteReader();

                while (cuenta.Read())
                {
                    cbxCuentaOrigen.Items.Add(cuenta["numero_cuenta"].ToString());
                }

                if (cbxCuentaOrigen.Items.Count == 0)
                {
                    MessageBox.Show("No hay cuentas vinculadas");
                    Close();
                }
                else
                    cbxCuentaOrigen.SelectedIndex = 0;
                oleDbConnection.Close();
            }
            catch (Exception exc)
            {
                oleDbConnection.Close();
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
