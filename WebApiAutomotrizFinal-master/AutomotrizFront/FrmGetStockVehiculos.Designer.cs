namespace AutomotrizFront
{
    partial class FrmGetStockVehiculos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cboModelos = new System.Windows.Forms.ComboBox();
            this.dgvStockVehiculos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboMarcas);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.cboModelos);
            this.groupBox1.Location = new System.Drawing.Point(65, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1093, 292);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // cboMarcas
            // 
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(208, 148);
            this.cboMarcas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(227, 28);
            this.cboMarcas.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(6, 149);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(164, 24);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca del Vehiculo:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(208, 219);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(174, 43);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar por filtros";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModelo.Location = new System.Drawing.Point(6, 63);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(168, 24);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo de Vehiculo:";
            // 
            // cboModelos
            // 
            this.cboModelos.FormattingEnabled = true;
            this.cboModelos.Location = new System.Drawing.Point(208, 61);
            this.cboModelos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboModelos.Name = "cboModelos";
            this.cboModelos.Size = new System.Drawing.Size(227, 28);
            this.cboModelos.TabIndex = 0;
            // 
            // dgvStockVehiculos
            // 
            this.dgvStockVehiculos.AllowUserToAddRows = false;
            this.dgvStockVehiculos.AllowUserToDeleteRows = false;
            this.dgvStockVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockVehiculos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvStockVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColStock,
            this.ColMarca,
            this.ColModelo,
            this.ColColor});
            this.dgvStockVehiculos.Location = new System.Drawing.Point(65, 361);
            this.dgvStockVehiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStockVehiculos.Name = "dgvStockVehiculos";
            this.dgvStockVehiculos.ReadOnly = true;
            this.dgvStockVehiculos.RowHeadersWidth = 51;
            this.dgvStockVehiculos.RowTemplate.Height = 24;
            this.dgvStockVehiculos.Size = new System.Drawing.Size(973, 256);
            this.dgvStockVehiculos.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Column1";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.MinimumWidth = 6;
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio $";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColStock
            // 
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 6;
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            // 
            // ColMarca
            // 
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.MinimumWidth = 6;
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.ReadOnly = true;
            // 
            // ColModelo
            // 
            this.ColModelo.HeaderText = "Modelo";
            this.ColModelo.MinimumWidth = 6;
            this.ColModelo.Name = "ColModelo";
            this.ColModelo.ReadOnly = true;
            // 
            // ColColor
            // 
            this.ColColor.HeaderText = "Color";
            this.ColColor.MinimumWidth = 6;
            this.ColColor.Name = "ColColor";
            this.ColColor.ReadOnly = true;
            // 
            // FrmGetStockVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStockVehiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGetStockVehiculos";
            this.Text = "FrmGetStockVehiculos";
            this.Load += new System.EventHandler(this.FrmGetStockVehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cboMarcas;
        private Label lblMarca;
        private Button btnConsultar;
        private Label lblModelo;
        private ComboBox cboModelos;
        private DataGridView dgvStockVehiculos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColModelo;
        private DataGridViewTextBoxColumn ColColor;
    }
}