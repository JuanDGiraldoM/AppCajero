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
    public partial class FrmTransferencia : Form
    {
        int tipo = 0;
        FrmMain frmMain;
        string cedula;

        public FrmTransferencia(FrmMain frmMain, string cedula, string conexion)
        {
            InitializeComponent();
            this.cedula = cedula;
            this.frmMain = frmMain;
            oleDbConnection.ConnectionString = conexion;
            Conexion();
        }

        private void FrmTransferencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Visible = true;
        }

        private void txtCuentaDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtCuentaDestino.TextLength < 11)
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = DateTime.Now.ToString();
                string cuenta_origen = cbxCuentaOrigen.SelectedItem.ToString();
                string cuenta_destino = txtCuentaDestino.Text;
                double valor_transf = double.Parse(txtValor.Text);
                double saldo_cuenta1 = 0, saldo_cuenta2 = 0;

                if (cuenta_destino == "")
                    errorDestino.SetError(txtCuentaDestino, "Ingrese la cuenta destino");
                else if (cuenta_destino.Length < 11)
                    errorDestino.SetError(txtCuentaDestino, "Cuenta destino inválida");
                else if (cuenta_destino == cuenta_origen)
                    errorDestino.SetError(txtCuentaDestino, "Ingrese otra cuenta direfente a la origen");
                else
                    errorDestino.Clear();
                if (txtValor.Text == "")
                    errorValor.SetError(txtValor, "Ingrese el valor a transferir");
                else
                    errorValor.Clear();

                if (cuenta_destino.Length == 11 && txtValor.TextLength > 0 && cuenta_origen != cuenta_destino)
                {
                    oleDbConnection.Open();
                    oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
                    oleDbDataAdapter.InsertCommand.Connection = oleDbConnection;
                    oleDbDataAdapter.UpdateCommand.Connection = oleDbConnection;

                    oleDbDataAdapter.SelectCommand.CommandText = "select * from cuentas where numero_cuenta = '" + cuenta_destino + "'";
                    OleDbDataReader cuenta = oleDbDataAdapter.SelectCommand.ExecuteReader();

                    if (cuenta.Read())
                    {
                        cuenta.Close();
                        oleDbDataAdapter.SelectCommand.CommandText = "select * from cuentas where numero_cuenta = '" + cuenta_origen + "'";
                        cuenta = oleDbDataAdapter.SelectCommand.ExecuteReader();
                        cuenta.Read();

                        saldo_cuenta1 = double.Parse(cuenta["saldo"].ToString()) - valor_transf;

                        if (saldo_cuenta1 >= 0)
                        {
                            oleDbDataAdapter.UpdateCommand.CommandText = "update cuentas set saldo = " + saldo_cuenta1 + " where numero_cuenta = '" + cuenta_origen + "'";
                            oleDbDataAdapter.UpdateCommand.ExecuteNonQuery();
                            cuenta.Close();
                            oleDbDataAdapter.SelectCommand.CommandText = "select * from cuentas where numero_cuenta = '" + cuenta_destino + "'";
                            cuenta = oleDbDataAdapter.SelectCommand.ExecuteReader();
                            cuenta.Read();
                            saldo_cuenta2 = double.Parse(cuenta["saldo"].ToString()) + valor_transf;
                            oleDbDataAdapter.UpdateCommand.CommandText = "update cuentas set saldo = " + saldo_cuenta2 + " where numero_cuenta = '" + cuenta_destino + "'";
                            oleDbDataAdapter.UpdateCommand.ExecuteNonQuery();
                            oleDbDataAdapter.InsertCommand.CommandText = "insert into transacciones (cuenta_origen, cuenta_destino, valor_transferencia, fecha) values ('" + cuenta_origen + "', '" + cuenta_destino + "', '" + valor_transf.ToString("C") + "', '" + fecha + "')";
                            oleDbDataAdapter.InsertCommand.ExecuteNonQuery();

                            MessageBox.Show("Transferencia Exitosa", "Éxito");
                            MessageBox.Show("Transacción de Transferencia\n\nCuenta origen:   " + cuenta_origen + "\tSaldo: " + saldo_cuenta1.ToString("C") + "\nCuenta destino: " + cuenta_destino + "\tSaldo: " + saldo_cuenta2.ToString("C") + "\nFecha: " + fecha, "Comprobante");
                            Limpiar();
                        }
                        else
                            errorValor.SetError(txtValor, "Cantidad no disponible\nSaldo: " + cuenta["saldo"].ToString());
                    }
                    else
                        errorDestino.SetError(txtCuentaDestino, "Cuenta destino no existente");
                }
                oleDbConnection.Close();
            }
            catch (Exception exc)
            {
                oleDbConnection.Close();
                MessageBox.Show(exc.ToString());
            }
        }

        public void Limpiar()
        {
            txtCuentaDestino.Clear();
            txtValor.Clear();
            txtCuentaDestino.Focus();
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
