namespace AppCajero.Formularios
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnActualizarContrasena = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnConsultarSaldo = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.Color.Transparent;
            this.btnRetiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetiro.ForeColor = System.Drawing.Color.White;
            this.btnRetiro.Image = global::AppCajero.Properties.Resources.arrow_right;
            this.btnRetiro.Location = new System.Drawing.Point(20, 120);
            this.btnRetiro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(405, 95);
            this.btnRetiro.TabIndex = 1;
            this.btnRetiro.Text = "Retirar Efectivo";
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnActualizarContrasena
            // 
            this.btnActualizarContrasena.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarContrasena.ForeColor = System.Drawing.Color.White;
            this.btnActualizarContrasena.Image = global::AppCajero.Properties.Resources.arrow_left;
            this.btnActualizarContrasena.Location = new System.Drawing.Point(670, 320);
            this.btnActualizarContrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarContrasena.Name = "btnActualizarContrasena";
            this.btnActualizarContrasena.Size = new System.Drawing.Size(405, 95);
            this.btnActualizarContrasena.TabIndex = 2;
            this.btnActualizarContrasena.Text = "Actualizar Contraseña";
            this.btnActualizarContrasena.UseVisualStyleBackColor = false;
            this.btnActualizarContrasena.Click += new System.EventHandler(this.btnActualizarContrasena_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        cedula, nombre\r\nFROM            Clientes";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bin\\Debug\\Database." +
    "accdb";
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `Clientes` SET `cedula` = ?, `nombre` = ? WHERE ((`cedula` = ?) AND ((? = " +
    "1 AND `nombre` IS NULL) OR (`nombre` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("cedula", System.Data.OleDb.OleDbType.VarWChar, 0, "cedula"),
            new System.Data.OleDb.OleDbParameter("nombre", System.Data.OleDb.OleDbType.VarWChar, 0, "nombre"),
            new System.Data.OleDb.OleDbParameter("Original_cedula", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cedula", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nombre", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `Clientes` WHERE ((`cedula` = ?) AND ((? = 1 AND `nombre` IS NULL) OR" +
    " (`nombre` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_cedula", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cedula", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nombre", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nombre", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nombre", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nombre", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Clientes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cedula", "cedula"),
                        new System.Data.Common.DataColumnMapping("nombre", "nombre")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.BackColor = System.Drawing.Color.Transparent;
            this.btnTransferencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnTransferencia.Image = global::AppCajero.Properties.Resources.arrow_right;
            this.btnTransferencia.Location = new System.Drawing.Point(20, 320);
            this.btnTransferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(405, 95);
            this.btnTransferencia.TabIndex = 5;
            this.btnTransferencia.Text = "Realizar Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = false;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnConsultarSaldo
            // 
            this.btnConsultarSaldo.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarSaldo.ForeColor = System.Drawing.Color.White;
            this.btnConsultarSaldo.Image = global::AppCajero.Properties.Resources.arrow_left;
            this.btnConsultarSaldo.Location = new System.Drawing.Point(670, 120);
            this.btnConsultarSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultarSaldo.Name = "btnConsultarSaldo";
            this.btnConsultarSaldo.Size = new System.Drawing.Size(405, 95);
            this.btnConsultarSaldo.TabIndex = 0;
            this.btnConsultarSaldo.Text = "Consultar Saldo";
            this.btnConsultarSaldo.UseVisualStyleBackColor = false;
            this.btnConsultarSaldo.Click += new System.EventHandler(this.btnConsultarSaldo_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Name";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AppCajero.Properties.Resources.dinero_back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnActualizarContrasena);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnConsultarSaldo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppCajero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarSaldo;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnActualizarContrasena;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.Button btnTransferencia;
        private System.Windows.Forms.Label lblNombre;
    }
}