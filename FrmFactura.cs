using SistemaCafeteriaGourmet.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaCafeteriaGourmet.UI
{
    public partial class FrmFactura : Form
    {
        private readonly Pedido pedido;
        public FrmFactura(Pedido pedidoRecibido)
        {
            InitializeComponent();
            this.Load += FrmFactura_Load;
            pedido = pedidoRecibido;
        }

        private void FrmFactura_Load(object? sender, EventArgs e)
        {
            lblNmrPedido.Text = pedido.Numero.ToString();
            lblNombreFactura.Text = pedido.Cliente != null ? pedido.Cliente.Nombre : "Sin cliente";
            lblFecha.Text = pedido.Fecha.ToString("dd/MM/yyyy HH:mm");


            dgvFactura.DataSource = null;
            dgvFactura.DataSource = pedido.ListaDetalles
                .Select(d => new
                {
                    Producto = d.Producto.Nombre,
                    Cantidad = d.Cantidad,
                    CostoUnitario = d.Producto.CalcularPrecio().ToString("₡0.00"),
                    SubtotalLinea = d.CalcularSubtotal().ToString("₡0.00")
                })
                .ToList();

            dgvFactura.ReadOnly = true;
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Usar un valor fijo
            double subtotal = pedido.CalcularSubtotal();
            double descuento = pedido.CalcularDescuento();
            double total = pedido.CalcularTotal();

            lblSubtotal.Text = subtotal.ToString("₡0.00");
            lblDescuento.Text = pedido.EstrategiaDescuento != null ? pedido.EstrategiaDescuento.Nombre : "Sin descuento";
            lblTotal.Text = total.ToString("₡0.00");
            lblDescuentos.Text = descuento.ToString("₡0.00");
        }
    }
}
