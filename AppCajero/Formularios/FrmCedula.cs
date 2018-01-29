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
    public partial class FrmCedula : Form
    {

        string cedula;

        public FrmCedula()
        {
            InitializeComponent();
            oleDbConnection1.ConnectionString = Program.connection;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                if (txtCedula.Text.Length < 10)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                if ((char)Keys.Enter == e.KeyChar)
                    btnOk.PerformClick();
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public void LimpiarCampos()
        {
            txtCedula.Clear();
        }

        public void LimpiarErrores()
        {
            errorCedula.Clear();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            if(txtCedula.TextLength >= 8)
            {
                errorCedula.Clear();
            }
        }

        private void FrmCedula_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            cedula = txtCedula.Text;

            if (cedula.Length == 0)
                errorCedula.SetError(txtCedula, "Ingrese su número de Cédula");
            else
                errorCedula.Clear();

            if(cedula.Length >= 8)
            {
                errorCedula.Clear();
                oleDbConnection1.Open();
                oleDbDataAdapter1.SelectCommand.CommandText = "select cedula from Clientes where cedula='" + cedula + "'";
                oleDbDataAdapter1.SelectCommand.Connection = oleDbConnection1;
                OleDbDataReader id = oleDbDataAdapter1.SelectCommand.ExecuteReader();

                if (id.Read())
                {
                    oleDbConnection1.Close();
                    new FrmMain(cedula).Show();
                    Hide();
                }
                else{
                    errorCedula.SetError(txtCedula, "Cédula no registrada");
                }
                oleDbConnection1.Close();
            }
            else
            {
                if (cedula.Length < 8)
                    errorCedula.SetError(txtCedula, "Cédula inválida");
                else
                    errorCedula.Clear();
            }
        }
    }
}
