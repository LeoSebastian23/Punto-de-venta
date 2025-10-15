using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // --- Limpiar antes de configurarlo (evita duplicados si se ejecuta varias veces) ---
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                // --- Configuración básica ---
                dataGridView1.AutoGenerateColumns = false;                // vamos a crear columnas manualmente
                dataGridView1.AllowUserToAddRows = true;                  // dejar fila "nueva" al final
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = true;

                // --- Colores / visual ---
                dataGridView1.BackgroundColor = Color.White;
                dataGridView1.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.GridColor = Color.Black;

                // --- Agregar columnas (nombreInterno, textoVisible) ---
                dataGridView1.Columns.Add("Codigo", "Código");
                dataGridView1.Columns.Add("Descripcion", "Descripción");
                dataGridView1.Columns.Add("Cantidad", "Cantidad");
                dataGridView1.Columns.Add("Precio", "Precio");
                dataGridView1.Columns.Add("Subtotal", "Subtotal");
                dataGridView1.ReadOnly = true;



                // --- Opcional: agregar filas vacías para que se vean las líneas ---
                for (int i = 0; i < 10; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar DataGridView:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



    

}

