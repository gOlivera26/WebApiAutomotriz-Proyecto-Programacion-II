namespace AutomotrizFront
{
    partial class frmClientes
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
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.lblHero = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnConsultarFiltro = new System.Windows.Forms.Button();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarTodos.Location = new System.Drawing.Point(491, 635);
            this.btnConsultarTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(251, 53);
            this.btnConsultarTodos.TabIndex = 12;
            this.btnConsultarTodos.Text = "Consultar Todos";
            this.btnConsultarTodos.UseVisualStyleBackColor = true;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // lblHero
            // 
            this.lblHero.AutoSize = true;
            this.lblHero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHero.Location = new System.Drawing.Point(502, 77);
            this.lblHero.Name = "lblHero";
            this.lblHero.Size = new System.Drawing.Size(172, 25);
            this.lblHero.TabIndex = 15;
            this.lblHero.Text = "Consultar Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColApellido,
            this.ColBarrio,
            this.ColCalle,
            this.ColAltura,
            this.ColNroDoc,
            this.ColTelefono});
            this.dgvClientes.Location = new System.Drawing.Point(147, 422);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(971, 205);
            this.dgvClientes.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.btnConsultarFiltro);
            this.groupBox1.Location = new System.Drawing.Point(260, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(754, 240);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Busqueda";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(156, 170);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(217, 28);
            this.cboTipo.TabIndex = 15;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(156, 114);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(217, 27);
            this.txtDni.TabIndex = 14;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(509, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(213, 27);
            this.txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 27);
            this.txtNombre.TabIndex = 12;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(6, 173);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(143, 25);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo de Cliente:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(412, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(91, 25);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(77, 113);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(60, 25);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "D.N.I :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(47, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 25);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre :";
            // 
            // btnConsultarFiltro
            // 
            this.btnConsultarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarFiltro.Location = new System.Drawing.Point(526, 139);
            this.btnConsultarFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultarFiltro.Name = "btnConsultarFiltro";
            this.btnConsultarFiltro.Size = new System.Drawing.Size(178, 59);
            this.btnConsultarFiltro.TabIndex = 6;
            this.btnConsultarFiltro.Text = "Consultar ";
            this.btnConsultarFiltro.UseVisualStyleBackColor = true;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ColID";
            this.ColID.MinimumWidth = 10;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColNombre
            // 
            this.ColNombre.FillWeight = 107.3084F;
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColApellido
            // 
            this.ColApellido.FillWeight = 107.3084F;
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.MinimumWidth = 6;
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            // 
            // ColBarrio
            // 
            this.ColBarrio.FillWeight = 107.3084F;
            this.ColBarrio.HeaderText = "Barrio";
            this.ColBarrio.MinimumWidth = 6;
            this.ColBarrio.Name = "ColBarrio";
            this.ColBarrio.ReadOnly = true;
            // 
            // ColCalle
            // 
            this.ColCalle.FillWeight = 107.3084F;
            this.ColCalle.HeaderText = "Calle";
            this.ColCalle.MinimumWidth = 6;
            this.ColCalle.Name = "ColCalle";
            this.ColCalle.ReadOnly = true;
            // 
            // ColAltura
            // 
            this.ColAltura.FillWeight = 56.14973F;
            this.ColAltura.HeaderText = "Altura";
            this.ColAltura.MinimumWidth = 15;
            this.ColAltura.Name = "ColAltura";
            this.ColAltura.ReadOnly = true;
            // 
            // ColNroDoc
            // 
            this.ColNroDoc.FillWeight = 107.3084F;
            this.ColNroDoc.HeaderText = "Documento";
            this.ColNroDoc.MinimumWidth = 6;
            this.ColNroDoc.Name = "ColNroDoc";
            this.ColNroDoc.ReadOnly = true;
            // 
            // ColTelefono
            // 
            this.ColTelefono.FillWeight = 107.3084F;
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.MinimumWidth = 6;
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 762);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.lblHero);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClientes";
            this.Text = "Busqueda de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConsultarTodos;
        private Label lblHero;
        private DataGridView dgvClientes;
        private GroupBox groupBox1;
        private ComboBox cboTipo;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblTipo;
        private Label lblApellido;
        private Label lblDni;
        private Label lblNombre;
        private Button btnConsultarFiltro;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn ColCalle;
        private DataGridViewTextBoxColumn ColAltura;
        private DataGridViewTextBoxColumn ColNroDoc;
        private DataGridViewTextBoxColumn ColTelefono;
    }
}