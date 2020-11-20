namespace FormularioComercio
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.dgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvListaVentas = new System.Windows.Forms.DataGridView();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblVentasEmpleado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEmpleados
            // 
            this.dgvListaEmpleados.AllowUserToAddRows = false;
            this.dgvListaEmpleados.AllowUserToDeleteRows = false;
            this.dgvListaEmpleados.AllowUserToResizeColumns = false;
            this.dgvListaEmpleados.AllowUserToResizeRows = false;
            this.dgvListaEmpleados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaEmpleados.ColumnHeadersHeight = 40;
            this.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListaEmpleados.EnableHeadersVisualStyles = false;
            this.dgvListaEmpleados.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvListaEmpleados.Location = new System.Drawing.Point(12, 39);
            this.dgvListaEmpleados.Name = "dgvListaEmpleados";
            this.dgvListaEmpleados.ReadOnly = true;
            this.dgvListaEmpleados.RowHeadersVisible = false;
            this.dgvListaEmpleados.RowHeadersWidth = 72;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListaEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaEmpleados.RowTemplate.Height = 31;
            this.dgvListaEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEmpleados.Size = new System.Drawing.Size(1074, 150);
            this.dgvListaEmpleados.TabIndex = 0;
            this.dgvListaEmpleados.DoubleClick += new System.EventHandler(this.dgvListaEmpleados_DoubleClick);
            // 
            // dgvListaVentas
            // 
            this.dgvListaVentas.AllowUserToAddRows = false;
            this.dgvListaVentas.AllowUserToDeleteRows = false;
            this.dgvListaVentas.AllowUserToResizeColumns = false;
            this.dgvListaVentas.AllowUserToResizeRows = false;
            this.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaVentas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaVentas.ColumnHeadersHeight = 40;
            this.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListaVentas.EnableHeadersVisualStyles = false;
            this.dgvListaVentas.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvListaVentas.Location = new System.Drawing.Point(12, 263);
            this.dgvListaVentas.Name = "dgvListaVentas";
            this.dgvListaVentas.ReadOnly = true;
            this.dgvListaVentas.RowHeadersVisible = false;
            this.dgvListaVentas.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListaVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaVentas.RowTemplate.Height = 31;
            this.dgvListaVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVentas.Size = new System.Drawing.Size(1074, 217);
            this.dgvListaVentas.TabIndex = 1;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(12, 9);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(110, 27);
            this.lblEmpleado.TabIndex = 3;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblVentasEmpleado
            // 
            this.lblVentasEmpleado.AutoSize = true;
            this.lblVentasEmpleado.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasEmpleado.Location = new System.Drawing.Point(12, 216);
            this.lblVentasEmpleado.Name = "lblVentasEmpleado";
            this.lblVentasEmpleado.Size = new System.Drawing.Size(211, 27);
            this.lblVentasEmpleado.TabIndex = 4;
            this.lblVentasEmpleado.Text = "Ventas del empleado:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.Font = new System.Drawing.Font("Open Sans", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(985, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 58);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1342, 660);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblVentasEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.dgvListaVentas);
            this.Controls.Add(this.dgvListaEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEmpleados;
        private System.Windows.Forms.DataGridView dgvListaVentas;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblVentasEmpleado;
        private System.Windows.Forms.Button btnSalir;
    }
}