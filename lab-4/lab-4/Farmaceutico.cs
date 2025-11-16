using lab4;
using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace adm
{
    public partial class Farmaceutico : Form
    {
        public Farmaceutico()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboOpciones.Items.AddRange(new object[]
            {
                "Agregar Medicamento",
                "Modificar/eliminar Medicamento",
                "Reabastecer Inventario",
                "Inventario",
                "Pedidos"
            });
        }

        private void cboOpciones_SelectIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboOpciones.SelectedItem.ToString();
            grpInf.Visible = false;
            grpEliminar.Visible = false;
            grpInventario.Visible = false;
            dgvTabla.Visible = false;
            btnSubir.Visible = false;
            btnMo.Visible = false;
            grpRea.Visible = false;

            switch (opcion)
            {
                case "Agregar Medicamento":
                    txtNom.Clear();
                    txtCanDis.Clear();
                    txtPrecio.Clear();
                    grpInf.Visible = true;
                    btnSubir.Visible = true;
                    break;

                case "Modificar/eliminar Medicamento":
                    grpInf.Text = "Modificar Medicamento";
                    grpInf.Visible = true;
                    grpEliminar.Visible = true;
                    btnMo.Visible = true;
                    dgvTabla.Visible = true;
                    CargarMedicamentos();
                    CargarComboMedicamentos();
                    break;

                case "Reabastecer Inventario":
                    grpRea.Text = "Reabastecer Inventario";
                    grpRea.Visible = true;
                    CargarMedicamentos();
                    break;

                case "Inventario":
                    grpInventario.Visible = true;
                    CargarMedicamentos();
                    break;

                case "Pedidos":
                    grpInventario.Visible = true;
                    CargarDetallePedidos();
                    break;
            }
        }

        private void CargarMedicamentos()
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    using (var da = new NpgsqlDataAdapter("SELECT * FROM consultar_inventario()", con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvTabla.DataSource = dt;
                        dgvInventario.DataSource = dt;
                        dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar medicamentos: " + ex.Message);
            }
        }

        private void CargarDetallePedidos()
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    using (var da = new NpgsqlDataAdapter("SELECT * FROM consultar_detalle_pedidos()", con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvInventario.DataSource = dt;
                        dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle de pedidos: " + ex.Message);
            }
        }

        private void CargarComboMedicamentos()
        {
            using (var con = Conexion.ObtenerConexion())
            {
                using (var cmd = new NpgsqlCommand("SELECT id, nombre FROM medicamentos ORDER BY nombre", con))
                {
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cboMedicamentos.DisplayMember = "nombre";
                        cboMedicamentos.ValueMember = "id";
                        cboMedicamentos.DataSource = dt;
                    }
                }
            }
        }

        private byte[] ObtenerImagenBytes()
        {
            if (pbImagen.Image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private int ObtenerIdPorNombre(string nombre)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                using (var cmd = new NpgsqlCommand("SELECT id FROM medicamentos WHERE nombre = @nombre LIMIT 1", con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; //  -1 si es si no se encuentra la opcion
                }
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtCanDis.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos del medicamento.");
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT agregar_medicamento(@p_nombre, @p_imagen, @p_cantidad, @p_precio)", con))
                    {
                        cmd.Parameters.AddWithValue("p_nombre", txtNom.Text);
                        cmd.Parameters.AddWithValue("p_imagen", (object)ObtenerImagenBytes() ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("p_cantidad", int.Parse(txtCanDis.Text));
                        cmd.Parameters.AddWithValue("p_precio", decimal.Parse(txtPrecio.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicamento agregado exitosamente.");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato en Cantidad Disponible o Precio. Ingrese números válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar medicamento: " + ex.Message);
            }
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            int id = ObtenerIdPorNombre(txtNom.Text);
            if (id == -1)
            {
                MessageBox.Show("El medicamento no existe, Verifique el nombre y no cambie el nombre");
                return;
            }

            if ( string.IsNullOrWhiteSpace(txtCanDis.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos del medicamento a modificar");
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    using (var cmd = new NpgsqlCommand(
                        "SELECT modificar_medicamento(@p_id, @p_nombre, @p_imagen, @p_cantidad, @p_precio)", con))
                    {
                        cmd.Parameters.AddWithValue("p_id", id);
                        cmd.Parameters.AddWithValue("p_nombre", txtNom.Text);
                        cmd.Parameters.AddWithValue("p_imagen", (object)ObtenerImagenBytes() ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("p_cantidad", int.Parse(txtCanDis.Text));
                        cmd.Parameters.AddWithValue("p_precio", decimal.Parse(txtPrecio.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicamento modificado exitosamente.");
                        CargarMedicamentos();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato en Cantidad Disponible o Precio");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar medicamento : " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = cboMedicamentos.SelectedItem != null ? ObtenerIdPorNombre(cboMedicamentos.Text) : -1;
            if (id == -1) return;

            if (MessageBox.Show("¿Está seguro que desea eliminar el medicamento seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var con = Conexion.ObtenerConexion())
                    {
                        using (var cmd = new NpgsqlCommand("SELECT eliminar_medicamento(@p_id)", con))
                        {
                            cmd.Parameters.AddWithValue("p_id", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Medicamento eliminado exitosamente.");
                            CargarMedicamentos();
                            txtNom.Clear();
                            txtCanDis.Clear();
                            txtPrecio.Clear();
                            pbImagen.Image = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar medicamento: " + ex.Message);
                }
            }
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvTabla.Rows[e.RowIndex];
            txtNom.Text = fila.Cells["nombre"].Value.ToString();
            txtCanDis.Text = fila.Cells["cantidad"].Value.ToString();
            txtPrecio.Text = fila.Cells["precio"].Value.ToString();

            if (fila.Cells["imagen"].Value != DBNull.Value)
            {
                byte[] imagenBytes = (byte[])fila.Cells["imagen"].Value;
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    pbImagen.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbImagen.Image = null;
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png;*.jpeg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCanti.Text);
            if(cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida para reabastecer.");
                return;
            }

            int idMedicamento = ObtenerIdPorNombre(cboMedicamento.Text);
            if (idMedicamento == -1)
            {
                MessageBox.Show("No se encontró el medicamento seleccionado.");
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    using (var cmd = new NpgsqlCommand("SELECT reabastecer_medicamento(@p_id, @p_cantidad)", con))
                    {
                        cmd.Parameters.AddWithValue("p_id", idMedicamento);
                        cmd.Parameters.AddWithValue("p_cantidad", cantidad);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicamento reabastecido correctamente.");
                        CargarMedicamentos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reabastecer medicamento: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(); // Muestra Login nuevamente
            this.Close(); // Cierra Cliente
        }
    }
}
