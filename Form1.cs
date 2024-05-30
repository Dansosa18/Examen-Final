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

namespace ExamenFinal
{
    public partial class Form1 : Form
    {
        private Mascotas Mascotas;
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            Mascotas = new Mascotas();
           
           


        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridViewMascotas.DataSource = Mascotas.LeerMascotas();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string tipomascota = textBoxTipoMascota.Text;
            string raza = textBoxSexo.Text;
            string nombre = textBoxNombre.Text;
            string sexo = textBoxSexo.Text;
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
            string color = textBoxColor.Text;
            string nombredueño= textBoxNombreDueño.Text;
            string telefono = textBoxTelefono.Text;

            int respuesta = Mascotas.AñadirMascota(tipomascota, raza, nombre, sexo, fechaNacimiento, color, nombredueño, telefono);

            if (respuesta>0)
            {
                limpiarTextBox();
                MessageBox.Show("Se añadio correctemente");
                dataGridViewMascotas.DataSource = Mascotas.LeerMascotas();
            }
            else
            {
                MessageBox.Show("Hubo un error al añadir Mascota");
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id_Mascota = (int)numericUpDownEliminar.Value;

            int respuesta = Mascotas.EliminarMascota(id_Mascota);

            if (respuesta > 0)
            {
                limpiarTextBox();
                MessageBox.Show("Se elimino correctemente");
                dataGridViewMascotas.DataSource = Mascotas.LeerMascotas();
            }
            else
            {
                MessageBox.Show("Hubo un error al eliminar Mascota");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonActualizar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewMascotas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMascotas.SelectedRows[0];
                int id_Mascota = Convert.ToInt32(selectedRow.Cells["id_Mascota"].Value);
                string tipo_mascota = selectedRow.Cells["tipo_mascota"].Value.ToString();
                string raza = selectedRow.Cells["raza"].Value.ToString();
                string nombre = selectedRow.Cells["nombre"].Value.ToString();
                string sexo = selectedRow.Cells["sexo"].Value.ToString();
                DateTime fecha_nacimiento = Convert.ToDateTime(selectedRow.Cells["fecha_nacimiento"].Value);
                string color = selectedRow.Cells["color"].Value.ToString();
                string nombre_dueño = selectedRow.Cells["nombre_dueño"].Value.ToString();
                string telefono = selectedRow.Cells["telefono"].Value.ToString();

                // Validar los datos antes de la actualización
                DialogResult result = MessageBox.Show("¿Está seguro de que desea actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int resultado = ActualizarMascota(id_Mascota, tipo_mascota, raza, nombre, sexo, fecha_nacimiento, color, nombre_dueño, telefono);

                        if (resultado > 0)
                        {
                            MessageBox.Show("Mascota actualizada correctamente.");
                            // Recargar los datos en el DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar la mascota.");
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
                MessageBox.Show("Por favor, seleccione una fila para actualizar.");
            }
        }

        private int ActualizarMascota(int id_Mascota, string tipo_mascota, string raza, string nombre, string sexo, DateTime fecha_nacimiento, string color, string nombre_dueño, string telefono)
        {
            throw new NotImplementedException();
        }

        

    }
}
