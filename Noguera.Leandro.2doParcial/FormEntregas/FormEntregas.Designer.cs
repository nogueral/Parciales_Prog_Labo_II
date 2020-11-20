namespace FormEntregas
{
    partial class FormEntregas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtvEnPreparacion = new System.Windows.Forms.DataGridView();
            this.dtvEntregados = new System.Windows.Forms.DataGridView();
            this.lblPedientes = new System.Windows.Forms.Label();
            this.lblEntregados = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarPedido = new System.Windows.Forms.Button();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.btnCantPedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEnPreparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEntregados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvEnPreparacion
            // 
            this.dtvEnPreparacion.AllowUserToAddRows = false;
            this.dtvEnPreparacion.AllowUserToDeleteRows = false;
            this.dtvEnPreparacion.AllowUserToResizeColumns = false;
            this.dtvEnPreparacion.AllowUserToResizeRows = false;
            this.dtvEnPreparacion.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtvEnPreparacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvEnPreparacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtvEnPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvEnPreparacion.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtvEnPreparacion.EnableHeadersVisualStyles = false;
            this.dtvEnPreparacion.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtvEnPreparacion.Location = new System.Drawing.Point(36, 53);
            this.dtvEnPreparacion.Name = "dtvEnPreparacion";
            this.dtvEnPreparacion.ReadOnly = true;
            this.dtvEnPreparacion.RowHeadersVisible = false;
            this.dtvEnPreparacion.RowHeadersWidth = 62;
            this.dtvEnPreparacion.RowTemplate.Height = 28;
            this.dtvEnPreparacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvEnPreparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvEnPreparacion.Size = new System.Drawing.Size(284, 338);
            this.dtvEnPreparacion.TabIndex = 0;
            // 
            // dtvEntregados
            // 
            this.dtvEntregados.AllowUserToAddRows = false;
            this.dtvEntregados.AllowUserToDeleteRows = false;
            this.dtvEntregados.AllowUserToResizeColumns = false;
            this.dtvEntregados.AllowUserToResizeRows = false;
            this.dtvEntregados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtvEntregados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvEntregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtvEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvEntregados.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtvEntregados.EnableHeadersVisualStyles = false;
            this.dtvEntregados.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtvEntregados.Location = new System.Drawing.Point(463, 53);
            this.dtvEntregados.Name = "dtvEntregados";
            this.dtvEntregados.ReadOnly = true;
            this.dtvEntregados.RowHeadersVisible = false;
            this.dtvEntregados.RowHeadersWidth = 62;
            this.dtvEntregados.RowTemplate.Height = 28;
            this.dtvEntregados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtvEntregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvEntregados.Size = new System.Drawing.Size(284, 338);
            this.dtvEntregados.TabIndex = 1;
            // 
            // lblPedientes
            // 
            this.lblPedientes.AutoSize = true;
            this.lblPedientes.Location = new System.Drawing.Point(32, 9);
            this.lblPedientes.Name = "lblPedientes";
            this.lblPedientes.Size = new System.Drawing.Size(180, 20);
            this.lblPedientes.TabIndex = 2;
            this.lblPedientes.Text = "Pedidos en preparacion:";
            // 
            // lblEntregados
            // 
            this.lblEntregados.AutoSize = true;
            this.lblEntregados.Location = new System.Drawing.Point(459, 9);
            this.lblEntregados.Name = "lblEntregados";
            this.lblEntregados.Size = new System.Drawing.Size(155, 20);
            this.lblEntregados.TabIndex = 3;
            this.lblEntregados.Text = "Pedidos entregados:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.Location = new System.Drawing.Point(613, 426);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 54);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarPedido
            // 
            this.btnCargarPedido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCargarPedido.Location = new System.Drawing.Point(447, 426);
            this.btnCargarPedido.Name = "btnCargarPedido";
            this.btnCargarPedido.Size = new System.Drawing.Size(134, 54);
            this.btnCargarPedido.TabIndex = 10;
            this.btnCargarPedido.Text = "Cargar Pedido";
            this.btnCargarPedido.UseVisualStyleBackColor = false;
            this.btnCargarPedido.Click += new System.EventHandler(this.btnCargarPedido_Click);
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(32, 426);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(70, 20);
            this.lblPedidos.TabIndex = 11;
            this.lblPedidos.Text = "Pedidos:";
            // 
            // btnCantPedidos
            // 
            this.btnCantPedidos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCantPedidos.Location = new System.Drawing.Point(447, 491);
            this.btnCantPedidos.Name = "btnCantPedidos";
            this.btnCantPedidos.Size = new System.Drawing.Size(300, 54);
            this.btnCantPedidos.TabIndex = 13;
            this.btnCantPedidos.Text = "Cantidad de pedidos por tipo";
            this.btnCantPedidos.UseVisualStyleBackColor = false;
            this.btnCantPedidos.Click += new System.EventHandler(this.btnCantPedidos_Click);
            // 
            // FormEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.btnCantPedidos);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.btnCargarPedido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEntregados);
            this.Controls.Add(this.lblPedientes);
            this.Controls.Add(this.dtvEntregados);
            this.Controls.Add(this.dtvEnPreparacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEntregas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEntregas_FormClosing);
            this.Load += new System.EventHandler(this.FormEntregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEnPreparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEntregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvEnPreparacion;
        private System.Windows.Forms.DataGridView dtvEntregados;
        private System.Windows.Forms.Label lblPedientes;
        private System.Windows.Forms.Label lblEntregados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarPedido;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Button btnCantPedidos;
    }
}

