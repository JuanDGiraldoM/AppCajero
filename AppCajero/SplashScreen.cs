using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCajero
{
    public partial class SplashScreen : Form
    {
        SynchronizationContext sync;

        public SplashScreen()
        {
            InitializeComponent();
            sync = SynchronizationContext.Current;
            ClientSize = BackgroundImage.Size;
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            oleDbConnection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Program.path + @"\DataBase.accdb";
            if (!File.Exists(oleDbConnection.DataSource))
            {
                MessageBox.Show(this, "No se ha encontrado la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OpenFileDialog ventana = new OpenFileDialog();
                ventana.Filter = "Data Base Files (*accdb) | *.accdb";
                ventana.Title = "Seleccionar Base de Datos";
                ventana.InitialDirectory = Program.path;

                if (ventana.ShowDialog() == DialogResult.OK && ventana.ToString() != "")
                    File.Copy(ventana.FileName, Program.path + @"\DataBase.accdb");
                else
                {
                    MessageBox.Show(this, "No se puede continuar sin Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }

        }
    }
}
