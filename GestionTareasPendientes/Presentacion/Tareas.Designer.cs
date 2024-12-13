namespace GestionTareasPendientes
{
    partial class frmTareas
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
            this.btnEliminar_Tarea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTodas_Tareas = new System.Windows.Forms.ListBox();
            this.btnAgregar_Tarea = new System.Windows.Forms.Button();
            this.txtCajaTareas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEliminar_Tarea
            // 
            this.btnEliminar_Tarea.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Tarea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar_Tarea.Location = new System.Drawing.Point(156, 324);
            this.btnEliminar_Tarea.Name = "btnEliminar_Tarea";
            this.btnEliminar_Tarea.Size = new System.Drawing.Size(167, 43);
            this.btnEliminar_Tarea.TabIndex = 17;
            this.btnEliminar_Tarea.Text = "Eliminar tarea";
            this.btnEliminar_Tarea.UseVisualStyleBackColor = true;
            this.btnEliminar_Tarea.Click += new System.EventHandler(this.btnEliminar_Tarea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Escriba una tarea:";
            // 
            // lstTodas_Tareas
            // 
            this.lstTodas_Tareas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTodas_Tareas.FormattingEnabled = true;
            this.lstTodas_Tareas.ItemHeight = 19;
            this.lstTodas_Tareas.Location = new System.Drawing.Point(21, 143);
            this.lstTodas_Tareas.Name = "lstTodas_Tareas";
            this.lstTodas_Tareas.Size = new System.Drawing.Size(458, 175);
            this.lstTodas_Tareas.TabIndex = 14;
            // 
            // btnAgregar_Tarea
            // 
            this.btnAgregar_Tarea.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar_Tarea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar_Tarea.Location = new System.Drawing.Point(156, 80);
            this.btnAgregar_Tarea.Name = "btnAgregar_Tarea";
            this.btnAgregar_Tarea.Size = new System.Drawing.Size(167, 43);
            this.btnAgregar_Tarea.TabIndex = 13;
            this.btnAgregar_Tarea.Text = "Agregar tarea";
            this.btnAgregar_Tarea.UseVisualStyleBackColor = true;
            this.btnAgregar_Tarea.Click += new System.EventHandler(this.btnAgregar_Tarea_Click);
            // 
            // txtCajaTareas
            // 
            this.txtCajaTareas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaTareas.Location = new System.Drawing.Point(21, 48);
            this.txtCajaTareas.Name = "txtCajaTareas";
            this.txtCajaTareas.Size = new System.Drawing.Size(458, 26);
            this.txtCajaTareas.TabIndex = 12;
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 372);
            this.Controls.Add(this.btnEliminar_Tarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTodas_Tareas);
            this.Controls.Add(this.btnAgregar_Tarea);
            this.Controls.Add(this.txtCajaTareas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTareas";
            this.Text = "Formulario de tareas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar_Tarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTodas_Tareas;
        private System.Windows.Forms.Button btnAgregar_Tarea;
        private System.Windows.Forms.TextBox txtCajaTareas;
    }
}

