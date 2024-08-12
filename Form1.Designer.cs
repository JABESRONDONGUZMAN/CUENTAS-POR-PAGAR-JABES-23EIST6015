namespace CUENTAS_POR_PAGAR_JABES_23EIST6015
{
    partial class FINICIO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TUSUARIO = new System.Windows.Forms.TextBox();
            this.TCLAVE = new System.Windows.Forms.TextBox();
            this.BENTRAR = new System.Windows.Forms.Button();
            this.DAGVUSUARIOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DAGVUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCRIBA EL NOMBRE DE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ESCRIBA LA CONTRASEÑA";
            // 
            // TUSUARIO
            // 
            this.TUSUARIO.Location = new System.Drawing.Point(246, 29);
            this.TUSUARIO.Name = "TUSUARIO";
            this.TUSUARIO.Size = new System.Drawing.Size(122, 22);
            this.TUSUARIO.TabIndex = 2;
            this.TUSUARIO.TextChanged += new System.EventHandler(this.TUSUARIO_TextChanged);
            // 
            // TCLAVE
            // 
            this.TCLAVE.Location = new System.Drawing.Point(246, 72);
            this.TCLAVE.Name = "TCLAVE";
            this.TCLAVE.Size = new System.Drawing.Size(122, 22);
            this.TCLAVE.TabIndex = 3;
            this.TCLAVE.TextChanged += new System.EventHandler(this.TCLAVE_TextChanged);
            // 
            // BENTRAR
            // 
            this.BENTRAR.Location = new System.Drawing.Point(119, 115);
            this.BENTRAR.Name = "BENTRAR";
            this.BENTRAR.Size = new System.Drawing.Size(135, 23);
            this.BENTRAR.TabIndex = 4;
            this.BENTRAR.Text = "ENTRAR";
            this.BENTRAR.UseVisualStyleBackColor = true;
            this.BENTRAR.Click += new System.EventHandler(this.BENTRAR_Click);
            // 
            // DAGVUSUARIOS
            // 
            this.DAGVUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DAGVUSUARIOS.Location = new System.Drawing.Point(15, 144);
            this.DAGVUSUARIOS.Name = "DAGVUSUARIOS";
            this.DAGVUSUARIOS.RowHeadersWidth = 51;
            this.DAGVUSUARIOS.RowTemplate.Height = 24;
            this.DAGVUSUARIOS.Size = new System.Drawing.Size(359, 150);
            this.DAGVUSUARIOS.TabIndex = 5;
            this.DAGVUSUARIOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DAGVUSUARIOS_CellContentClick);
            // 
            // FINICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 301);
            this.Controls.Add(this.DAGVUSUARIOS);
            this.Controls.Add(this.BENTRAR);
            this.Controls.Add(this.TCLAVE);
            this.Controls.Add(this.TUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FINICIO";
            this.Text = "INICIO DE SESION";
            this.Load += new System.EventHandler(this.FINICIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DAGVUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TUSUARIO;
        private System.Windows.Forms.TextBox TCLAVE;
        private System.Windows.Forms.Button BENTRAR;
        private System.Windows.Forms.DataGridView DAGVUSUARIOS;
    }
}

