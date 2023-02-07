namespace AutomotrizFront
{
    partial class FrmGetStockAutopartes
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
            this.dgvStockAutopartes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultarAutoparteFiltro = new System.Windows.Forms.Button();
            this.cboMarcas = new System.Windows.Forms.ComboBox();
            this.cboModelos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModeloAutoparte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockAutopartes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockAutopartes
            // 
            this.dgvStockAutopartes.AllowUserToAddRows = false;
            this.dgvStockAutopartes.AllowUserToDeleteRows = false;
            this.dgvStockAutopartes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockAutopartes.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvStockAutopartes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockAutopartes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ColDescripcion,
            this.ColPrecio,
            this.ColStock,
            this.ColMarca,
            this.ColModelo});
            this.dgvStockAutopartes.Location = new System.Drawing.Point(158, 356);
            this.dgvStockAutopartes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStockAutopartes.Name = "dgvStockAutopartes";
            this.dgvStockAutopartes.ReadOnly = true;
            this.dgvStockAutopartes.RowHeadersWidth = 51;
            this.dgvStockAutopartes.RowTemplate.Height = 24;
            this.dgvStockAutopartes.Size = new System.Drawing.Size(754, 205);
            this.dgvStockAutopartes.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.HeaderText = "ColID";
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
            this.ColPrecio.HeaderText = "Precio Unitario $";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.btnConsultarAutoparteFiltro);
            this.groupBox1.Controls.Add(this.cboMarcas);
            this.groupBox1.Controls.Add(this.cboModelos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblModeloAutoparte);
            this.groupBox1.Location = new System.Drawing.Point(158, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(754, 240);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // btnConsultarAutoparteFiltro
            // 
            this.btnConsultarAutoparteFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarAutoparteFiltro.Location = new System.Drawing.Point(526, 188);
            this.btnConsultarAutoparteFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarAutoparteFiltro.Name = "btnConsultarAutoparteFiltro";
            this.btnConsultarAutoparteFiltro.Size = new System.Drawing.Size(145, 44);
            this.btnConsultarAutoparteFiltro.TabIndex = 6;
            this.btnConsultarAutoparteFiltro.Text = "Consultar ";
            this.btnConsultarAutoparteFiltro.UseVisualStyleBackColor = true;
            this.btnConsultarAutoparteFiltro.Click += new System.EventHandler(this.btnConsultarAutoparteFiltro_Click);
            // 
            // cboMarcas
            // 
            this.cboMarcas.FormattingEnabled = true;
            this.cboMarcas.Location = new System.Drawing.Point(200, 149);
            this.cboMarcas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMarcas.Name = "cboMarcas";
            this.cboMarcas.Size = new System.Drawing.Size(214, 28);
            this.cboMarcas.TabIndex = 5;
            // 
            // cboModelos
            // 
            this.cboModelos.FormattingEnabled = true;
            this.cboModelos.Location = new System.Drawing.Point(200, 76);
            this.cboModelos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboModelos.Name = "cboModelos";
            this.cboModelos.Size = new System.Drawing.Size(214, 28);
            this.cboModelos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca de Autoparte:";
            // 
            // lblModeloAutoparte
            // 
            this.lblModeloAutoparte.AutoSize = true;
            this.lblModeloAutoparte.BackColor = System.Drawing.Color.Transparent;
            this.lblModeloAutoparte.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModeloAutoparte.Location = new System.Drawing.Point(15, 77);
            this.lblModeloAutoparte.Name = "lblModeloAutoparte";
            this.lblModeloAutoparte.Size = new System.Drawing.Size(179, 24);
            this.lblModeloAutoparte.TabIndex = 2;
            this.lblModeloAutoparte.Text = "Modelo de Autoparte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(400, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Consultar Disponibilidad autopartes";
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarTodos.Location = new System.Drawing.Point(420, 581);
            this.btnConsultarTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(188, 50);
            this.btnConsultarTodos.TabIndex = 7;
            this.btnConsultarTodos.Text = "Consultar Todos";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // FrmGetStockAutopartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1068, 674);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStockAutopartes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGetStockAutopartes";
            this.Text = "FrmGetStockAutopartes";
            this.Load += new System.EventHandler(this.FrmGetStockAutopartes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockAutopartes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvStockAutopartes;
        private GroupBox groupBox1;
        private Button btnConsultarAutoparteFiltro;
        private ComboBox cboMarcas;
        private ComboBox cboModelos;
        private Label label1;
        private Label lblModeloAutoparte;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColMarca;
        private DataGridViewTextBoxColumn ColModelo;
        private Label label2;
        private Button btnConsultarTodos;
    }
}