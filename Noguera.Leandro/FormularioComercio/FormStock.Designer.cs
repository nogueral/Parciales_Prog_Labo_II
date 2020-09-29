namespace FormularioComercio
{
    partial class FormStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.lblEncabezadoStock = new System.Windows.Forms.Label();
            this.lblStockTotal = new System.Windows.Forms.Label();
            this.dgvStockProductos = new System.Windows.Forms.DataGridView();
            this.lblEncabezadoDgv = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnStockTotal = new System.Windows.Forms.Button();
            this.btnStockParcial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEncabezadoStock
            // 
            this.lblEncabezadoStock.AutoSize = true;
            this.lblEncabezadoStock.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezadoStock.Location = new System.Drawing.Point(37, 52);
            this.lblEncabezadoStock.Name = "lblEncabezadoStock";
            this.lblEncabezadoStock.Size = new System.Drawing.Size(242, 27);
            this.lblEncabezadoStock.TabIndex = 2;
            this.lblEncabezadoStock.Text = "Stock total de productos:";
            // 
            // lblStockTotal
            // 
            this.lblStockTotal.AutoSize = true;
            this.lblStockTotal.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTotal.Location = new System.Drawing.Point(285, 52);
            this.lblStockTotal.Name = "lblStockTotal";
            this.lblStockTotal.Size = new System.Drawing.Size(107, 27);
            this.lblStockTotal.TabIndex = 3;
            this.lblStockTotal.Text = "(Cantidad)";
            // 
            // dgvStockProductos
            // 
            this.dgvStockProductos.AllowUserToAddRows = false;
            this.dgvStockProductos.AllowUserToDeleteRows = false;
            this.dgvStockProductos.AllowUserToResizeColumns = false;
            this.dgvStockProductos.AllowUserToResizeRows = false;
            this.dgvStockProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStockProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockProductos.ColumnHeadersHeight = 40;
            this.dgvStockProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockProductos.EnableHeadersVisualStyles = false;
            this.dgvStockProductos.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvStockProductos.Location = new System.Drawing.Point(42, 164);
            this.dgvStockProductos.Name = "dgvStockProductos";
            this.dgvStockProductos.ReadOnly = true;
            this.dgvStockProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockProductos.RowHeadersVisible = false;
            this.dgvStockProductos.RowHeadersWidth = 72;
            this.dgvStockProductos.RowTemplate.Height = 31;
            this.dgvStockProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockProductos.Size = new System.Drawing.Size(911, 248);
            this.dgvStockProductos.TabIndex = 0;
            // 
            // lblEncabezadoDgv
            // 
            this.lblEncabezadoDgv.AutoSize = true;
            this.lblEncabezadoDgv.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezadoDgv.Location = new System.Drawing.Point(37, 108);
            this.lblEncabezadoDgv.Name = "lblEncabezadoDgv";
            this.lblEncabezadoDgv.Size = new System.Drawing.Size(447, 27);
            this.lblEncabezadoDgv.TabIndex = 4;
            this.lblEncabezadoDgv.Text = "Productos con menos de 10 unidades en stock:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(852, 435);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 56);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnStockTotal
            // 
            this.btnStockTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStockTotal.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockTotal.Location = new System.Drawing.Point(596, 435);
            this.btnStockTotal.Name = "btnStockTotal";
            this.btnStockTotal.Size = new System.Drawing.Size(224, 56);
            this.btnStockTotal.TabIndex = 5;
            this.btnStockTotal.Text = "Total de productos";
            this.btnStockTotal.UseVisualStyleBackColor = false;
            this.btnStockTotal.Click += new System.EventHandler(this.btnStockTotal_Click);
            // 
            // btnStockParcial
            // 
            this.btnStockParcial.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStockParcial.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockParcial.Location = new System.Drawing.Point(290, 435);
            this.btnStockParcial.Name = "btnStockParcial";
            this.btnStockParcial.Size = new System.Drawing.Size(284, 56);
            this.btnStockParcial.TabIndex = 6;
            this.btnStockParcial.Text = "Stock menor a 10 unidades";
            this.btnStockParcial.UseVisualStyleBackColor = false;
            this.btnStockParcial.Click += new System.EventHandler(this.btnStockParcial_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 503);
            this.Controls.Add(this.btnStockParcial);
            this.Controls.Add(this.btnStockTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEncabezadoDgv);
            this.Controls.Add(this.dgvStockProductos);
            this.Controls.Add(this.lblStockTotal);
            this.Controls.Add(this.lblEncabezadoStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock disponible";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEncabezadoStock;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.DataGridView dgvStockProductos;
        private System.Windows.Forms.Label lblEncabezadoDgv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnStockTotal;
        private System.Windows.Forms.Button btnStockParcial;
    }
}