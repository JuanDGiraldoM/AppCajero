using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public FrmNIP(FrmMain frmMain, string cedula)
        {
            InitializeComponent();
            Reordenar();
            Mostrar();
            this.frmMain = frmMain;
            this.cedula = cedula;
            oleDbConnection.ConnectionString = Program.connection;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
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
            txtClave.Clear();
        }

        private void BtnClick(Button btn)
        {
            if(txtClave.Text.Length < 4)
                txtClave.Text += btn.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BtnClick(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            BtnClick(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            BtnClick(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            BtnClick(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            BtnClick(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            BtnClick(btn6);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            BtnClick(btn9);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            BtnClick(btn8);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            BtnClick(btn7);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            BtnClick(btn0);
        }
    }


}
