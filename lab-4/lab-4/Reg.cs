using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Text.RegularExpressions;
using lab4;

namespace Registro
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();

          
            Contraseñatxt.UseSystemPasswordChar = true;
            Confirmtxt.UseSystemPasswordChar = true;
        }

        
        private bool ValidarPassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*(),.?""{}|<>]).{6,}$";
            return Regex.IsMatch(password, pattern);
        }

        private void Registrarbtn_Click(object sender, EventArgs e)
        {
            string usuario = Usuariotxt.Text.Trim();
            string clave = Contraseñatxt.Text.Trim();
            string confirmar = Confirmtxt.Text.Trim();

            // VALIDACIONES ------------------------------
            if (usuario == "" || clave == "" || confirmar == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clave != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarPassword(clave))
            {
                MessageBox.Show("La contraseña debe contener:\n" +
                                "- Al menos 1 letra mayúscula\n" +
                                "- Al menos 1 número\n" +
                                "- Al menos 1 carácter especial\n" +
                                "- Mínimo 6 caracteres",
                                "Contraseña débil",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = Conexion.ObtenerConexion())
                {

                    string query = "SELECT public.registrar_cliente(@p_usuario, @p_clave);";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("p_usuario", usuario);
                        cmd.Parameters.AddWithValue("p_clave", clave);

                        var result = cmd.ExecuteScalar();

                        MessageBox.Show("Cliente registrado correctamente",
                                        "Éxito",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // limpiar campos
                        Usuariotxt.Clear();
                        Contraseñatxt.Clear();
                        Confirmtxt.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void Cerrarbtn_Click(object sender, EventArgs e)
        {   Login log= new Login();
            log.Show();
            this.Close();
        }

    }
}
