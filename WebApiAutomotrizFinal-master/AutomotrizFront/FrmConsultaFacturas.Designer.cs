namespace AutomotrizFront
{
    partial class FrmConsultaFacturas
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
            this.dgvConsultaFactura = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFH = new System.Windows.Forms.DateTimePicker();
            this.dtpFD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFactura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultaFactura
            // 
            this.dgvConsultaFactura.AllowUserToAddRows = false;
            this.dgvConsultaFactura.AllowUserToDeleteRows = false;
            this.dgvConsultaFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaFactura.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvConsultaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TCliente,
            this.ColFecha,
            this.ColFormaP,
            this.ColFormaEntrega});
            this.dgvConsultaFactura.Location = new System.Drawing.Point(159, 242);
            this.dgvConsultaFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvConsultaFactura.Name = "dgvConsultaFactura";
            this.dgvConsultaFactura.ReadOnly = true;
            this.dgvConsultaFactura.RowHeadersWidth = 51;
            this.dgvConsultaFactura.RowTemplate.Height = 24;
            this.dgvConsultaFactura.Size = new System.Drawing.Size(797, 291);
            this.dgvConsultaFactura.TabIndex = 17;
            this.dgvConsultaFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Column1";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // TCliente
            // 
            this.TCliente.HeaderText = "Tipo de Cliente";
            this.TCliente.MinimumWidth = 6;
            this.TCliente.Name = "TCliente";
            this.TCliente.ReadOnly = true;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha de Factura";
            this.ColFecha.MinimumWidth = 6;
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColFormaP
            // 
            this.ColFormaP.HeaderText = "Forma De Pago";
            this.ColFormaP.MinimumWidth = 6;
            this.ColFormaP.Name = "ColFormaP";
            this.ColFormaP.ReadOnly = true;
            // 
            // ColFormaEntrega
            // 
            this.ColFormaEntrega.HeaderText = "Forma de Entrega";
            this.ColFormaEntrega.MinimumWidth = 6;
            this.ColFormaEntrega.Name = "ColFormaEntrega";
            this.ColFormaEntrega.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpFH);
            this.groupBox1.Controls.Add(this.dtpFD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.lblNro);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(2, -146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(916, 368);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // dtpFH
            // 
            this.dtpFH.Location = new System.Drawing.Point(302, 286);
            this.dtpFH.Name = "dtpFH";
            this.dtpFH.Size = new System.Drawing.Size(250, 27);
            this.dtpFH.TabIndex = 21;
            // 
            // dtpFD
            // 
            this.dtpFD.Location = new System.Drawing.Point(302, 207);
            this.dtpFD.Name = "dtpFD";
            this.dtpFD.Size = new System.Drawing.Size(250, 27);
            this.dtpFD.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(162, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(582, 104);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(215, 27);
            this.dtpHasta.TabIndex = 16;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(157, 105);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(246, 27);
            this.dtpDesde.TabIndex = 15;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(722, 309);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(179, 42);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNro.Location = new System.Drawing.Point(178, 23);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(475, 23);
            this.lblNro.TabIndex = 6;
            this.lblNro.Text = "Ingresar Detalles de la Factura";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHasta.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaHasta.Location = new System.Drawing.Point(465, 102);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(111, 24);
            this.lblFechaHasta.TabIndex = 5;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDesde.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaDesde.Location = new System.Drawing.Point(43, 103);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(113, 24);
            this.lblFechaDesde.TabIndex = 4;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // FrmConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1078, 576);
            this.Controls.Add(this.dgvConsultaFactura);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaFacturas";
            this.Text = "FrmConsultaFacturas";
            this.Load += new System.EventHandler(this.FrmConsultaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFactura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvConsultaFactura;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TCliente;
        private DataGridViewTextBoxColumn ColFecha;
        private DataGridViewTextBoxColumn ColFormaP;
        private DataGridViewTextBoxColumn ColFormaEntrega;
        private GroupBox groupBox1;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Button btnConsultar;
        private Label lblNro;
        private Label lblFechaHasta;
        private Label lblFechaDesde;
        private DateTimePicker dtpFH;
        private DateTimePicker dtpFD;
        private Label label1;
        private Label label2;
    }
}