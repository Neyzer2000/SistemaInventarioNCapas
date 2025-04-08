using System;
using System.Windows.Forms;
using BLL;
using EL;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text)
                };

                ProductoBLL logica = new ProductoBLL();
                logica.Insertar(producto);

                MessageBox.Show("Producto guardado correctamente.");
                txtNombre.Clear();
                txtPrecio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
