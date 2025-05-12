using System;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI
{
    public partial class Form1 : Form
    {
        ProductoBLL bll = new ProductoBLL();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando se abre el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos(); // Muestra los productos en el DataGridView al iniciar
        }

        // Botón para insertar productos
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor llena todos los campos.");
                    return;
                }

                // Crear nuevo producto
                Producto nuevo = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text)
                };

                // Insertar usando BLL
                bll.Insertar(nuevo);

                // Confirmar
                MessageBox.Show("Producto insertado correctamente.");

                // Limpiar campos
                txtNombre.Text = "";
                txtPrecio.Text = "";

                // Actualizar la tabla
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Cargar productos en el DataGridView
        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = bll.ObtenerTodos();
        }

        // Puedes eliminar este método si no usas el evento del label
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
