namespace TareasEquipoDesarrollo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        // Otros elementos del formulario ya definidos

        private void InitializeComponent()
        {
            lblNombreTarea = new Label();
            txtNombreTarea = new TextBox();
            lblDuracion = new Label();
            txtDuracion = new TextBox();
            lblPorcentajeAvance = new Label();
            txtPorcentajeAvance = new TextBox();
            lblProgramadorAsignado = new Label();
            txtProgramadorAsignado = new TextBox();
            btnAgregarTarea = new Button();
            btnEliminarTarea = new Button();
            listBoxTareas = new ListBox();
            lblBuscarPorNombre = new Label();
            txtBuscarPorNombre = new TextBox();
            btnBuscarPorNombre = new Button();
            SuspendLayout();
            // 
            // lblNombreTarea
            // 
            lblNombreTarea.AutoSize = true;
            lblNombreTarea.Location = new Point(14, 17);
            lblNombreTarea.Margin = new Padding(4, 0, 4, 0);
            lblNombreTarea.Name = "lblNombreTarea";
            lblNombreTarea.Size = new Size(96, 15);
            lblNombreTarea.TabIndex = 0;
            lblNombreTarea.Text = "Nombre de tarea";
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(135, 14);
            txtNombreTarea.Margin = new Padding(4, 3, 4, 3);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.Size = new Size(181, 23);
            txtNombreTarea.TabIndex = 1;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(14, 47);
            lblDuracion.Margin = new Padding(4, 0, 4, 0);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(55, 15);
            lblDuracion.TabIndex = 2;
            lblDuracion.Text = "Duración";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(135, 44);
            txtDuracion.Margin = new Padding(4, 3, 4, 3);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(181, 23);
            txtDuracion.TabIndex = 3;
            // 
            // lblPorcentajeAvance
            // 
            lblPorcentajeAvance.AutoSize = true;
            lblPorcentajeAvance.Location = new Point(14, 77);
            lblPorcentajeAvance.Margin = new Padding(4, 0, 4, 0);
            lblPorcentajeAvance.Name = "lblPorcentajeAvance";
            lblPorcentajeAvance.Size = new Size(105, 15);
            lblPorcentajeAvance.TabIndex = 4;
            lblPorcentajeAvance.Text = "Porcentaje Avance";
            // 
            // txtPorcentajeAvance
            // 
            txtPorcentajeAvance.Location = new Point(135, 74);
            txtPorcentajeAvance.Margin = new Padding(4, 3, 4, 3);
            txtPorcentajeAvance.Name = "txtPorcentajeAvance";
            txtPorcentajeAvance.Size = new Size(181, 23);
            txtPorcentajeAvance.TabIndex = 5;
            // 
            // lblProgramadorAsignado
            // 
            lblProgramadorAsignado.AutoSize = true;
            lblProgramadorAsignado.Location = new Point(14, 107);
            lblProgramadorAsignado.Margin = new Padding(4, 0, 4, 0);
            lblProgramadorAsignado.Name = "lblProgramadorAsignado";
            lblProgramadorAsignado.Size = new Size(130, 15);
            lblProgramadorAsignado.TabIndex = 6;
            lblProgramadorAsignado.Text = "Programador Asignado";
            // 
            // txtProgramadorAsignado
            // 
            txtProgramadorAsignado.Location = new Point(135, 104);
            txtProgramadorAsignado.Margin = new Padding(4, 3, 4, 3);
            txtProgramadorAsignado.Name = "txtProgramadorAsignado";
            txtProgramadorAsignado.Size = new Size(181, 23);
            txtProgramadorAsignado.TabIndex = 7;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.Location = new Point(18, 134);
            btnAgregarTarea.Margin = new Padding(4, 3, 4, 3);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(140, 27);
            btnAgregarTarea.TabIndex = 8;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Location = new Point(164, 134);
            btnEliminarTarea.Margin = new Padding(4, 3, 4, 3);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(140, 27);
            btnEliminarTarea.TabIndex = 9;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // listBoxTareas
            // 
            listBoxTareas.FormattingEnabled = true;
            listBoxTareas.ItemHeight = 15;
            listBoxTareas.Location = new Point(18, 167);
            listBoxTareas.Margin = new Padding(4, 3, 4, 3);
            listBoxTareas.Name = "listBoxTareas";
            listBoxTareas.Size = new Size(286, 109);
            listBoxTareas.TabIndex = 10;
            // 
            // lblBuscarPorNombre
            // 
            lblBuscarPorNombre.AutoSize = true;
            lblBuscarPorNombre.Location = new Point(14, 288);
            lblBuscarPorNombre.Margin = new Padding(4, 0, 4, 0);
            lblBuscarPorNombre.Name = "lblBuscarPorNombre";
            lblBuscarPorNombre.Size = new Size(113, 15);
            lblBuscarPorNombre.TabIndex = 11;
            lblBuscarPorNombre.Text = "Buscar por Nombre:";
            // 
            // txtBuscarPorNombre
            // 
            txtBuscarPorNombre.Location = new Point(144, 285);
            txtBuscarPorNombre.Margin = new Padding(4, 3, 4, 3);
            txtBuscarPorNombre.Name = "txtBuscarPorNombre";
            txtBuscarPorNombre.Size = new Size(160, 23);
            txtBuscarPorNombre.TabIndex = 12;
            // 
            // btnBuscarPorNombre
            // 
            btnBuscarPorNombre.Location = new Point(18, 315);
            btnBuscarPorNombre.Margin = new Padding(4, 3, 4, 3);
            btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            btnBuscarPorNombre.Size = new Size(140, 27);
            btnBuscarPorNombre.TabIndex = 13;
            btnBuscarPorNombre.Text = "Buscar";
            btnBuscarPorNombre.UseVisualStyleBackColor = true;
            btnBuscarPorNombre.Click += btnBuscarPorNombre_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 480);
            Controls.Add(listBoxTareas);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtProgramadorAsignado);
            Controls.Add(lblProgramadorAsignado);
            Controls.Add(txtPorcentajeAvance);
            Controls.Add(lblPorcentajeAvance);
            Controls.Add(txtDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(txtNombreTarea);
            Controls.Add(lblNombreTarea);
            Controls.Add(lblBuscarPorNombre);
            Controls.Add(txtBuscarPorNombre);
            Controls.Add(btnBuscarPorNombre);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Gestión de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.TextBox txtNombreTarea;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblPorcentajeAvance;
        private System.Windows.Forms.TextBox txtPorcentajeAvance;
        private System.Windows.Forms.Label lblProgramadorAsignado;
        private System.Windows.Forms.TextBox txtProgramadorAsignado;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.ListBox listBoxTareas;
        private System.Windows.Forms.Label lblBuscarPorNombre;
        private System.Windows.Forms.TextBox txtBuscarPorNombre;
        private System.Windows.Forms.Button btnBuscarPorNombre;


    }
    #endregion
}
