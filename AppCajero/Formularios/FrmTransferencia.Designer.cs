namespace AppCajero.Formularios
{
    partial class FrmTransferencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferencia));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblCuentaDestino = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCuentaDestino = new System.Windows.Forms.TextBox();
            this.cbxCuentaOrigen = new System.Windows.Forms.ComboBox();
            this.errorDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorValor = new System.Windows.Forms.ErrorProvider(this.components);
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.errorDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(77, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cuenta origen";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(197, 227);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 35);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(51, 151);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(46, 20);
            this.LblValor.TabIndex = 14;
            this.LblValor.Text = "Valor";
            // 
            // LblCuentaDestino
            // 
            this.LblCuentaDestino.AutoSize = true;
            this.LblCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuentaDestino.Location = new System.Drawing.Point(51, 86);
            this.LblCuentaDestino.Name = "LblCuentaDestino";
            this.LblCuentaDestino.Size = new System.Drawing.Size(117, 20);
            this.LblCuentaDestino.TabIndex = 12;
            this.LblCuentaDestino.Text = "Cuenta destino";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(81, 174);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(224, 26);
            this.txtValor.TabIndex = 10;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtCuentaDestino
            // 
            this.txtCuentaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaDestino.Location = new System.Drawing.Point(55, 109);
            this.txtCuentaDestino.Name = "txtCuentaDestino";
            this.txtCuentaDestino.Size = new System.Drawing.Size(250, 26);
            this.txtCuentaDestino.TabIndex = 9;
            this.txtCuentaDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaDestino_KeyPress);
            // 
            // cbxCuentaOrigen
            // 
            this.cbxCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCuentaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCuentaOrigen.FormattingEnabled = true;
            this.cbxCuentaOrigen.Location = new System.Drawing.Point(55, 55);
            this.cbxCuentaOrigen.Name = "cbxCuentaOrigen";
            this.cbxCuentaOrigen.Size = new System.Drawing.Size(250, 28);
            this.cbxCuentaOrigen.TabIndex = 8;
            // 
            // errorDestino
            // 
            this.errorDestino.ContainerControl = this;
            // 
            // errorValor
            // 
            this.errorValor.ContainerControl = this;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection;
            // 
            // oleDbConnection
            // 
            this.oleDbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bin\\Debug\\Database." +
    "accdb";
            // 
            // oleDbDataAdapter
            // 
            this.oleDbDataAdapter.InsertCommand = this.oleDbCommand2;
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
                        new System.Data.Common.DataColumnMapping("saldo", "saldo"),
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("cuenta_origen", "cuenta_origen"),
                        new System.Data.Common.DataColumnMapping("cuenta_destino", "cuenta_destino"),
                        new System.Data.Common.DataColumnMapping("valor_transferencia", "valor_transferencia"),
                        new System.Data.Common.DataColumnMapping("fecha", "fecha")})});
            this.oleDbDataAdapter.UpdateCommand = this.oleDbCommand1;
            // 
            // FrmTransferencia
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(357, 294);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblCuentaDestino);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCuentaDestino);
            this.Controls.Add(this.cbxCuentaOrigen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransferencia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTransferencia_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label LblCuentaDestino;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCuentaDestino;
        private System.Windows.Forms.ComboBox cbxCuentaOrigen;
        private System.Windows.Forms.ErrorProvider errorDestino;
        private System.Windows.Forms.ErrorProvider errorValor;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter;
        private System.Data.OleDb.OleDbCommand oleDbCommand2;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
    }
}