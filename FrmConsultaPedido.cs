using SistemaCafeteriaGourmet.Entidades;
using SistemaCafeteriaGourmet.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCafeteriaGourmet.UI
{
    public partial class FrmConsultaPedido : Form
    {
        private Pedido? pedidoSeleccionado;

        public FrmConsultaPedido()
        {
            InitializeComponent();
            this.Load += FrmConsultaPedido_Load;
        }

        private void FrmConsultaPedido_Load(object? sender, EventArgs e)
        {
            dgvConsultaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaPedidos.MultiSelect = false;
            dgvConsultaPedidos.ReadOnly = true;
            dgvConsultaPedidos.AutoGenerateColumns = true;
            dgvConsultaPedidos.SelectionChanged += dgvConsultaPedidos_SelectionChanged;
            CargarPedidosEnGrid();

        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (SistemaCafeteria.ObtenerInstancia.Pedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos registrados.");
                return;
            }
            if (pedidoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un pedido");
                return;
            }

            FrmFactura factura = new FrmFactura(pedidoSeleccionado);
            factura.ShowDialog();
        }


        private void CargarPedidosEnGrid()
        {
            dgvConsultaPedidos.DataSource = null;
            dgvConsultaPedidos.DataSource = SistemaCafeteria.ObtenerInstancia.Pedidos
                .Select(p => new
                {
                    Numero = p.Numero,
                    Fecha = p.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    Cliente = p.Cliente != null ? p.Cliente.Nombre : "Sin cliente",
                    Productos = p.ListaDetalles.Sum(d => d.Cantidad),
                    Subtotal = p.CalcularSubtotal().ToString("₡0.00"),
                    Descuento = p.EstrategiaDescuento != null ? p.EstrategiaDescuento.Nombre : "Sin descuento",
                    Total = p.CalcularTotal().ToString("₡0.00"),
                    Pedido = p
                })
                .ToList();

            //Esconder en la columna pedido
            if (dgvConsultaPedidos.Columns["Pedido"] != null)
            {
                dgvConsultaPedidos.Columns["Pedido"].Visible = false;
            }
        }


        private void dgvConsultaPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConsultaPedidos.CurrentRow?.DataBoundItem != null)
            {
                var fila = dgvConsultaPedidos.CurrentRow.DataBoundItem;
                var propiedadPedido = fila.GetType().GetProperty("Pedido");
                pedidoSeleccionado = propiedadPedido?.GetValue(fila) as Pedido;
            }
        }

      
    }
}
