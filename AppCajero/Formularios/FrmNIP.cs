using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCajero.Formularios
{
    public partial class FrmNIP : Form
    {
        FrmMain frmMain;
        string cedula;
        List<string> numeros;
        int clave;

        public FrmNIP(FrmMain frmMain, string cedula, int clave)
        {
            InitializeComponent();
            Reordenar();
            Mostrar();
            this.frmMain = frmMain;
            this.cedula = cedula;
            this.clave = clave;
            oleDbConnection.ConnectionString = Program.connection;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string clave = txtContrasena.Text;

            if (clave == "")
                errorContrasena.SetError(txtContrasena, "Ingrese la contraseña");
            else
                errorContrasena.Clear();

            if (clave.Length == 4)
            {
                using (MD5 md5hash = MD5.Create())
                {
                    string clave_hash = Utilidades.GetMd5Hash(md5hash, clave);

                    oleDbConnection.Open();
                    oleDbDataAdapter.SelectCommand.CommandText = "select * from Clientes where cedula = '" + cedula + "'";
                    oleDbDataAdapter.SelectCommand.Connection = oleDbConnection;
                    OleDbDataReader usuario = oleDbDataAdapter.SelectCommand.ExecuteReader();

                    usuario.Read();

                    if (usuario["bloqueado"].ToString() == "False")
                    {
                        string clave_consulta = this.clave==2? "seg_clave" : "contrasena";

                        if (usuario[clave_consulta].ToString() == clave_hash)
                        {
                            try
                            {
                                oleDbDataAdapter.UpdateCommand.CommandText = "update clientes set accesos_fallidos = 0 where cedula = '" + cedula + "'";
                                oleDbDataAdapter.UpdateCommand.Connection = oleDbConnection;
                                oleDbDataAdapter.UpdateCommand.ExecuteNonQuery();
                            }
                            catch (OleDbException exp)
                            {
                                oleDbConnection.Close();
                                MessageBox.Show(exp.ToString());
                            }

                            DialogResult = DialogResult.OK;
                            Close();

                        }
                        else
                        {
                            errorContrasena.SetError(txtContrasena, "Contraseña Incorrecta");
                            txtContrasena.Clear();
                            int accesos_fallidos = int.Parse(usuario["accesos_fallidos"].ToString());
                            if (accesos_fallidos < 3)
                            {
                                accesos_fallidos++;
                                try
                                {
                                    oleDbDataAdapter.UpdateCommand.CommandText = "update clientes set accesos_fallidos = " + accesos_fallidos + " where cedula = '" + cedula + "'";
                                    oleDbDataAdapter.UpdateCommand.Connection = oleDbConnection;
                                    oleDbDataAdapter.UpdateCommand.ExecuteNonQuery();
                                }
                                catch (OleDbException exp)
                                {
                                    oleDbConnection.Close();
                                    MessageBox.Show(exp.ToString());
                                }
                            }
                            else
                            {
                                try
                                {
                                    oleDbDataAdapter.UpdateCommand.CommandText = "update clientes set bloqueado = 1 where cedula = '" + cedula + "'";
                                    oleDbDataAdapter.UpdateCommand.Connection = oleDbConnection;
                                    oleDbDataAdapter.UpdateCommand.ExecuteNonQuery();
                                    MessageBox.Show("Contraseña bloqueada\nHa excedido la cantidad de intentos", "Bloqueo Preventivo");
                                    Close();
                                }
                                catch (OleDbException exp)
                                {
                                    oleDbConnection.Close();
                                    MessageBox.Show(exp.ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña bloqueada", "Error");
                        Close();
                    }
                    oleDbConnection.Close();
                }
            }
        }

        private void FrmNIP_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Visible = true;
        }

        private void bntMouseHover(object sender, EventArgs e)
        {
            Ocultar();
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Reordenar()
        {
            numeros = new List<string>();
            for (int i = 0; i < 10; i++)
                numeros.Add(i.ToString());
            numeros = Utilidades.Shuffle(numeros);
        }

        private void Ocultar()
        {
            btn0.Text = "*";
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
        }

        private void Mostrar()
        {
            btn0.Text = numeros[0];
            btn1.Text = numeros[1];
            btn2.Text = numeros[2];
            btn3.Text = numeros[3];
            btn4.Text = numeros[4];
            btn5.Text = numeros[5];
            btn6.Text = numeros[6];
            btn7.Text = numeros[7];
            btn8.Text = numeros[8];
            btn9.Text = numeros[9];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtContrasena.Clear();
        }

        private void BtnClick(string value)
        {
            if (txtContrasena.Text.Length < 4)
                txtContrasena.Text += value;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[1]);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[2]);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[3]);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[4]);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[5]);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[6]);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[9]);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[8]);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[7]);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            BtnClick(numeros[0]);
        }
    }
}
