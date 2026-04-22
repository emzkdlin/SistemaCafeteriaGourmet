namespace SistemaCafeteriaGourmet.UI
{
    partial class FrmGestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTitl = new Panel();
            lblCafeteria = new Label();
            panelll4 = new Panel();
            panelClientes = new Panel();
            txtEmailClientes = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            btnEliminarClientes = new Button();
            btnGuardarClientes = new Button();
            txtTelefonoClientes = new TextBox();
            txtNombreClientes = new TextBox();
            txtCedulaClientes = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pnlDgva = new Panel();
            labelClientes = new Label();
            dgvGestionClientes = new DataGridView();
            pnlTitl.SuspendLayout();
            panelClientes.SuspendLayout();
            pnlDgva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionClientes).BeginInit();
            SuspendLayout();
            // 
            // pnlTitl
            // 
            pnlTitl.BackColor = Color.FromArgb(102, 48, 32);
            pnlTitl.Controls.Add(lblCafeteria);
            pnlTitl.Controls.Add(panelll4);
            pnlTitl.Location = new Point(-2, -2);
            pnlTitl.Name = "pnlTitl";
            pnlTitl.Size = new Size(1361, 84);
            pnlTitl.TabIndex = 1;
            // 
            // lblCafeteria
            // 
            lblCafeteria.AutoSize = true;
            lblCafeteria.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblCafeteria.ForeColor = Color.FromArgb(229, 190, 152);
            lblCafeteria.Location = new Point(127, 19);
            lblCafeteria.Name = "lblCafeteria";
            lblCafeteria.Size = new Size(559, 38);
            lblCafeteria.TabIndex = 1;
            lblCafeteria.Text = "Cafetería Red Velvet - Gestión de Clientes";
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
            panelClientes.Controls.Add(txtEmailClientes);
            panelClientes.Controls.Add(panel4);
            panelClientes.Controls.Add(panel3);
            panelClientes.Controls.Add(btnEliminarClientes);
            panelClientes.Controls.Add(btnGuardarClientes);
            panelClientes.Controls.Add(txtTelefonoClientes);
            panelClientes.Controls.Add(txtNombreClientes);
            panelClientes.Controls.Add(txtCedulaClientes);
            panelClientes.Controls.Add(label7);
            panelClientes.Controls.Add(label6);
            panelClientes.Controls.Add(label5);
            panelClientes.Controls.Add(label4);
            panelClientes.Controls.Add(label3);
            panelClientes.Location = new Point(35, 147);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new Size(532, 652);
            panelClientes.TabIndex = 3;
            // 
            // txtEmailClientes
            // 
            txtEmailClientes.BackColor = Color.FromArgb(214, 189, 151);
            txtEmailClientes.Location = new Point(173, 348);
            txtEmailClientes.Name = "txtEmailClientes";
            txtEmailClientes.Size = new Size(221, 27);
            txtEmailClientes.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(60, 42, 33);
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(287, 526);
            panel4.Name = "panel4";
            panel4.Size = new Size(61, 42);
            panel4.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(60, 42, 33);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(37, 526);
            panel3.Name = "panel3";
            panel3.Size = new Size(47, 42);
            panel3.TabIndex = 21;
            // 
            // btnEliminarClientes
            // 
            btnEliminarClientes.BackColor = Color.FromArgb(60, 42, 33);
            btnEliminarClientes.FlatStyle = FlatStyle.Flat;
            btnEliminarClientes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarClientes.ForeColor = Color.FromArgb(229, 190, 152);
            btnEliminarClientes.Location = new Point(282, 514);
            btnEliminarClientes.Name = "btnEliminarClientes";
            btnEliminarClientes.Size = new Size(228, 64);
            btnEliminarClientes.TabIndex = 18;
            btnEliminarClientes.Text = "ELIMINAR";
            btnEliminarClientes.UseVisualStyleBackColor = false;
            btnEliminarClientes.Click += btnEliminarClientes_Click;
            // 
            // btnGuardarClientes
            // 
            btnGuardarClientes.BackColor = Color.FromArgb(60, 42, 33);
            btnGuardarClientes.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuardarClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 60, 50);
            btnGuardarClientes.FlatStyle = FlatStyle.Flat;
            btnGuardarClientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarClientes.ForeColor = Color.FromArgb(229, 190, 152);
            btnGuardarClientes.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardarClientes.Location = new Point(24, 514);
            btnGuardarClientes.Name = "btnGuardarClientes";
            btnGuardarClientes.Size = new Size(223, 65);
            btnGuardarClientes.TabIndex = 17;
            btnGuardarClientes.Text = "GUARDAR";
            btnGuardarClientes.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGuardarClientes.UseVisualStyleBackColor = false;
            btnGuardarClientes.Click += btnGuardar_Click;
            // 
            // txtTelefonoClientes
            // 
            txtTelefonoClientes.BackColor = Color.FromArgb(214, 189, 151);
            txtTelefonoClientes.Location = new Point(173, 271);
            txtTelefonoClientes.Name = "txtTelefonoClientes";
            txtTelefonoClientes.Size = new Size(221, 27);
            txtTelefonoClientes.TabIndex = 11;
            // 
            // txtNombreClientes
            // 
            txtNombreClientes.BackColor = Color.FromArgb(214, 189, 151);
            txtNombreClientes.Location = new Point(173, 188);
            txtNombreClientes.Name = "txtNombreClientes";
            txtNombreClientes.Size = new Size(221, 27);
            txtNombreClientes.TabIndex = 10;
            // 
            // txtCedulaClientes
            // 
            txtCedulaClientes.BackColor = Color.FromArgb(214, 189, 151);
            txtCedulaClientes.Location = new Point(173, 90);
            txtCedulaClientes.Name = "txtCedulaClientes";
            txtCedulaClientes.Size = new Size(221, 27);
            txtCedulaClientes.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 352);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 7;
            label7.Text = "EMAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 188);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 5;
            label6.Text = "NOMBRE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 271);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 4;
            label5.Text = "TÉLEFONO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 90);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 3;
            label4.Text = "CÉDULA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 23);
            label3.Name = "label3";
            label3.Size = new Size(210, 23);
            label3.TabIndex = 2;
            label3.Text = "NUEVO CLIENTE / EDITAR";
            // 
            // pnlDgva
            // 
            pnlDgva.BackColor = Color.FromArgb(214, 189, 151);
            pnlDgva.BorderStyle = BorderStyle.FixedSingle;
            pnlDgva.Controls.Add(labelClientes);
            pnlDgva.Controls.Add(dgvGestionClientes);
            pnlDgva.Location = new Point(616, 147);
            pnlDgva.Name = "pnlDgva";
            pnlDgva.Size = new Size(761, 652);
            pnlDgva.TabIndex = 4;
            // 
            // labelClientes
            // 
            labelClientes.AutoSize = true;
            labelClientes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClientes.Location = new Point(42, 22);
            labelClientes.Name = "labelClientes";
            labelClientes.Size = new Size(180, 23);
            labelClientes.TabIndex = 1;
            labelClientes.Text = "LISTADO DE CLIENTES";
            // 
            // dgvGestionClientes
            // 
            dgvGestionClientes.BackgroundColor = Color.FromArgb(214, 189, 151);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(60, 42, 33);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(214, 189, 151);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGestionClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGestionClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(60, 42, 33);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(214, 189, 151);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGestionClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGestionClientes.GridColor = Color.FromArgb(214, 189, 151);
            dgvGestionClientes.Location = new Point(24, 61);
            dgvGestionClientes.Name = "dgvGestionClientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(60, 42, 33);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvGestionClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvGestionClientes.RowHeadersWidth = 51;
            dgvGestionClientes.Size = new Size(718, 566);
            dgvGestionClientes.TabIndex = 0;
            // 
            // FrmGestionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 15, 12);
            ClientSize = new Size(1422, 834);
            Controls.Add(pnlDgva);
            Controls.Add(panelClientes);
            Controls.Add(pnlTitl);
            Name = "FrmGestionClientes";
            Text = "FrmGestionClientes";
            pnlTitl.ResumeLayout(false);
            pnlTitl.PerformLayout();
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            pnlDgva.ResumeLayout(false);
            pnlDgva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestionClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitl;
        private Label lblCafeteria;
        private Panel panelll4;
        private Panel panelClientes;
        private Panel panel3;
        private Button btnEliminarClientes;
        private Button btnGuardarClientes;
        private TextBox txtTelefonoClientes;
        private TextBox txtNombreClientes;
        private TextBox txtCedulaClientes;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtEmailClientes;
        private Panel pnlDgva;
        private Label labelClientes;
        private DataGridView dgvGestionClientes;
        private Panel panel4;
    }
}