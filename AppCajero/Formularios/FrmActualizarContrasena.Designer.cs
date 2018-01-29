namespace AppCajero.Formularios
{
    partial class FrmActualizarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarContrasena));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.LblConfirmacionContraseña = new System.Windows.Forms.Label();
            this.LblContraseñaNueva = new System.Windows.Forms.Label();
            this.txtConfirmacionContrasena = new System.Windows.Forms.TextBox();
            this.txtContrasenaNueva = new System.Windows.Forms.TextBox();
            this.errorContrasena = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorConfirmacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection = new System.Data.OleDb.OleDbConnection();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(72, 191);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 35);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // LblConfirmacionContraseña
            // 
            this.LblConfirmacionContraseña.AutoSize = true;
            this.LblConfirmacionContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmacionContraseña.Location = new System.Drawing.Point(33, 110);
            this.LblConfirmacionContraseña.Name = "LblConfirmacionContraseña";
            this.LblConfirmacionContraseña.Size = new System.Drawing.Size(162, 20);
            this.LblConfirmacionContraseña.TabIndex = 8;
            this.LblConfirmacionContraseña.Text = "Confirmar contraseña";
            // 
            // LblContraseñaNueva
            // 
            this.LblContraseñaNueva.AutoSize = true;
            this.LblContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseñaNueva.Location = new System.Drawing.Point(45, 38);
            this.LblContraseñaNueva.Name = "LblContraseñaNueva";
            this.LblContraseñaNueva.Size = new System.Drawing.Size(139, 20);
            this.LblContraseñaNueva.TabIndex = 7;
            this.LblContraseñaNueva.Text = "Contraseña nueva";
            // 
            // txtConfirmacionContrasena
            // 
            this.txtConfirmacionContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacionContrasena.Location = new System.Drawing.Point(61, 133);
            this.txtConfirmacionContrasena.Name = "txtConfirmacionContrasena";
            this.txtConfirmacionContrasena.PasswordChar = '*';
            this.txtConfirmacionContrasena.Size = new System.Drawing.Size(106, 26);
            this.txtConfirmacionContrasena.TabIndex = 6;
            this.txtConfirmacionContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrasenaNueva
            // 
            this.txtContrasenaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaNueva.Location = new System.Drawing.Point(61, 61);
            this.txtContrasenaNueva.Name = "txtContrasenaNueva";
            this.txtContrasenaNueva.PasswordChar = '*';
            this.txtContrasenaNueva.Size = new System.Drawing.Size(106, 26);
            this.txtContrasenaNueva.TabIndex = 5;
            this.txtContrasenaNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorContrasena
            // 
            this.errorContrasena.ContainerControl = this;
            // 
            // errorConfirmacion
            // 
            this.errorConfirmacion.ContainerControl = this;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        cedula, contrasena\r\nFROM            Clientes";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection;
            // 
            // oleDbConnection
            // 
            this.oleDbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bin\\Debug\\Database." +
    "accdb";
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `Clientes` SET `cedula` = ?, `contrasena` = ? WHERE ((`cedula` = ?) AND ((" +
    "? = 1 AND `contrasena` IS NULL) OR (`contrasena` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("cedula", System.Data.OleDb.OleDbType.VarWChar, 0, "cedula"),
            new System.Data.OleDb.OleDbParameter("contrasena", System.Data.OleDb.OleDbType.VarWChar, 0, "contrasena"),
            new System.Data.OleDb.OleDbParameter("Original_cedula", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cedula", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_contrasena", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "contrasena", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_contrasena", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "contrasena", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `Clientes` WHERE ((`cedula` = ?) AND ((? = 1 AND `contrasena` IS NULL" +
    ") OR (`contrasena` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_cedula", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cedula", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_contrasena", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "contrasena", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_contrasena", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "contrasena", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter
            // 
            this.oleDbDataAdapter.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Clientes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cedula", "cedula"),
                        new System.Data.Common.DataColumnMapping("contrasena", "contrasena")})});
            this.oleDbDataAdapter.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // FrmActualizarContrasena
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 265);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.LblConfirmacionContraseña);
            this.Controls.Add(this.LblContraseñaNueva);
            this.Controls.Add(this.txtConfirmacionContrasena);
            this.Controls.Add(this.txtContrasenaNueva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmActualizarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Contraseña";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmActualizarContrasena_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label LblConfirmacionContraseña;
        private System.Windows.Forms.Label LblContraseñaNueva;
        private System.Windows.Forms.TextBox txtConfirmacionContrasena;
        private System.Windows.Forms.TextBox txtContrasenaNueva;
        private System.Windows.Forms.ErrorProvider errorContrasena;
        private System.Windows.Forms.ErrorProvider errorConfirmacion;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter;
    }
}