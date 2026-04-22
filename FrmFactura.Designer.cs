namespace SistemaCafeteriaGourmet.UI
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            pnlTitla = new Panel();
            lblConsulta = new Label();
            panelll42 = new Panel();
            panel1 = new Panel();
            panel8 = new Panel();
            lblTotal = new Label();
            lblDescuentos = new Label();
            lblSubtotal = new Label();
            label5 = new Label();
            label6 = new Label();
            labelLL = new Label();
            panel7 = new Panel();
            lblDescuento = new Label();
            panel6 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            dgvFactura = new DataGridView();
            panel2 = new Panel();
            lblNmrPedido = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblFecha = new Label();
            lblNombreFactura = new Label();
            pnlTitla.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // pnlTitla
            // 
            pnlTitla.BackColor = Color.FromArgb(102, 48, 32);
            pnlTitla.Controls.Add(lblConsulta);
            pnlTitla.Controls.Add(panelll42);
            pnlTitla.Location = new Point(1, 0);
            pnlTitla.Name = "pnlTitla";
            pnlTitla.Size = new Size(1369, 86);
            pnlTitla.TabIndex = 3;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblConsulta.ForeColor = Color.FromArgb(229, 190, 152);
            lblConsulta.Location = new Point(127, 19);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(542, 38);
            lblConsulta.TabIndex = 1;
            lblConsulta.Text = "Cafetería Red Velvet - Factura de Pedido";
            // 
            // panelll42
            // 
            panelll42.BackColor = Color.FromArgb(102, 48, 32);
            panelll42.BackgroundImage = (Image)resources.GetObject("panelll42.BackgroundImage");
            panelll42.BackgroundImageLayout = ImageLayout.Zoom;
            panelll42.Location = new Point(23, 3);
            panelll42.Name = "panelll42";
            panelll42.Size = new Size(98, 69);
            panelll42.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(214, 189, 151);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(lblDescuentos);
            panel1.Controls.Add(lblSubtotal);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(labelLL);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblNmrPedido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblNombreFactura);
            panel1.Location = new Point(24, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(1298, 693);
            panel1.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(60, 42, 33);
            panel8.Controls.Add(lblTotal);
            panel8.Location = new Point(1023, 641);
            panel8.Name = "panel8";
            panel8.Size = new Size(205, 38);
            panel8.TabIndex = 28;
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
            lblDescuentos.Location = new Point(1109, 588);
            lblDescuentos.Name = "lblDescuentos";
            lblDescuentos.Size = new Size(19, 23);
            lblDescuentos.TabIndex = 27;
            lblDescuentos.Text = "0";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(1106, 533);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(22, 25);
            lblSubtotal.TabIndex = 26;
            lblSubtotal.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(743, 641);
            label5.Name = "label5";
            label5.Size = new Size(91, 31);
            label5.TabIndex = 25;
            label5.Text = "TOTAL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(735, 588);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 24;
            label6.Text = "DESCUENTO ";
            // 
            // labelLL
            // 
            labelLL.AutoSize = true;
            labelLL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLL.Location = new Point(735, 530);
            labelLL.Name = "labelLL";
            labelLL.Size = new Size(209, 28);
            labelLL.TabIndex = 23;
            labelLL.Text = "SUBTOTAL (GENERAL)";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(lblDescuento);
            panel7.Location = new Point(31, 601);
            panel7.Name = "panel7";
            panel7.Size = new Size(558, 63);
            panel7.TabIndex = 11;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(60, 16);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(56, 28);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "xxxx";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(102, 48, 32);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label4);
            panel6.Location = new Point(31, 547);
            panel6.Name = "panel6";
            panel6.Size = new Size(558, 54);
            panel6.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(229, 190, 152);
            label4.Location = new Point(113, 13);
            label4.Name = "label4";
            label4.Size = new Size(320, 28);
            label4.TabIndex = 0;
            label4.Text = "TIPO DE DESCUENTO APLICADO:";
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(31, 72);
            panel5.Name = "panel5";
            panel5.Size = new Size(55, 40);
            panel5.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(452, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 52);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 15, 12);
            panel3.Controls.Add(dgvFactura);
            panel3.Location = new Point(31, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(1228, 323);
            panel3.TabIndex = 7;
            // 
            // dgvFactura
            // 
            dgvFactura.BackgroundColor = Color.FromArgb(214, 189, 151);
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(28, 26);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(1176, 258);
            dgvFactura.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(31, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 52);
            panel2.TabIndex = 6;
            // 
            // lblNmrPedido
            // 
            lblNmrPedido.AutoSize = true;
            lblNmrPedido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNmrPedido.Location = new Point(620, 29);
            lblNmrPedido.Name = "lblNmrPedido";
            lblNmrPedido.Size = new Size(42, 23);
            lblNmrPedido.TabIndex = 5;
            lblNmrPedido.Text = "xxxx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(513, 26);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "N° Pedido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 76);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 3;
            label2.Text = "CLIENTE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 27);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 2;
            label1.Text = "FECHA:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(190, 29);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(42, 23);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "xxxx";
            // 
            // lblNombreFactura
            // 
            lblNombreFactura.AutoSize = true;
            lblNombreFactura.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreFactura.Location = new Point(190, 78);
            lblNombreFactura.Name = "lblNombreFactura";
            lblNombreFactura.Size = new Size(42, 23);
            lblNombreFactura.TabIndex = 0;
            lblNombreFactura.Text = "xxxx";
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 15, 12);
            ClientSize = new Size(1354, 834);
            Controls.Add(panel1);
            Controls.Add(pnlTitla);
            Name = "FrmFactura";
            Text = "FrmFactura";
            pnlTitla.ResumeLayout(false);
            pnlTitla.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitla;
        private Label lblConsulta;
        private Panel panelll42;
        private Panel panel1;
        private Label lblFecha;
        private Label lblNombreFactura;
        private Label lblNmrPedido;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvFactura;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Label lblDescuento;
        private Label label4;
        private Panel panel8;
        private Label lblTotal;
        private Label lblDescuentos;
        private Label lblSubtotal;
        private Label label5;
        private Label label6;
        private Label labelLL;
    }
}