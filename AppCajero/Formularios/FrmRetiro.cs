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
    public partial class FrmRetiro : Form
    {
        FrmMain frmMain;
        string cedula;

        public FrmRetiro(FrmMain frmMain, string cedula)
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
                string cuenta_retiro = cbxCuentaOrigen.SelectedItem.ToString();
                double valor_retiro = double.Parse(txtValor.Text);
                double saldo_cuenta;

                if (txtValor.Text == "")
                    errorValor.SetError(txtValor, "Ingrese el valor a transferir");
                else
                    errorValor.Clear();

                if (txtValor.TextLength > 0)
                {
                    oleDbConnection.Open();
                    oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
                    oleDbDataAdapter.InsertCommand.Connection = oleDbConnection;
                    oleDbDataAdapter.UpdateCommand.Connection = oleDbConnection;

                    oleDbDataAdapter.SelectCommand.CommandText = "select * from cuentas where numero_cuenta = '" + cuenta_retiro + "'";
                    OleDbDataReader cuenta = oleDbDataAdapter.SelectCommand.ExecuteReader();

                    if (cuenta.Read())
                    {
                        saldo_cuenta = double.Parse(cuenta["saldo"].ToString()) - valor_retiro;

                        if (saldo_cuenta >= 0)
                        {
                            oleDbDataAdapter.UpdateCommand.CommandText = "update cuentas set saldo = " + saldo_cuenta + " where numero_cuenta = '" + cuenta_retiro + "'";
                            oleDbDataAdapter.UpdateCommand.ExecuteNonQuery();
                            oleDbDataAdapter.InsertCommand.CommandText = "insert into retiros (cuenta_retiro, valor_retiro, fecha) values ('" + cuenta_retiro + "', '" + valor_retiro + "', '" + fecha + "')";
                            oleDbDataAdapter.InsertCommand.ExecuteNonQuery();

                            MessageBox.Show("Retiro Exitoso", "Éxito");
                            MessageBox.Show("Transacción de Retiro\n\nCuenta :   " + cuenta_retiro + "\tSaldo: " + saldo_cuenta.ToString("C") + "\nFecha: " + fecha, "Comprobante");
                            Close();
                        }
                        else
                            errorValor.SetError(txtValor, "Cantidad no disponible\nSaldo: " + cuenta["saldo"].ToString());
                    }
                    else
                        Console.WriteLine("Ha ocurrido un error con la cuenta");
                }
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtValor.TextLength < 14)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnAceptar.PerformClick();
                if (e.KeyChar == (char)Keys.Escape)
                    btnCancelar.PerformClick();

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public void Limpiar()
        {
            txtValor.Clear();
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

        private void FrmRetiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Visible = true;
        }
    }
}
