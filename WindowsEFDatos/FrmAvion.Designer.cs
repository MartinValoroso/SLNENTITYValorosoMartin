namespace WindowsEFDatos
{
    partial class FrmAvion
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
            this.lblAvionId = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.GridAvion = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.lblDenominacion = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtLineaId = new System.Windows.Forms.TextBox();
            this.lblLinea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvionId
            // 
            this.lblAvionId.AutoSize = true;
            this.lblAvionId.Location = new System.Drawing.Point(183, 59);
            this.lblAvionId.Name = "lblAvionId";
            this.lblAvionId.Size = new System.Drawing.Size(137, 37);
            this.lblAvionId.TabIndex = 0;
            this.lblAvionId.Text = "Avion ID";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(183, 119);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(171, 37);
            this.lblCapacidad.TabIndex = 1;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(733, 44);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(297, 96);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // GridAvion
            // 
            this.GridAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAvion.Location = new System.Drawing.Point(190, 383);
            this.GridAvion.Name = "GridAvion";
            this.GridAvion.RowHeadersWidth = 123;
            this.GridAvion.RowTemplate.Height = 46;
            this.GridAvion.Size = new System.Drawing.Size(828, 415);
            this.GridAvion.TabIndex = 3;
            this.GridAvion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAvion_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(411, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(304, 44);
            this.txtId.TabIndex = 4;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(411, 112);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(304, 44);
            this.txtCapacidad.TabIndex = 5;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(411, 173);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(304, 44);
            this.txtDenominacion.TabIndex = 6;
            // 
            // lblDenominacion
            // 
            this.lblDenominacion.AutoSize = true;
            this.lblDenominacion.Location = new System.Drawing.Point(172, 176);
            this.lblDenominacion.Name = "lblDenominacion";
            this.lblDenominacion.Size = new System.Drawing.Size(222, 37);
            this.lblDenominacion.TabIndex = 7;
            this.lblDenominacion.Text = "Denominacion";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(733, 146);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(297, 96);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(733, 248);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(297, 96);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1036, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(297, 96);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "BUSCAR POR ID";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtLineaId
            // 
            this.txtLineaId.Location = new System.Drawing.Point(411, 238);
            this.txtLineaId.Name = "txtLineaId";
            this.txtLineaId.Size = new System.Drawing.Size(304, 44);
            this.txtLineaId.TabIndex = 11;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(239, 241);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(150, 37);
            this.lblLinea.TabIndex = 12;
            this.lblLinea.Text = "LINEA ID";
            // 
            // FrmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 810);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.txtLineaId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblDenominacion);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.GridAvion);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblAvionId);
            this.Name = "FrmAvion";
            this.Text = "FrmAvion";
            this.Load += new System.EventHandler(this.FrmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAvion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvionId;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView GridAvion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.Label lblDenominacion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtLineaId;
        private System.Windows.Forms.Label lblLinea;
    }
}