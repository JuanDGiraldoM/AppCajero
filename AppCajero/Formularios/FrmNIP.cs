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
            frmMain.acceso = true;
        }

        private void FrmNIP_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Visible = true;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            Ocultar();

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Reordenar()
        {
            numeros = new List<string>();
            for (int i = 0; i < 10; i++)
                numeros[i] = i.ToString();
            //numeros = Shuffle(numeros);
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

        
    }


}
