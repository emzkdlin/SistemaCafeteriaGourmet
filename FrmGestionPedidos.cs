using SistemaCafeteriaGourmet.Entidades;
using SistemaCafeteriaGourmet.Interfaz;
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
    public partial class FrmGestionPedidos : Form
    {
        Pedido? pedidoActual = null;
        public FrmGestionPedidos()
        {
            InitializeComponent();
            this.Load += FrmGestionPedidos_Load;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
        }

        private void dtpFecha_ValueChanged(object? sender, EventArgs e)
        {
           ActualizarFecha();
        }
        private void ActualizarFecha()
        {
            if (pedidoActual != null)
            {
                pedidoActual.Fecha = dtpFecha.Value;
                lblFecha.Text = pedidoActual.Fecha.ToString("dd/MM/yyyy HH:mm");
            }
        }
        private void FrmGestionPedidos_Load(object? sender, EventArgs e)
        {

            CargarPedidos();
            CargarClientes();
            CargarDescuentos();
            dgvGestionPedido.ReadOnly = true;
            dgvGestionPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void CargarDescuentos()
        {
            cmbDescuentos.DataSource = new List<IEstrategiaDescuento>
            {
                new SinDescuentoStrategy(),
                new DescuentoClienteFrecuenteStrategy(),
                new DescuentoPromocionEspecialStrategy()
            };

            cmbDescuentos.DisplayMember = "Nombre";
        }
        private void GuardarCambios()
        {
            new ArchivoService().GuardarDatos();
        }
        private void CargarPedidos()
        {
            cmbProductoPedidos.DataSource = SistemaCafeteria.ObtenerInstancia.Productos;
        }

        private void CargarClientes()
        {
            cmbNombrePedido.DataSource = SistemaCafeteria.ObtenerInstancia.Clientes;
        }
    
        private void cmbNombrePedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombrePedido.SelectedItem != null)
            {
                var cliente = (Cliente)cmbNombrePedido.SelectedItem;

                if (pedidoActual != null && pedidoActual.ListaDetalles.Count > 0)
                {
                    var confirmacion = MessageBox.Show(
                        "Ya hay productos en el pedido. Si cambia el cliente se perderán. ¿Desea continuar?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.No)
                    {
                        return;
                    }
                }

                pedidoActual = new Pedido(cliente);
                pedidoActual.Fecha = dtpFecha.Value;
                pedidoActual.Numero = GenerarNumeroPedido();
                txtNumPedido.Text = pedidoActual.Numero;
                lblNombreCliente.Text = cliente.Nombre;
                lblNmrPedido.Text = pedidoActual.Numero.ToString();

                ActualizarFecha();
                ActualizarGrid();
                ActualizarTotales();
                nmUpDwnCantidad.Value = 1;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un cliente");
            }

        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            if (cmbDescuentos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente primero");
                return;
            }
            if (pedidoActual == null) 
            {
                MessageBox.Show("Debe seleccionar un cliente antes de agregar productos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (cmbProductoPedidos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            Producto producto = (Producto)cmbProductoPedidos.SelectedItem;
            int cantidad = (int)nmUpDwnCantidad.Value;

            pedidoActual.AgregarProducto(producto, cantidad);


            AplicarDescuento();

            ActualizarGrid();

            ActualizarTotales();

            // 8. Reset cantidad
            nmUpDwnCantidad.Value = 1;
        }

        private void AplicarDescuento()
        {
            //Si es null, se asigna sin descuento
            IEstrategiaDescuento estrategia = cmbDescuentos.SelectedItem as IEstrategiaDescuento ?? new SinDescuentoStrategy();
            if (pedidoActual != null)
            {
                pedidoActual.AsignarDescuento(estrategia);
            }
        }
        private void ActualizarGrid()
        {
            // 6. Refrescar DataGridView
            dgvGestionPedido.DataSource = null;
            dgvGestionPedido.DataSource = pedidoActual?.ListaDetalles;


        }

        private void ActualizarTotales()
        {
            if (pedidoActual != null)
            {

                lblSubtotal.Text = pedidoActual.CalcularSubtotal().ToString("₡0.00");
                lblTotal.Text = pedidoActual.CalcularTotal().ToString("₡0.00");
                lblDescuentos.Text = pedidoActual.CalcularDescuento().ToString("₡0.00");
            } 
        }



        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (pedidoActual == null)
                {
                    MessageBox.Show("Debe crear o seleccionar un pedido antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbNombrePedido.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente.");
                    return;
                }

                if (pedidoActual.ListaDetalles.Count == 0)
                {
                    MessageBox.Show("No hay un pedido para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pedidoActual.Cliente = (Cliente)cmbNombrePedido.SelectedItem;
                pedidoActual.Fecha = dtpFecha.Value;


                AplicarDescuento();
                //Evita que se guarde dos veces
                if (!SistemaCafeteria.ObtenerInstancia.Pedidos.Contains(pedidoActual))
                {
                    SistemaCafeteria.ObtenerInstancia.Pedidos.Add(pedidoActual);
                    GuardarCambios();
                    MessageBox.Show("Pedido guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Este pedido ya se guardó", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                GuardarCambios();
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el pedido: " + ex.Message);
            }

        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (pedidoActual == null || pedidoActual.ListaDetalles.Count == 0)
            {
                MessageBox.Show("No hay un pedido válido para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var confirmResult = MessageBox.Show("¿Está seguro de eliminar este pedido?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    SistemaCafeteria.ObtenerInstancia.Pedidos.Remove(pedidoActual);
                    GuardarCambios();
                    MessageBox.Show("Pedido eliminado exitosamente.");

                    pedidoActual = null;
                    dgvGestionPedido.DataSource = null;
                }
             
            }

        }


        public static string GenerarNumeroPedido()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmmss");
        }
    }
}
