namespace TareaDetalles.UI.Registros
{
    partial class RegistroEstudiantes
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EstudianteIdtextBox = new System.Windows.Forms.TextBox();
            this.NombreEstudiantetextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.EstudiantesdataGridView = new System.Windows.Forms.DataGridView();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.EstudianteIderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreEstudianteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreEstudianteerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Estudiante:";
            // 
            // EstudianteIdtextBox
            // 
            this.EstudianteIdtextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteIdtextBox.Location = new System.Drawing.Point(218, 44);
            this.EstudianteIdtextBox.Multiline = true;
            this.EstudianteIdtextBox.Name = "EstudianteIdtextBox";
            this.EstudianteIdtextBox.Size = new System.Drawing.Size(57, 31);
            this.EstudianteIdtextBox.TabIndex = 2;
            // 
            // NombreEstudiantetextBox
            // 
            this.NombreEstudiantetextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEstudiantetextBox.Location = new System.Drawing.Point(218, 91);
            this.NombreEstudiantetextBox.Multiline = true;
            this.NombreEstudiantetextBox.Name = "NombreEstudiantetextBox";
            this.NombreEstudiantetextBox.Size = new System.Drawing.Size(357, 31);
            this.NombreEstudiantetextBox.TabIndex = 3;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Location = new System.Drawing.Point(355, 34);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(87, 41);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // EstudiantesdataGridView
            // 
            this.EstudiantesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstudiantesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesdataGridView.Location = new System.Drawing.Point(43, 158);
            this.EstudiantesdataGridView.Name = "EstudiantesdataGridView";
            this.EstudiantesdataGridView.RowTemplate.Height = 24;
            this.EstudiantesdataGridView.Size = new System.Drawing.Size(725, 239);
            this.EstudiantesdataGridView.TabIndex = 5;
            this.EstudiantesdataGridView.Visible = false;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Location = new System.Drawing.Point(583, 450);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(110, 41);
            this.Eliminarbutton.TabIndex = 8;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Location = new System.Drawing.Point(355, 450);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(110, 41);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Location = new System.Drawing.Point(125, 450);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(110, 41);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // EstudianteIderrorProvider
            // 
            this.EstudianteIderrorProvider.ContainerControl = this;
            // 
            // NombreEstudianteerrorProvider
            // 
            this.NombreEstudianteerrorProvider.ContainerControl = this;
            // 
            // RegistroEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 537);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.EstudiantesdataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.NombreEstudiantetextBox);
            this.Controls.Add(this.EstudianteIdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEstudiantes";
            this.Text = "RegistroEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreEstudianteerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EstudianteIdtextBox;
        private System.Windows.Forms.TextBox NombreEstudiantetextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView EstudiantesdataGridView;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.ErrorProvider EstudianteIderrorProvider;
        private System.Windows.Forms.ErrorProvider NombreEstudianteerrorProvider;
    }
}