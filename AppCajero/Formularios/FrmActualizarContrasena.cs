using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCajero.Formularios
{
    public partial class FrmActualizarContrasena : Form
    {
        string cedula;
        FrmMain main;

        public FrmActualizarContrasena(FrmMain main, string cedula)
        {
            InitializeComponent();
            this.cedula = cedula;
            oleDbConnection.ConnectionString = Program.connection;
            this.main = main;
        }

        private void txtContrasenaNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                if (txtContrasenaNueva.Text.Length < 4)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                if ((char)Keys.Enter == e.KeyChar)
                    btnAceptar.PerformClick();
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtConfirmacionContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                if (txtConfirmacionContrasena.Text.Length < 4)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                if ((char)Keys.Enter == e.KeyChar)
                    btnAceptar.PerformClick();
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContrasenaNueva.TextLength != 4)
                errorContrasena.SetError(txtContrasenaNueva, "Contraseña inválida");
            else
                errorContrasena.Clear();
            if (txtConfirmacionContrasena.Text != txtContrasenaNueva.Text)
                errorConfirmacion.SetError(txtConfirmacionContrasena, "Las contraseñas no coinciden");
            else
                errorConfirmacion.Clear();

            if (txtContrasenaNueva.Text == txtConfirmacionContrasena.Text)
            {
                try
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        oleDbConnection.Open();
                        string clave = Utilidades.GetMd5Hash(md5Hash, txtContrasenaNueva.Text);
                        oleDbDataAdapter.UpdateCommand.CommandText = "update clientes set contrasena = '" + clave + "' where cedula = '" + cedula + "'";
                        oleDbDataAdapter.UpdateCommand.Connection = oleDbConnection;
                        oleDbDataAdapter.UpdateCommand.ExecuteNonQuery();
                        oleDbConnection.Close();

                        MessageBox.Show("Contraseña actualizada", "Éxito");
                        Close();
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                    oleDbConnection.Close();
                }
            }
        }

        private void FrmActualizarContrasena_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
