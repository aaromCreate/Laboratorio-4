namespace Registro
{
    partial class Reg
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Registrarbtn = new System.Windows.Forms.Button();
            this.Contraseñatxt = new System.Windows.Forms.TextBox();
            this.Confirmtxt = new System.Windows.Forms.TextBox();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.Cerrarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Usuario:";
            // 
            // Registrarbtn
            // 
            this.Registrarbtn.Location = new System.Drawing.Point(309, 261);
            this.Registrarbtn.Name = "Registrarbtn";
            this.Registrarbtn.Size = new System.Drawing.Size(162, 47);
            this.Registrarbtn.TabIndex = 15;
            this.Registrarbtn.Text = "Registrar";
            this.Registrarbtn.UseVisualStyleBackColor = true;
            this.Registrarbtn.Click += new System.EventHandler(this.Registrarbtn_Click);
            // 
            // Contraseñatxt
            // 
            this.Contraseñatxt.Location = new System.Drawing.Point(309, 135);
            this.Contraseñatxt.Name = "Contraseñatxt";
            this.Contraseñatxt.Size = new System.Drawing.Size(210, 20);
            this.Contraseñatxt.TabIndex = 20;
            // 
            // Confirmtxt
            // 
            this.Confirmtxt.Location = new System.Drawing.Point(309, 185);
            this.Confirmtxt.Name = "Confirmtxt";
            this.Confirmtxt.Size = new System.Drawing.Size(210, 20);
            this.Confirmtxt.TabIndex = 21;
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Location = new System.Drawing.Point(309, 88);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(210, 20);
            this.Usuariotxt.TabIndex = 23;
            // 
            // Cerrarbtn
            // 
            this.Cerrarbtn.Location = new System.Drawing.Point(309, 329);
            this.Cerrarbtn.Name = "Cerrarbtn";
            this.Cerrarbtn.Size = new System.Drawing.Size(162, 47);
            this.Cerrarbtn.TabIndex = 27;
            this.Cerrarbtn.Text = "Cerrar";
            this.Cerrarbtn.UseVisualStyleBackColor = true;
            this.Cerrarbtn.Click += new System.EventHandler(this.Cerrarbtn_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 409);
            this.Controls.Add(this.Cerrarbtn);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.Confirmtxt);
            this.Controls.Add(this.Contraseñatxt);
            this.Controls.Add(this.Registrarbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Reg";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Registrarbtn;
        private System.Windows.Forms.TextBox Contraseñatxt;
        private System.Windows.Forms.TextBox Confirmtxt;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Button Cerrarbtn;
    }
}

