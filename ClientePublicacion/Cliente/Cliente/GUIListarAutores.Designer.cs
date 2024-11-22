namespace Cliente
{
    partial class GUIListarAutores
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
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrarNacionalidad = new System.Windows.Forms.Button();
            this.tablaAutores = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblBuscarLibro = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(423, 256);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(111, 20);
            this.txtNacionalidad.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nacionalidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filtrarNacionalidad
            // 
            this.filtrarNacionalidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarNacionalidad.Location = new System.Drawing.Point(545, 251);
            this.filtrarNacionalidad.Name = "filtrarNacionalidad";
            this.filtrarNacionalidad.Size = new System.Drawing.Size(73, 27);
            this.filtrarNacionalidad.TabIndex = 22;
            this.filtrarNacionalidad.Text = "Aplicar";
            this.filtrarNacionalidad.UseVisualStyleBackColor = true;
            this.filtrarNacionalidad.Click += new System.EventHandler(this.filtrarNacionalidad_Click);
            // 
            // tablaAutores
            // 
            this.tablaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAutores.Location = new System.Drawing.Point(18, 54);
            this.tablaAutores.Name = "tablaAutores";
            this.tablaAutores.RowHeadersWidth = 51;
            this.tablaAutores.Size = new System.Drawing.Size(680, 190);
            this.tablaAutores.TabIndex = 21;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(633, 250);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(65, 28);
            this.btnListar.TabIndex = 20;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblBuscarLibro
            // 
            this.lblBuscarLibro.AutoSize = true;
            this.lblBuscarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarLibro.Location = new System.Drawing.Point(13, 10);
            this.lblBuscarLibro.Name = "lblBuscarLibro";
            this.lblBuscarLibro.Size = new System.Drawing.Size(176, 28);
            this.lblBuscarLibro.TabIndex = 19;
            this.lblBuscarLibro.Text = "Listar Autores";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(69, 256);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(111, 20);
            this.txtEdad.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Edad:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 27);
            this.button1.TabIndex = 27;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUIListarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtrarNacionalidad);
            this.Controls.Add(this.tablaAutores);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblBuscarLibro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUIListarAutores";
            this.Text = "Listar Autores";
            ((System.ComponentModel.ISupportInitialize)(this.tablaAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filtrarNacionalidad;
        private System.Windows.Forms.DataGridView tablaAutores;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblBuscarLibro;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}