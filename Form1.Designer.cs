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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMascotas = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxTipoMascota = new System.Windows.Forms.TextBox();
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
            this.labelTipoMascota = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Prueba = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMascotas
            // 
            this.dataGridViewMascotas.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMascotas.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewMascotas.Name = "dataGridViewMascotas";
            this.dataGridViewMascotas.Size = new System.Drawing.Size(945, 208);
            this.dataGridViewMascotas.TabIndex = 0;
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCargar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.Location = new System.Drawing.Point(12, 12);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(136, 52);
            this.buttonCargar.TabIndex = 1;
            this.buttonCargar.Text = "Leer";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAgregar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAgregar.Location = new System.Drawing.Point(415, 397);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(155, 66);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxTipoMascota
            // 
            this.textBoxTipoMascota.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTipoMascota.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipoMascota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTipoMascota.Location = new System.Drawing.Point(147, 286);
            this.textBoxTipoMascota.Name = "textBoxTipoMascota";
            this.textBoxTipoMascota.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTipoMascota.Size = new System.Drawing.Size(177, 26);
            this.textBoxTipoMascota.TabIndex = 3;
            // 
            // labelRaza
            // 
            this.labelRaza.AutoSize = true;
            this.labelRaza.BackColor = System.Drawing.Color.FloralWhite;
            this.labelRaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRaza.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRaza.Location = new System.Drawing.Point(27, 317);
            this.labelRaza.Name = "labelRaza";
            this.labelRaza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelRaza.Size = new System.Drawing.Size(48, 21);
            this.labelRaza.TabIndex = 6;
            this.labelRaza.Text = "Raza";
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRaza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRaza.Location = new System.Drawing.Point(147, 315);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(177, 26);
            this.textBoxRaza.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.FloralWhite;
            this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombre.Location = new System.Drawing.Point(27, 343);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelNombre.Size = new System.Drawing.Size(69, 21);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNombre.Location = new System.Drawing.Point(147, 344);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(177, 26);
            this.textBoxNombre.TabIndex = 7;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.FloralWhite;
            this.labelSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSexo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSexo.Location = new System.Drawing.Point(27, 373);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSexo.Size = new System.Drawing.Size(44, 21);
            this.labelSexo.TabIndex = 10;
            this.labelSexo.Text = "Sexo";
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxSexo.Location = new System.Drawing.Point(147, 373);
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.Size = new System.Drawing.Size(177, 26);
            this.textBoxSexo.TabIndex = 9;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.FloralWhite;
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColor.Location = new System.Drawing.Point(379, 291);
            this.labelColor.Name = "labelColor";
            this.labelColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelColor.Size = new System.Drawing.Size(50, 21);
            this.labelColor.TabIndex = 12;
            this.labelColor.Text = "Color";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxColor.Location = new System.Drawing.Point(506, 289);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(177, 26);
            this.textBoxColor.TabIndex = 11;
            // 
            // labelNombredueño
            // 
            this.labelNombredueño.AutoSize = true;
            this.labelNombredueño.BackColor = System.Drawing.Color.FloralWhite;
            this.labelNombredueño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombredueño.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombredueño.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombredueño.Location = new System.Drawing.Point(379, 318);
            this.labelNombredueño.Name = "labelNombredueño";
            this.labelNombredueño.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelNombredueño.Size = new System.Drawing.Size(121, 21);
            this.labelNombredueño.TabIndex = 14;
            this.labelNombredueño.Text = "Nombre Dueño";
            // 
            // textBoxNombreDueño
            // 
            this.textBoxNombreDueño.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreDueño.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNombreDueño.Location = new System.Drawing.Point(506, 318);
            this.textBoxNombreDueño.Name = "textBoxNombreDueño";
            this.textBoxNombreDueño.Size = new System.Drawing.Size(177, 26);
            this.textBoxNombreDueño.TabIndex = 13;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.BackColor = System.Drawing.Color.FloralWhite;
            this.labelTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTelefono.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTelefono.Location = new System.Drawing.Point(379, 344);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTelefono.Size = new System.Drawing.Size(74, 21);
            this.labelTelefono.TabIndex = 16;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTelefono.Location = new System.Drawing.Point(506, 345);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(177, 26);
            this.textBoxTelefono.TabIndex = 15;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FloralWhite;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(27, 402);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(176, 402);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(148, 26);
            this.dateTimePickerFechaNacimiento.TabIndex = 18;
            // 
            // buttonPrueba
            // 
            this.buttonPrueba.BackColor = System.Drawing.Color.MistyRose;
            this.buttonPrueba.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrueba.Location = new System.Drawing.Point(963, 21);
            this.buttonPrueba.Name = "buttonPrueba";
            this.buttonPrueba.Size = new System.Drawing.Size(117, 66);
            this.buttonPrueba.TabIndex = 19;
            this.buttonPrueba.Text = "Prueba";
            this.buttonPrueba.UseVisualStyleBackColor = false;
            this.buttonPrueba.Click += new System.EventHandler(this.buttonPrueba_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonEliminar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(194, 21);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(147, 35);
            this.buttonEliminar.TabIndex = 20;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click_1);
            // 
            // numericUpDownEliminar
            // 
            this.numericUpDownEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.numericUpDownEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownEliminar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEliminar.Location = new System.Drawing.Point(370, 30);
            this.numericUpDownEliminar.Name = "numericUpDownEliminar";
            this.numericUpDownEliminar.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownEliminar.TabIndex = 21;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonActualizar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.Location = new System.Drawing.Point(506, 21);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(147, 33);
            this.buttonActualizar.TabIndex = 23;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click_1);
            // 
            // numericUpDownActualizar
            // 
            this.numericUpDownActualizar.BackColor = System.Drawing.Color.MistyRose;
            this.numericUpDownActualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownActualizar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownActualizar.Location = new System.Drawing.Point(688, 30);
            this.numericUpDownActualizar.Name = "numericUpDownActualizar";
            this.numericUpDownActualizar.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownActualizar.TabIndex = 24;
            this.numericUpDownActualizar.ValueChanged += new System.EventHandler(this.numericUpDownActualizar_ValueChanged_1);
            // 
            // labelTipoMascota
            // 
            this.labelTipoMascota.AutoSize = true;
            this.labelTipoMascota.BackColor = System.Drawing.Color.FloralWhite;
            this.labelTipoMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTipoMascota.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoMascota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTipoMascota.Location = new System.Drawing.Point(27, 291);
            this.labelTipoMascota.Name = "labelTipoMascota";
            this.labelTipoMascota.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTipoMascota.Size = new System.Drawing.Size(111, 21);
            this.labelTipoMascota.TabIndex = 25;
            this.labelTipoMascota.Text = "Tipo Mascota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ExamenFinal.Properties.Resources.guarderia_macotas;
            this.pictureBox1.Location = new System.Drawing.Point(828, 286);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 221);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(976, 144);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(103, 34);
            this.Prueba.TabIndex = 27;
            this.Prueba.Text = "Prueba";
            this.Prueba.UseVisualStyleBackColor = true;
            this.Prueba.Click += new System.EventHandler(this.Prueba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 524);
            this.Controls.Add(this.Prueba);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTipoMascota);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMascotas;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxTipoMascota;
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
        private System.Windows.Forms.Label labelTipoMascota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Prueba;
    }
}

