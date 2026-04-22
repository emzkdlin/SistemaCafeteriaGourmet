using SistemaCafeteriaGourmet.Entidades;
using SistemaCafeteriaGourmet.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SistemaCafeteriaGourmet.UI
{
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
            this.Load += FrmGestionClientes_Load;
        }

        private void FrmGestionClientes_Load(object? sender, EventArgs e)
        {
            ActualizarGrid();
            dgvGestionClientes.ReadOnly = true;
            dgvGestionClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCedulaClientes.Text) ||
                string.IsNullOrWhiteSpace(txtNombreClientes.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoClientes.Text) ||
                string.IsNullOrWhiteSpace(txtEmailClientes.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtTelefonoClientes.Text.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener solo números.");
                return;
            }
            if (!Regex.IsMatch(txtNombreClientes.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                return;
            }
            if (!txtCedulaClientes.Text.All(char.IsDigit))
            {
                MessageBox.Show("La cédula debe ser numérica.");
                return;
            }
            if (!txtEmailClientes.Text.Contains("@") || !txtEmailClientes.Text.Contains("."))
            {
                MessageBox.Show("El correo debe incluir un '@' y un dominio válido (ej: usuario@correo.com).");
                return;
            }

            Cliente nuevoCliente = new Cliente();
            nuevoCliente.Cedula = txtCedulaClientes.Text;
            nuevoCliente.Nombre = txtNombreClientes.Text;
            nuevoCliente.Telefono = txtTelefonoClientes.Text;
            nuevoCliente.Correo = txtEmailClientes.Text;

            bool existeCliente = SistemaCafeteria.ObtenerInstancia.Clientes.Exists(c => c.Cedula == nuevoCliente.Cedula);
            if (existeCliente)
            {
                MessageBox.Show("Ya existe un cliente con esa cédula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                SistemaCafeteria.ObtenerInstancia.Clientes.Add(nuevoCliente);
               
               GuardarCambios();
               ActualizarGrid();
              
            }

        }
        private void GuardarCambios()
        {
            // Guardar toda la instancia (clientes + productos + pedidos)
            new ArchivoService().GuardarDatos();
        }

        private void ActualizarGrid()
        {
            dgvGestionClientes.DataSource = null;
            dgvGestionClientes.DataSource = SistemaCafeteria.ObtenerInstancia.Clientes;
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            if (SistemaCafeteria.ObtenerInstancia.Clientes == null)
            {
                MessageBox.Show("No hay clientes para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var confirmacion = MessageBox.Show(
                   "¿Está seguro que desea eliminar todos los clientes?",
                   "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // 🔹 Vaciar la lista
                    SistemaCafeteria.ObtenerInstancia.Clientes.Clear();

                    GuardarCambios();

                    ActualizarGrid();
                }
            }
        }
    }
}
