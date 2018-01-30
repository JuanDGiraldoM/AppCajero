namespace AppCajero.Formularios
{
    partial class FrmNIP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNIP));
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(37, 62);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(302, 26);
            this.txtClave.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(229, 153);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 35);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(229, 198);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 35);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(229, 242);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Clientes.*, Cuentas.*\r\nFROM            (Clientes INNER JOIN\r\n      " +
    "                   Cuentas ON Clientes.cedula = Cuentas.cedula_cliente)";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection;
            // 
            // oleDbConnection
            // 
            this.oleDbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bin\\Debug\\Database." +
    "accdb";
            // 
            // oleDbDataAdapter
            // 
            this.oleDbDataAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Clientes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cedula", "cedula"),
                        new System.Data.Common.DataColumnMapping("contrasena", "contrasena"),
                        new System.Data.Common.DataColumnMapping("direccion", "direccion"),
                        new System.Data.Common.DataColumnMapping("email", "email"),
                        new System.Data.Common.DataColumnMapping("nombre", "nombre"),
                        new System.Data.Common.DataColumnMapping("telefono", "telefono"),
                        new System.Data.Common.DataColumnMapping("admin", "admin"),
                        new System.Data.Common.DataColumnMapping("bloqueado", "bloqueado"),
                        new System.Data.Common.DataColumnMapping("accesos_fallidos", "accesos_fallidos"),
                        new System.Data.Common.DataColumnMapping("numero_cuenta", "numero_cuenta"),
                        new System.Data.Common.DataColumnMapping("cedula_cliente", "cedula_cliente"),
                        new System.Data.Common.DataColumnMapping("saldo", "saldo")})});
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(373, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn1.Location = new System.Drawing.Point(52, 121);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 46);
            this.btn1.TabIndex = 24;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn1.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn2.Location = new System.Drawing.Point(105, 121);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 46);
            this.btn2.TabIndex = 25;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn2.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn0.Location = new System.Drawing.Point(105, 285);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 46);
            this.btn0.TabIndex = 33;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn0.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn0.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn6.Location = new System.Drawing.Point(158, 174);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 46);
            this.btn6.TabIndex = 29;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn6.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn9.Location = new System.Drawing.Point(158, 229);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 46);
            this.btn9.TabIndex = 32;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn9.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn3.Location = new System.Drawing.Point(158, 121);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 46);
            this.btn3.TabIndex = 26;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn3.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn8.Location = new System.Drawing.Point(105, 229);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 46);
            this.btn8.TabIndex = 31;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            this.btn8.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn8.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn4.Location = new System.Drawing.Point(52, 174);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 46);
            this.btn4.TabIndex = 27;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn4.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn7.Location = new System.Drawing.Point(52, 229);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 46);
            this.btn7.TabIndex = 30;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            this.btn7.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn7.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn5.Location = new System.Drawing.Point(105, 174);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 46);
            this.btn5.TabIndex = 28;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.MouseEnter += new System.EventHandler(this.bntMouseHover);
            this.btn5.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // FrmNIP
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(373, 371);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNIP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNIP_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
    }
}