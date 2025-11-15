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
    public partial class Cliente : Form
    {
        private Form loginForm;
        public Cliente(Form loginFormInstance)
        {
            InitializeComponent();
            ConfigurarColumnasDataGridView();
            CargarInventario();
            loginForm = loginFormInstance;


        }

        public int ClienteId { get; set; }

        private void ConfigurarColumnasDataGridView()
        {
            dgvInventario.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", Visible = false };
            dgvInventario.Columns.Add(colId);

            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre" });
            dgvInventario.Columns.Add(new DataGridViewImageColumn { Name = "Imagen", HeaderText = "Imagen", ImageLayout = DataGridViewImageCellLayout.Zoom });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn { Name = "CantidadDisponible", HeaderText = "Cantidad Disponible" });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn { Name = "Precio", HeaderText = "Precio" });
            dgvInventario.Columns.Add(new DataGridViewComboBoxColumn { Name = "CantidadComprar", HeaderText = "Cantidad a Comprar" });

            dgvInventario.AutoGenerateColumns = false;
        }

        private void CargarInventario()
        {
            DataTable dt = new DataTable();
            using (var conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM consultar_inventario()";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }

            dgvInventario.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvInventario.Rows.Add();
                var fila = dgvInventario.Rows[rowIndex];

                fila.Cells["Id"].Value = row["id"];
                fila.Cells["Nombre"].Value = row["nombre"].ToString();
                fila.Cells["Imagen"].Value = ByteArrayToImage(row["imagen"] as byte[]);
                fila.Cells["CantidadDisponible"].Value = row["cantidad"];
                fila.Cells["Precio"].Value = row["precio"];

                int cantidadMax = Convert.ToInt32(row["cantidad"]);
                var comboCell = new DataGridViewComboBoxCell();

                
                comboCell.Items.Add("[Seleccione]");

               
                for (int i = 1; i <= cantidadMax; i++)
                {
                    comboCell.Items.Add(i);
                }

                comboCell.Value = "[Seleccione]"; 

                fila.Cells["CantidadComprar"] = comboCell;
            }
        }

        private void ActualizarTotal()
        {
            decimal total = 0;
            foreach (PedidoItem item in listBoxCarrito.Items)
            {
                total += item.Precio * item.Cantidad;
            }
            txtTotal.Text = total.ToString("0.00") + " USD";
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
                return null;
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

    

private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (row.Cells["CantidadComprar"].Value != null &&
                    row.Cells["CantidadComprar"].Value.ToString() != "[Seleccione]" &&
                    int.TryParse(row.Cells["CantidadComprar"].Value.ToString(), out int cantidad) &&
                    cantidad > 0)
                {
                    var item = new PedidoItem()
                    {
                        IdMedicamento = Convert.ToInt32(row.Cells["Id"].Value),
                        Nombre = row.Cells["Nombre"].Value.ToString(),
                        Cantidad = cantidad,
                        Precio = Convert.ToDecimal(row.Cells["Precio"].Value)
                    };
                    listBoxCarrito.Items.Add(item);

                   
                    row.Cells["CantidadComprar"].Value = "[Seleccione]";
                }
            }
            ActualizarTotal();
        }

        

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            int clienteId = this.ClienteId;
            using (var conexion = Conexion.ObtenerConexion())
            {
                foreach (PedidoItem item in listBoxCarrito.Items)
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT registrar_pedido(@p_cliente, @p_medicamento, @p_cantidad)", conexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@p_cliente", clienteId);
                        cmd.Parameters.AddWithValue("@p_medicamento", item.IdMedicamento);
                        cmd.Parameters.AddWithValue("@p_cantidad", item.Cantidad);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("¡Compra realizada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBoxCarrito.Items.Clear();
            ActualizarTotal();
            CargarInventario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra Cliente
            loginForm.Show(); // Muestra Login nuevamente
        }


        private void listBoxCarrito_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCarrito.SelectedItem != null)
            {
                listBoxCarrito.Items.Remove(listBoxCarrito.SelectedItem);
                ActualizarTotal(); 
            }
        }

        private void dgvInventario_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
