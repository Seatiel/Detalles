namespace TareaDetalles.UI.Registros
{
    partial class RegistroGrupos
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
            this.GrupoIdtextBox = new System.Windows.Forms.TextBox();
            this.NombreGrupotextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GruposdataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.NombreGrupocomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.GrupoIderrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreGrupoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GruposdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoIderrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreGrupoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Grupo:";
            // 
            // GrupoIdtextBox
            // 
            this.GrupoIdtextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoIdtextBox.Location = new System.Drawing.Point(193, 29);
            this.GrupoIdtextBox.Name = "GrupoIdtextBox";
            this.GrupoIdtextBox.Size = new System.Drawing.Size(44, 28);
            this.GrupoIdtextBox.TabIndex = 2;
            // 
            // NombreGrupotextBox
            // 
            this.NombreGrupotextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreGrupotextBox.Location = new System.Drawing.Point(193, 72);
            this.NombreGrupotextBox.Name = "NombreGrupotextBox";
            this.NombreGrupotextBox.Size = new System.Drawing.Size(339, 28);
            this.NombreGrupotextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GruposdataGridView);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.NombreGrupocomboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 361);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiantes";
            // 
            // GruposdataGridView
            // 
            this.GruposdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GruposdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GruposdataGridView.Location = new System.Drawing.Point(10, 111);
            this.GruposdataGridView.Name = "GruposdataGridView";
            this.GruposdataGridView.RowTemplate.Height = 24;
            this.GruposdataGridView.Size = new System.Drawing.Size(832, 236);
            this.GruposdataGridView.TabIndex = 8;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(666, 42);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(115, 36);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.Text = "Agragar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // NombreGrupocomboBox
            // 
            this.NombreGrupocomboBox.FormattingEnabled = true;
            this.NombreGrupocomboBox.Location = new System.Drawing.Point(180, 50);
            this.NombreGrupocomboBox.Name = "NombreGrupocomboBox";
            this.NombreGrupocomboBox.Size = new System.Drawing.Size(329, 28);
            this.NombreGrupocomboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del Grupo:";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Location = new System.Drawing.Point(122, 551);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(115, 36);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Location = new System.Drawing.Point(387, 550);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(115, 36);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Location = new System.Drawing.Point(633, 551);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(115, 36);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Location = new System.Drawing.Point(689, 21);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(115, 36);
            this.Buscarbutton.TabIndex = 9;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // GrupoIderrorProvider
            // 
            this.GrupoIderrorProvider.ContainerControl = this;
            // 
            // NombreGrupoerrorProvider
            // 
            this.NombreGrupoerrorProvider.ContainerControl = this;
            // 
            // RegistroGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 618);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NombreGrupotextBox);
            this.Controls.Add(this.GrupoIdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroGrupos";
            this.Text = "RegistroGrupos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GruposdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoIderrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreGrupoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GrupoIdtextBox;
        private System.Windows.Forms.TextBox NombreGrupotextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GruposdataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox NombreGrupocomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider GrupoIderrorProvider;
        private System.Windows.Forms.ErrorProvider NombreGrupoerrorProvider;
    }
}