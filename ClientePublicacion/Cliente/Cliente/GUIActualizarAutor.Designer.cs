﻿namespace Cliente
{
    partial class GUIActualizarAutor
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
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombreBuscado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAgregarAutor = new System.Windows.Forms.Label();
            this.btnActualizarAutor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegalias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.Location = new System.Drawing.Point(281, 79);
            this.btnBuscarAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(106, 32);
            this.btnBuscarAutor.TabIndex = 31;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Autor...";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 149);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 20);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(125, 211);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(262, 20);
            this.txtNacionalidad.TabIndex = 27;
            this.txtNacionalidad.TextChanged += new System.EventHandler(this.txtNacionalidad_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(125, 179);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(262, 20);
            this.txtEdad.TabIndex = 26;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(9, 209);
            this.lblNacionalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(112, 18);
            this.lblNacionalidad.TabIndex = 25;
            this.lblNacionalidad.Text = "Nacionalidad";
            this.lblNacionalidad.Click += new System.EventHandler(this.lblNacionalidad_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(11, 179);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(49, 18);
            this.lblEdad.TabIndex = 24;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Click += new System.EventHandler(this.lblEdad_Click);
            // 
            // txtNombreBuscado
            // 
            this.txtNombreBuscado.Location = new System.Drawing.Point(160, 45);
            this.txtNombreBuscado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreBuscado.Name = "txtNombreBuscado";
            this.txtNombreBuscado.Size = new System.Drawing.Size(227, 20);
            this.txtNombreBuscado.TabIndex = 23;
            this.txtNombreBuscado.TextChanged += new System.EventHandler(this.txtNombreBuscado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre Buscado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAgregarAutor
            // 
            this.lblAgregarAutor.AutoSize = true;
            this.lblAgregarAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarAutor.Location = new System.Drawing.Point(10, 7);
            this.lblAgregarAutor.Name = "lblAgregarAutor";
            this.lblAgregarAutor.Size = new System.Drawing.Size(201, 28);
            this.lblAgregarAutor.TabIndex = 21;
            this.lblAgregarAutor.Text = "Actualizar Autor";
            this.lblAgregarAutor.Click += new System.EventHandler(this.lblAgregarAutor_Click);
            // 
            // btnActualizarAutor
            // 
            this.btnActualizarAutor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAutor.Location = new System.Drawing.Point(281, 308);
            this.btnActualizarAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarAutor.Name = "btnActualizarAutor";
            this.btnActualizarAutor.Size = new System.Drawing.Size(106, 32);
            this.btnActualizarAutor.TabIndex = 32;
            this.btnActualizarAutor.Text = "Actualizar";
            this.btnActualizarAutor.UseVisualStyleBackColor = true;
            this.btnActualizarAutor.Click += new System.EventHandler(this.btnActualizarAutor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "%";
            // 
            // txtRegalias
            // 
            this.txtRegalias.Location = new System.Drawing.Point(202, 241);
            this.txtRegalias.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegalias.Name = "txtRegalias";
            this.txtRegalias.Size = new System.Drawing.Size(159, 20);
            this.txtRegalias.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Porcentaje en regalías";
            // 
            // dpFecha
            // 
            this.dpFecha.Location = new System.Drawing.Point(191, 271);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(200, 20);
            this.dpFecha.TabIndex = 33;
            // 
            // GUIActualizarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegalias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.btnActualizarAutor);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtNombreBuscado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgregarAutor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUIActualizarAutor";
            this.Text = "Actualizar autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombreBuscado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgregarAutor;
        private System.Windows.Forms.Button btnActualizarAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegalias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpFecha;
    }
}