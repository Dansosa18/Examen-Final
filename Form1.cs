using ExamenFinal.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using ExamenFinal.DataAcces.Paramtros;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Win32;

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        private Mascotas Mascotas;

        Masc Masc = new Masc();

        ////private string connectionString;
        ////private object connection;

        public Form1()
        {
            InitializeComponent();
            Mascotas = new Mascotas();
           Masc = new Masc();
           


        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridViewMascotas.DataSource = Mascotas.LeerMascotas();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Masc.Tipomascota = textBoxTipoMascota.Text;
            Masc.raza = textBoxRaza.Text;
            Masc.nombre = textBoxNombre.Text;
            Masc.sexo = textBoxSexo.Text;
            Masc.fechaNacimiento = dateTimePickerFechaNacimiento.Value;
            Masc.color = textBoxColor.Text;
            Masc.nombredueño = textBoxNombreDueño.Text;
            Masc.telefono = textBoxTelefono.Text;
        
            DialogResult result= MessageBox.Show("¿Está seguro de que desea añadir este registro ? ", "Confirmación", MessageBoxButtons.YesNo);

            if (result== DialogResult.Yes)
            {
                try
                {
                    int respuest = Mascotas.AñadirMascota(Masc.Tipomascota, Masc.raza, Masc.nombre, Masc.sexo, Masc.fechaNacimiento, Masc.color, Masc.nombredueño, Masc.telefono);
                if (respuest > 0)
                    {
                        MessageBox.Show("La mascota se añadio correctamente");
                        RecargarDatosDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al añadir mascota.");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al añadir el registro: " + ex.Message);

                }

            }
            
        }
        private void limpiarTextBox()
        {
            textBoxTipoMascota.Text = "";
            textBoxRaza.Text = "";
            textBoxSexo.Text = "";
            textBoxColor.Text = "";
            textBoxNombre.Text = "";
            textBoxNombreDueño.Text = "";
            textBoxTelefono.Text = "";
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
           
                if (Mascotas.ProbarConexion())
                { MessageBox.Show("Si se pudo 👌❤️😍😍😘"); }
                else
                {
                    MessageBox.Show("Nel Pastel 😢😒🥲😓😔");
                }
            
        }

 

        private void buttonActualizar_Click_1(object sender, EventArgs e)
        {
            int idTarget = (int)numericUpDownActualizar.Value;

            // Encuentra la fila con el ID correspondiente al valor del NumericUpDown
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow row in dataGridViewMascotas.Rows)
            {
                if (Convert.ToInt32(row.Cells["id_mascota"].Value) == idTarget)
                {
                    selectedRow = row;
                    break;
                }
            }

            if (selectedRow != null)
            {
                Masc.Tipomascota = textBoxTipoMascota.Text;
                Masc.nombre = textBoxNombre.Text;
                Masc.raza= textBoxRaza.Text;
                Masc.sexo= textBoxSexo.Text;
                Masc.color= textBoxColor.Text;
                Masc.fechaNacimiento= dateTimePickerFechaNacimiento.Value;
                Masc.telefono = textBoxTelefono.Text;
                Masc.nombredueño= textBoxNombreDueño.Text;

                // Validar los datos antes de la actualización
                DialogResult result = MessageBox.Show("¿Está seguro de que desea actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int respuesta = Mascotas.ActualizarMascota(idTarget, Masc.Tipomascota, Masc.raza, Masc.nombre, Masc.sexo, Masc.fechaNacimiento, Masc.color, Masc.nombredueño, Masc.telefono);

                        if (respuesta > 0)
                        {
                            MessageBox.Show("La mascota se actualizo correctamente.");
                            // Recargar los datos en el DataGridView
                            RecargarDatosDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar mascota.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró un personaje con el ID proporcionado.");
            }

        }

        private void RecargarDatosDataGridView()
        {
            dataGridViewMascotas.DataSource = Mascotas.LeerMascotas();
            dataGridViewMascotas.Refresh();
        }

        private int ActualizarMascota(int id_Mascota, string tipo_mascota, string raza, string nombre, string sexo, DateTime fecha_nacimiento, string color, string nombre_dueño, string telefono)
        {
            throw new NotImplementedException();
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {           

            // Sirve Para confirmar la eliminacion
            
            int id_Mascota = (int)numericUpDownEliminar.Value;

            int respuesta = Mascotas.EliminarMascota(id_Mascota);


            if (respuesta == 0)
            {
                limpiarTextBox();
                MessageBox.Show("Se elimino correctemente");
                RecargarDatosDataGridView();
                limpiarTextBox();

            }
            else
            {
                MessageBox.Show("Se elimino la mascota, ahora recargue de nuevo");
            }
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownActualizar_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDownActualizar_ValueChanged_1(object sender, EventArgs e)
        {
            int idTarget = (int)numericUpDownActualizar.Value;

            // Encuentra la fila con el ID correspondiente al valor del NumericUpDown
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow row in dataGridViewMascotas.Rows)
            {
                if (Convert.ToInt32(row.Cells["id_Mascota"].Value) == idTarget)
                {
                    selectedRow = row;
                    break;
                }
            }

            if (selectedRow != null)
            {
                // Actualiza los TextBox y otros controles con los valores de la fila seleccionada
                textBoxTipoMascota.Text = selectedRow.Cells["tipo_mascota"].Value?.ToString() ?? string.Empty;
                textBoxSexo.Text = selectedRow.Cells["sexo"].Value?.ToString() ?? string.Empty;
                textBoxRaza.Text = selectedRow.Cells["raza"].Value?.ToString() ?? string.Empty;
                textBoxColor.Text = selectedRow.Cells["color"].Value?.ToString() ?? string.Empty;
                textBoxNombre.Text = selectedRow.Cells["nombre"].Value?.ToString() ?? string.Empty;
                textBoxNombreDueño.Text = selectedRow.Cells["nombre_dueño"].Value?.ToString() ?? string.Empty;
                dateTimePickerFechaNacimiento.Value = selectedRow.Cells["fecha_nacimiento"].Value != null ? Convert.ToDateTime(selectedRow.Cells["fecha_nacimiento"].Value) : DateTime.MinValue;
                textBoxTelefono.Text = selectedRow.Cells["telefono"].Value?.ToString() ?? string.Empty;
            }
            else
            {
                // Si no se encuentra la fila, limpia los TextBox y otros controles
                textBoxTipoMascota.Text = string.Empty;
                textBoxRaza.Text = string.Empty;
                textBoxNombre.Text = string.Empty;
                textBoxSexo.Text = string.Empty;
                dateTimePickerFechaNacimiento.Value = DateTime.Now;
                textBoxColor.Text = string.Empty;
                textBoxNombreDueño.Text = string.Empty;
                textBoxTelefono.Text = string.Empty;
            }
        }

        private void Prueba_Click(object sender, EventArgs e)
        {
            // Sirve Para confirmar la eliminacion
            try
            {


                int id_Mascota = (int)numericUpDownEliminar.Value;

                int respuesta = Mascotas.EliminarMascota(id_Mascota);
                MessageBox.Show(respuesta.ToString());
                if (respuesta== 0)
                {
                    limpiarTextBox();
                    MessageBox.Show("Se elimino correctemente");
                    RecargarDatosDataGridView();
                    limpiarTextBox();

                }
                else
                {
                    MessageBox.Show("Se elimino la mascota, ahora recargue de nuevo");
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error al eliminar mascota " + ex.Message);
                throw;
            }
        }
    }
    

}
