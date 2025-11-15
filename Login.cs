using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtContraseña.Text.Trim();

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT * FROM login_usuario(@u, @c)";
                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("u", usuario);
                        cmd.Parameters.AddWithValue("c", clave);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tipo = reader["tipo"].ToString();
                                int clienteId = Convert.ToInt32(reader["id"]);  

                                MessageBox.Show("Bienvenido " + usuario + "!");

                                if (tipo == "admin")
                                {
                                    Farmaceutico Farma = new Farmaceutico();
                                    Farma.Show();
                                }
                                else
                                {
                                    Cliente clienteForm = new Cliente(this);
                                    clienteForm.Show();
                                    this.Hide(); // Oculta la ventana Login
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void lblregistrar_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }
    }
}
