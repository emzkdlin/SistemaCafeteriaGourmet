namespace SistemaCafeteriaGourmet.UI
{
    partial class FrmConsultaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPedido));
            pnlTitla = new Panel();
            lblConsulta = new Label();
            panelll42 = new Panel();
            panel1 = new Panel();
            btnReimprimir = new Button();
            panel2 = new Panel();
            dgvConsultaPedidos = new DataGridView();
            pnlTitla.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaPedidos).BeginInit();
            SuspendLayout();
            // 
            // pnlTitla
            // 
            pnlTitla.BackColor = Color.FromArgb(102, 48, 32);
            pnlTitla.Controls.Add(lblConsulta);
            pnlTitla.Controls.Add(panelll42);
            pnlTitla.Location = new Point(-3, 1);
            pnlTitla.Name = "pnlTitla";
            pnlTitla.Size = new Size(1358, 84);
            pnlTitla.TabIndex = 2;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblConsulta.ForeColor = Color.FromArgb(229, 190, 152);
            lblConsulta.Location = new Point(127, 19);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(560, 38);
            lblConsulta.TabIndex = 1;
            lblConsulta.Text = "Cafetería Red Velvet - Consulta de Pedido";
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
            panel1.Controls.Add(btnReimprimir);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(51, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 635);
            panel1.TabIndex = 3;
            // 
            // btnReimprimir
            // 
            btnReimprimir.BackColor = Color.FromArgb(60, 42, 33);
            btnReimprimir.BackgroundImage = (Image)resources.GetObject("btnReimprimir.BackgroundImage");
            btnReimprimir.BackgroundImageLayout = ImageLayout.Zoom;
            btnReimprimir.FlatStyle = FlatStyle.Flat;
            btnReimprimir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReimprimir.ForeColor = Color.FromArgb(229, 190, 152);
            btnReimprimir.ImageAlign = ContentAlignment.TopCenter;
            btnReimprimir.Location = new Point(960, 454);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(185, 156);
            btnReimprimir.TabIndex = 1;
            btnReimprimir.Text = "Reimprimir Factura";
            btnReimprimir.TextAlign = ContentAlignment.BottomCenter;
            btnReimprimir.UseVisualStyleBackColor = false;
            btnReimprimir.Click += btnReimprimir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 15, 12);
            panel2.Controls.Add(dgvConsultaPedidos);
            panel2.Location = new Point(73, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 385);
            panel2.TabIndex = 0;
            // 
            // dgvConsultaPedidos
            // 
            dgvConsultaPedidos.BackgroundColor = Color.FromArgb(214, 189, 151);
            dgvConsultaPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaPedidos.Location = new Point(29, 35);
            dgvConsultaPedidos.Name = "dgvConsultaPedidos";
            dgvConsultaPedidos.RowHeadersWidth = 51;
            dgvConsultaPedidos.Size = new Size(1017, 315);
            dgvConsultaPedidos.TabIndex = 0;
            // 
            // FrmConsultaPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 15, 12);
            ClientSize = new Size(1354, 834);
            Controls.Add(panel1);
            Controls.Add(pnlTitla);
            Name = "FrmConsultaPedido";
            Text = "FrmConsultaPedido";
            pnlTitla.ResumeLayout(false);
            pnlTitla.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsultaPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitla;
        private Label lblConsulta;
        private Panel panelll42;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvConsultaPedidos;
        private Button btnReimprimir;
    }
}