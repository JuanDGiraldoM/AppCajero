﻿using System;
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
        public FrmNIP()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Hide();
        }
    }
}