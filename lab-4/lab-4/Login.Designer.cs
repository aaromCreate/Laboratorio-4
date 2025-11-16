namespace lab4
{
    partial class Login
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Label_Contraseña = new System.Windows.Forms.Label();
            this.Label_Usuario = new System.Windows.Forms.Label();
            this.Label_TituloLogin = new System.Windows.Forms.Label();
            this.lblregistrar = new System.Windows.Forms.Label();
            this.Label_InfoProfe = new System.Windows.Forms.Label();
            this.Label_InicioSesion = new System.Windows.Forms.Label();
            this.pictureBox_FondoLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FondoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(593, 311);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(159, 48);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(580, 224);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(187, 30);
            this.txtContraseña.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(580, 160);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(187, 30);
            this.txtUsuario.TabIndex = 9;
            // 
            // Label_Contraseña
            // 
            this.Label_Contraseña.AutoSize = true;
            this.Label_Contraseña.BackColor = System.Drawing.Color.AliceBlue;
            this.Label_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Contraseña.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Contraseña.Location = new System.Drawing.Point(459, 227);
            this.Label_Contraseña.Name = "Label_Contraseña";
            this.Label_Contraseña.Size = new System.Drawing.Size(113, 25);
            this.Label_Contraseña.TabIndex = 8;
            this.Label_Contraseña.Text = "Contraseña:";
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.BackColor = System.Drawing.Color.AliceBlue;
            this.Label_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Usuario.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.Location = new System.Drawing.Point(487, 163);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(85, 25);
            this.Label_Usuario.TabIndex = 7;
            this.Label_Usuario.Text = "Usuario:";
            // 
            // Label_TituloLogin
            // 
            this.Label_TituloLogin.AutoSize = true;
            this.Label_TituloLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.Label_TituloLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_TituloLogin.Font = new System.Drawing.Font("Book Antiqua", 26F, System.Drawing.FontStyle.Bold);
            this.Label_TituloLogin.Location = new System.Drawing.Point(500, 20);
            this.Label_TituloLogin.Name = "Label_TituloLogin";
            this.Label_TituloLogin.Size = new System.Drawing.Size(254, 45);
            this.Label_TituloLogin.TabIndex = 6;
            this.Label_TituloLogin.Text = "Farmacia Pana";
            // 
            // lblregistrar
            // 
            this.lblregistrar.AutoSize = true;
            this.lblregistrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblregistrar.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrar.ForeColor = System.Drawing.Color.Blue;
            this.lblregistrar.Location = new System.Drawing.Point(461, 279);
            this.lblregistrar.Name = "lblregistrar";
            this.lblregistrar.Size = new System.Drawing.Size(111, 22);
            this.lblregistrar.TabIndex = 12;
            this.lblregistrar.Text = "Crear Usuario";
            this.lblregistrar.Click += new System.EventHandler(this.lblregistrar_Click);
            // 
            // Label_InfoProfe
            // 
            this.Label_InfoProfe.AutoSize = true;
            this.Label_InfoProfe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_InfoProfe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InfoProfe.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Label_InfoProfe.Location = new System.Drawing.Point(419, 376);
            this.Label_InfoProfe.Name = "Label_InfoProfe";
            this.Label_InfoProfe.Size = new System.Drawing.Size(153, 54);
            this.Label_InfoProfe.TabIndex = 13;
            this.Label_InfoProfe.Text = "Mensaje para el profesor:\r\nUsuario:     contraseña:\r\nadmin         123\r\ncliente  " +
    "       123";
            // 
            // Label_InicioSesion
            // 
            this.Label_InicioSesion.AutoSize = true;
            this.Label_InicioSesion.BackColor = System.Drawing.Color.AliceBlue;
            this.Label_InicioSesion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_InicioSesion.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.Label_InicioSesion.Location = new System.Drawing.Point(534, 96);
            this.Label_InicioSesion.Name = "Label_InicioSesion";
            this.Label_InicioSesion.Size = new System.Drawing.Size(191, 30);
            this.Label_InicioSesion.TabIndex = 15;
            this.Label_InicioSesion.Text = "Inicio de Sesión";
            // 
            // pictureBox_FondoLogin
            // 
            this.pictureBox_FondoLogin.Image = global::lab_4.Properties.Resources.Fondo_Login;
            this.pictureBox_FondoLogin.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox_FondoLogin.Name = "pictureBox_FondoLogin";
            this.pictureBox_FondoLogin.Size = new System.Drawing.Size(806, 451);
            this.pictureBox_FondoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FondoLogin.TabIndex = 14;
            this.pictureBox_FondoLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_InicioSesion);
            this.Controls.Add(this.Label_InfoProfe);
            this.Controls.Add(this.lblregistrar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Label_Contraseña);
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.Label_TituloLogin);
            this.Controls.Add(this.pictureBox_FondoLogin);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FondoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label Label_Contraseña;
        private System.Windows.Forms.Label Label_Usuario;
        private System.Windows.Forms.Label Label_TituloLogin;
        private System.Windows.Forms.Label lblregistrar;
        private System.Windows.Forms.Label Label_InfoProfe;
        private System.Windows.Forms.PictureBox pictureBox_FondoLogin;
        private System.Windows.Forms.Label Label_InicioSesion;
    }
}