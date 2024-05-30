namespace ExamenFinal
{
    partial class Form1
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
            this.dataGridViewMascotas = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxTipoMascota = new System.Windows.Forms.TextBox();
            this.labelTipoMascota = new System.Windows.Forms.Label();
            this.labelRaza = new System.Windows.Forms.Label();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelSexo = new System.Windows.Forms.Label();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelNombredueño = new System.Windows.Forms.Label();
            this.textBoxNombreDueño = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.buttonPrueba = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.numericUpDownEliminar = new System.Windows.Forms.NumericUpDown();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.numericUpDownActualizar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMascotas
            // 
            this.dataGridViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMascotas.Location = new System.Drawing.Point(154, 12);
            this.dataGridViewMascotas.Name = "dataGridViewMascotas";
            this.dataGridViewMascotas.Size = new System.Drawing.Size(389, 138);
            this.dataGridViewMascotas.TabIndex = 0;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(12, 12);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(136, 52);
            this.buttonCargar.TabIndex = 1;
            this.buttonCargar.Text = "Leer";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(27, 70);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(121, 29);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxTipoMascota
            // 
            this.textBoxTipoMascota.Location = new System.Drawing.Point(102, 155);
            this.textBoxTipoMascota.Name = "textBoxTipoMascota";
            this.textBoxTipoMascota.Size = new System.Drawing.Size(177, 20);
            this.textBoxTipoMascota.TabIndex = 3;
            // 
            // labelTipoMascota
            // 
            this.labelTipoMascota.AutoSize = true;
            this.labelTipoMascota.Location = new System.Drawing.Point(24, 162);
            this.labelTipoMascota.Name = "labelTipoMascota";
            this.labelTipoMascota.Size = new System.Drawing.Size(72, 13);
            this.labelTipoMascota.TabIndex = 4;
            this.labelTipoMascota.Text = "Tipo Mascota";
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.Location = new System.Drawing.Point(24, 188);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.Size = new System.Drawing.Size(32, 13);
            this.labelRaza.TabIndex = 6;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Location = new System.Drawing.Point(102, 181);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(177, 20);
            this.textBoxRaza.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(24, 214);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(102, 207);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(177, 20);
            this.textBoxNombre.TabIndex = 7;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(24, 240);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 10;
            this.labelSexo.Text = "Sexo";
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Location = new System.Drawing.Point(102, 233);
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.Size = new System.Drawing.Size(177, 20);
            this.textBoxSexo.TabIndex = 9;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(288, 166);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 13);
            this.labelColor.TabIndex = 12;
            this.labelColor.Text = "Color";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(366, 159);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(177, 20);
            this.textBoxColor.TabIndex = 11;
            // 
            // labelNombredueño
            // 
            this.labelNombredueño.AutoSize = true;
            this.labelNombredueño.Location = new System.Drawing.Point(288, 195);
            this.labelNombredueño.Name = "labelNombredueño";
            this.labelNombredueño.Size = new System.Drawing.Size(79, 13);
            this.labelNombredueño.TabIndex = 14;
            this.labelNombredueño.Text = "Nombre Dueño";
            // 
            // textBoxNombreDueño
            // 
            this.textBoxNombreDueño.Location = new System.Drawing.Point(366, 188);
            this.textBoxNombreDueño.Name = "textBoxNombreDueño";
            this.textBoxNombreDueño.Size = new System.Drawing.Size(177, 20);
            this.textBoxNombreDueño.TabIndex = 13;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(288, 221);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 16;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(366, 214);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(177, 20);
            this.textBoxTelefono.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(123, 260);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 18;
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.Location = new System.Drawing.Point(549, 12);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(117, 66);
            this.buttonPrueba.TabIndex = 19;
            this.buttonPrueba.Text = "Prueba";
            this.buttonPrueba.UseVisualStyleBackColor = true;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(682, 21);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(147, 35);
            this.buttonEliminar.TabIndex = 20;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // numericUpDownEliminar
            // 
            this.numericUpDownEliminar.Location = new System.Drawing.Point(835, 12);
            this.numericUpDownEliminar.Name = "numericUpDownEliminar";
            this.numericUpDownEliminar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEliminar.TabIndex = 21;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(682, 158);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(82, 50);
            this.buttonActualizar.TabIndex = 23;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click_1);
            // 
            // numericUpDownActualizar
            // 
            this.numericUpDownActualizar.Location = new System.Drawing.Point(770, 175);
            this.numericUpDownActualizar.Name = "numericUpDownActualizar";
            this.numericUpDownActualizar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownActualizar.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.numericUpDownActualizar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.numericUpDownEliminar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonPrueba);
            this.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelNombredueño);
            this.Controls.Add(this.textBoxNombreDueño);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.textBoxSexo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelRaza);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.labelTipoMascota);
            this.Controls.Add(this.textBoxTipoMascota);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridViewMascotas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMascotas;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxTipoMascota;
        private System.Windows.Forms.Label labelTipoMascota;
        private System.Windows.Forms.Label labelRaza;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelNombredueño;
        private System.Windows.Forms.TextBox textBoxNombreDueño;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Button buttonPrueba;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.NumericUpDown numericUpDownEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.NumericUpDown numericUpDownActualizar;

    }
}

