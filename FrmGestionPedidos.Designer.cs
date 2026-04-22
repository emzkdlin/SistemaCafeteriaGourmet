namespace SistemaCafeteriaGourmet.UI
{
    partial class FrmGestionPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPedidos));
            pnlTitl = new Panel();
            lblCafeteriaPedidos = new Label();
            panelll4 = new Panel();
            panelClientes = new Panel();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            label9 = new Label();
            btnAgregarPedido = new Button();
            cmbDescuentos = new ComboBox();
            grpBox4 = new GroupBox();
            cmbProductoPedidos = new ComboBox();
            nmUpDwnCantidad = new NumericUpDown();
            label1 = new Label();
            lblProductooos = new Label();
            dtpFecha = new DateTimePicker();
            panel4 = new Panel();
            panel3 = new Panel();
            btnEliminarPedido = new Button();
            btnGuardarPedido = new Button();
            txtNumPedido = new TextBox();
            lblFechaPedidos = new Label();
            label4 = new Label();
            lblPedido = new Label();
            groupBox1 = new GroupBox();
            cmbNombrePedido = new ComboBox();
            label6 = new Label();
            pnlDgva = new Panel();
            panel7 = new Panel();
            lblTotal = new Label();
            lblDescuentos = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            lblNmrPedido = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblFecha = new Label();
            lblNombreCliente = new Label();
            lblSubtotal = new Label();
            label3 = new Label();
            label2 = new Label();
            labelLL = new Label();
            labelClientes = new Label();
            dgvGestionPedido = new DataGridView();
            pnlTitl.SuspendLayout();
            panelClientes.SuspendLayout();
            groupBox2.SuspendLayout();
            grpBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmUpDwnCantidad).BeginInit();
            groupBox1.SuspendLayout();
            pnlDgva.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionPedido).BeginInit();
            SuspendLayout();
            // 
            // pnlTitl
            // 
            pnlTitl.BackColor = Color.FromArgb(102, 48, 32);
            pnlTitl.Controls.Add(lblCafeteriaPedidos);
            pnlTitl.Controls.Add(panelll4);
            pnlTitl.Location = new Point(-2, 0);
            pnlTitl.Name = "pnlTitl";
            pnlTitl.Size = new Size(1366, 84);
            pnlTitl.TabIndex = 2;
            // 
            // lblCafeteriaPedidos
            // 
            lblCafeteriaPedidos.AutoSize = true;
            lblCafeteriaPedidos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblCafeteriaPedidos.ForeColor = Color.FromArgb(229, 190, 152);
            lblCafeteriaPedidos.Location = new Point(127, 19);
            lblCafeteriaPedidos.Name = "lblCafeteriaPedidos";
            lblCafeteriaPedidos.Size = new Size(558, 38);
            lblCafeteriaPedidos.TabIndex = 1;
            lblCafeteriaPedidos.Text = "Cafetería Red Velvet - Gestión de Pedidos";
            // 
            // panelll4
            // 
            panelll4.BackColor = Color.FromArgb(102, 48, 32);
            panelll4.BackgroundImage = (Image)resources.GetObject("panelll4.BackgroundImage");
            panelll4.BackgroundImageLayout = ImageLayout.Zoom;
            panelll4.Location = new Point(23, 3);
            panelll4.Name = "panelll4";
            panelll4.Size = new Size(98, 69);
            panelll4.TabIndex = 0;
            // 
            // panelClientes
            // 
            panelClientes.BackColor = Color.FromArgb(214, 189, 151);
            panelClientes.Controls.Add(groupBox2);
            panelClientes.Controls.Add(grpBox4);
            panelClientes.Controls.Add(dtpFecha);
            panelClientes.Controls.Add(panel4);
            panelClientes.Controls.Add(panel3);
            panelClientes.Controls.Add(btnEliminarPedido);
            panelClientes.Controls.Add(btnGuardarPedido);
            panelClientes.Controls.Add(txtNumPedido);
            panelClientes.Controls.Add(lblFechaPedidos);
            panelClientes.Controls.Add(label4);
            panelClientes.Controls.Add(lblPedido);
            panelClientes.Controls.Add(groupBox1);
            panelClientes.Location = new Point(21, 147);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(532, 652);
            panelClientes.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnAgregarPedido);
            groupBox2.Controls.Add(cmbDescuentos);
            groupBox2.Location = new Point(30, 400);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 146);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "SELECCIONAR DESCUENTOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 42, 33);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(259, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 50);
            panel1.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 34);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 1;
            label9.Text = "DESCUENTOS";
            // 
            // btnAgregarPedido
            // 
            btnAgregarPedido.BackColor = Color.FromArgb(60, 42, 33);
            btnAgregarPedido.FlatAppearance.BorderSize = 0;
            btnAgregarPedido.FlatStyle = FlatStyle.Flat;
            btnAgregarPedido.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPedido.ForeColor = Color.FromArgb(229, 190, 152);
            btnAgregarPedido.Location = new Point(308, 82);
            btnAgregarPedido.Name = "btnAgregarPedido";
            btnAgregarPedido.Size = new Size(148, 50);
            btnAgregarPedido.TabIndex = 20;
            btnAgregarPedido.Text = "AGREGAR";
            btnAgregarPedido.UseVisualStyleBackColor = false;
            btnAgregarPedido.Click += btnAgregarPedido_Click;
            // 
            // cmbDescuentos
            // 
            cmbDescuentos.BackColor = Color.FromArgb(214, 189, 151);
            cmbDescuentos.FormattingEnabled = true;
            cmbDescuentos.Location = new Point(202, 26);
            cmbDescuentos.Name = "cmbDescuentos";
            cmbDescuentos.Size = new Size(240, 28);
            cmbDescuentos.TabIndex = 0;
            // 
            // grpBox4
            // 
            grpBox4.Controls.Add(cmbProductoPedidos);
            grpBox4.Controls.Add(nmUpDwnCantidad);
            grpBox4.Controls.Add(label1);
            grpBox4.Controls.Add(lblProductooos);
            grpBox4.Location = new Point(30, 250);
            grpBox4.Name = "grpBox4";
            grpBox4.Size = new Size(474, 127);
            grpBox4.TabIndex = 28;
            grpBox4.TabStop = false;
            grpBox4.Text = "SELECCIONAR PRODUCTOS";
            // 
            // cmbProductoPedidos
            // 
            cmbProductoPedidos.BackColor = Color.FromArgb(214, 189, 151);
            cmbProductoPedidos.FormattingEnabled = true;
            cmbProductoPedidos.Location = new Point(202, 23);
            cmbProductoPedidos.Name = "cmbProductoPedidos";
            cmbProductoPedidos.Size = new Size(240, 28);
            cmbProductoPedidos.TabIndex = 12;
            // 
            // nmUpDwnCantidad
            // 
            nmUpDwnCantidad.Location = new Point(202, 87);
            nmUpDwnCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmUpDwnCantidad.Name = "nmUpDwnCantidad";
            nmUpDwnCantidad.Size = new Size(62, 27);
            nmUpDwnCantidad.TabIndex = 11;
            nmUpDwnCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 91);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 5;
            label1.Text = "CANTIDAD";
            // 
            // lblProductooos
            // 
            lblProductooos.AutoSize = true;
            lblProductooos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductooos.Location = new Point(9, 23);
            lblProductooos.Name = "lblProductooos";
            lblProductooos.Size = new Size(99, 23);
            lblProductooos.TabIndex = 4;
            lblProductooos.Text = "PRODUCTO";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarMonthBackground = Color.White;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(234, 198);
            dtpFecha.MaxDate = new DateTime(2027, 12, 31, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(221, 27);
            dtpFecha.TabIndex = 27;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(60, 42, 33);
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(286, 575);
            panel4.Name = "panel4";
            panel4.Size = new Size(47, 41);
            panel4.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(60, 42, 33);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(32, 575);
            panel3.Name = "panel3";
            panel3.Size = new Size(47, 41);
            panel3.TabIndex = 21;
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.BackColor = Color.FromArgb(60, 42, 33);
            btnEliminarPedido.FlatStyle = FlatStyle.Flat;
            btnEliminarPedido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarPedido.ForeColor = Color.FromArgb(229, 190, 152);
            btnEliminarPedido.Location = new Point(273, 565);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(231, 63);
            btnEliminarPedido.TabIndex = 18;
            btnEliminarPedido.Text = "ELIMINAR";
            btnEliminarPedido.UseVisualStyleBackColor = false;
            btnEliminarPedido.Click += btnEliminarPedido_Click;
            // 
            // btnGuardarPedido
            // 
            btnGuardarPedido.BackColor = Color.FromArgb(60, 42, 33);
            btnGuardarPedido.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardarPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 60, 50);
            btnGuardarPedido.FlatStyle = FlatStyle.Flat;
            btnGuardarPedido.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarPedido.ForeColor = Color.FromArgb(229, 190, 152);
            btnGuardarPedido.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardarPedido.Location = new Point(19, 564);
            btnGuardarPedido.Name = "btnGuardarPedido";
            btnGuardarPedido.Size = new Size(232, 63);
            btnGuardarPedido.TabIndex = 17;
            btnGuardarPedido.Text = "GUARDAR";
            btnGuardarPedido.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGuardarPedido.UseVisualStyleBackColor = false;
            btnGuardarPedido.Click += btnGuardarPedido_Click;
            // 
            // txtNumPedido
            // 
            txtNumPedido.BackColor = Color.FromArgb(214, 189, 151);
            txtNumPedido.Enabled = false;
            txtNumPedido.Location = new Point(232, 62);
            txtNumPedido.Name = "txtNumPedido";
            txtNumPedido.Size = new Size(240, 27);
            txtNumPedido.TabIndex = 9;
            // 
            // lblFechaPedidos
            // 
            lblFechaPedidos.AutoSize = true;
            lblFechaPedidos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaPedidos.Location = new Point(46, 202);
            lblFechaPedidos.Name = "lblFechaPedidos";
            lblFechaPedidos.Size = new Size(61, 23);
            lblFechaPedidos.TabIndex = 7;
            lblFechaPedidos.Text = "FECHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 62);
            label4.Name = "label4";
            label4.Size = new Size(174, 23);
            label4.TabIndex = 3;
            label4.Text = "NÚMERO DE PEDIDO";
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedido.Location = new Point(37, 23);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(202, 23);
            lblPedido.TabIndex = 2;
            lblPedido.Text = "CREAR / EDITAR PEDIDO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbNombrePedido);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(32, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 81);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "CLIENTE (Buscar Cliente)";
            // 
            // cmbNombrePedido
            // 
            cmbNombrePedido.BackColor = Color.FromArgb(214, 189, 151);
            cmbNombrePedido.FormattingEnabled = true;
            cmbNombrePedido.Location = new Point(202, 39);
            cmbNombrePedido.Name = "cmbNombrePedido";
            cmbNombrePedido.Size = new Size(238, 28);
            cmbNombrePedido.TabIndex = 11;
            cmbNombrePedido.SelectedIndexChanged += cmbNombrePedido_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 44);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 5;
            label6.Text = "NOMBRE";
            // 
            // pnlDgva
            // 
            pnlDgva.BackColor = Color.FromArgb(214, 189, 151);
            pnlDgva.BorderStyle = BorderStyle.FixedSingle;
            pnlDgva.Controls.Add(panel7);
            pnlDgva.Controls.Add(lblDescuentos);
            pnlDgva.Controls.Add(panel5);
            pnlDgva.Controls.Add(panel2);
            pnlDgva.Controls.Add(panel6);
            pnlDgva.Controls.Add(lblNmrPedido);
            pnlDgva.Controls.Add(label5);
            pnlDgva.Controls.Add(label7);
            pnlDgva.Controls.Add(label8);
            pnlDgva.Controls.Add(lblFecha);
            pnlDgva.Controls.Add(lblNombreCliente);
            pnlDgva.Controls.Add(lblSubtotal);
            pnlDgva.Controls.Add(label3);
            pnlDgva.Controls.Add(label2);
            pnlDgva.Controls.Add(labelLL);
            pnlDgva.Controls.Add(labelClientes);
            pnlDgva.Controls.Add(dgvGestionPedido);
            pnlDgva.Location = new Point(612, 147);
            pnlDgva.Name = "pnlDgva";
            pnlDgva.Size = new Size(714, 652);
            pnlDgva.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(60, 42, 33);
            panel7.Controls.Add(lblTotal);
            panel7.Location = new Point(322, 595);
            panel7.Name = "panel7";
            panel7.Size = new Size(205, 38);
            panel7.TabIndex = 22;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ButtonHighlight;
            lblTotal.Location = new Point(86, 1);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(27, 31);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "0";
            // 
            // lblDescuentos
            // 
            lblDescuentos.AutoSize = true;
            lblDescuentos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescuentos.Location = new Point(405, 542);
            lblDescuentos.Name = "lblDescuentos";
            lblDescuentos.Size = new Size(19, 23);
            lblDescuentos.TabIndex = 21;
            lblDescuentos.Text = "0";
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(42, 106);
            panel5.Name = "panel5";
            panel5.Size = new Size(55, 40);
            panel5.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(405, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 52);
            panel2.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(42, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(55, 52);
            panel6.TabIndex = 18;
            // 
            // lblNmrPedido
            // 
            lblNmrPedido.AutoSize = true;
            lblNmrPedido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNmrPedido.Location = new Point(573, 63);
            lblNmrPedido.Name = "lblNmrPedido";
            lblNmrPedido.Size = new Size(42, 23);
            lblNmrPedido.TabIndex = 17;
            lblNmrPedido.Text = "xxxx";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(466, 60);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 16;
            label5.Text = "N° Pedido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(103, 110);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 15;
            label7.Text = "CLIENTE:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 61);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 14;
            label8.Text = "FECHA:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(201, 63);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(42, 23);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "xxxx";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreCliente.Location = new Point(201, 112);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(42, 23);
            lblNombreCliente.TabIndex = 12;
            lblNombreCliente.Text = "xxxx";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(405, 487);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(22, 25);
            lblSubtotal.TabIndex = 10;
            lblSubtotal.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 595);
            label3.Name = "label3";
            label3.Size = new Size(91, 31);
            label3.TabIndex = 6;
            label3.Text = "TOTAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 542);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 5;
            label2.Text = "DESCUENTO ";
            // 
            // labelLL
            // 
            labelLL.AutoSize = true;
            labelLL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLL.Location = new Point(34, 484);
            labelLL.Name = "labelLL";
            labelLL.Size = new Size(209, 28);
            labelLL.TabIndex = 4;
            labelLL.Text = "SUBTOTAL (GENERAL)";
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClientes.Location = new Point(42, 10);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(260, 23);
            labelClientes.TabIndex = 1;
            labelClientes.Text = "DETALLE DEL PEDIDO Y TOTALES";
            // 
            // dgvGestionPedido
            // 
            dgvGestionPedido.BackgroundColor = Color.FromArgb(214, 189, 151);
            dgvGestionPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestionPedido.Location = new Point(34, 162);
            dgvGestionPedido.Name = "dgvGestionPedido";
            dgvGestionPedido.RowHeadersWidth = 51;
            dgvGestionPedido.Size = new Size(652, 283);
            dgvGestionPedido.TabIndex = 0;
            // 
            // FrmGestionPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 15, 12);
            ClientSize = new Size(1354, 834);
            Controls.Add(pnlDgva);
            Controls.Add(panelClientes);
            Controls.Add(pnlTitl);
            Name = "FrmGestionPedidos";
            Text = "FrmGestionPedidos";
            pnlTitl.ResumeLayout(false);
            pnlTitl.PerformLayout();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpBox4.ResumeLayout(false);
            grpBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmUpDwnCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlDgva.ResumeLayout(false);
            pnlDgva.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitl;
        private Label lblCafeteriaPedidos;
        private Panel panelll4;
        private Panel panelClientes;
        private Panel panel4;
        private Panel panel3;
        private Button btnEliminarPedido;
        private Button btnGuardarPedido;
        private TextBox txtNumPedido;
        private Label lblFechaPedidos;
        private Label label6;
        private Label label4;
        private Label lblPedido;
        private Panel pnlDgva;
        private Label labelClientes;
        private DataGridView dgvGestionPedido;
        private GroupBox groupBox1;
        private DateTimePicker dtpFecha;
        private GroupBox grpBox4;
        private Label label1;
        private Label lblProductooos;
        private ComboBox cmbProductoPedidos;
        private NumericUpDown nmUpDwnCantidad;
        private Label label3;
        private Label label2;
        private Label labelLL;
        private Panel panel1;
        private Button btnAgregarPedido;
        private ComboBox cmbNombrePedido;
        private Label lblTotal;
        private Label lblSubtotal;
        private Panel panel5;
        private Panel panel2;
        private Panel panel6;
        private Label lblNmrPedido;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label lblFecha;
        private Label lblNombreCliente;
        private GroupBox groupBox2;
        private ComboBox cmbDescuentos;
        private Label lblDescuentos;
        private Panel panel7;
        private Label label9;
    }
}