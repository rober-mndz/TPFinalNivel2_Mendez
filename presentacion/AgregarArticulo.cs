using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class AgregarArticulo : Form
    {
        private Articulo articulo;

        public AgregarArticulo()
        {
            InitializeComponent();
        }

        public AgregarArticulo(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            lblCargarInfo.Text = "Modifique la informacion deseada.";

        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbAgregar.Load(imagen);
            }
            catch (Exception)
            {
                pbAgregar.Load("https://www.kurin.com/wp-content/uploads/placeholder-square.jpg");
            }
        }
        private void cargar()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbCategoria.DataSource = categoriaNegocio.ListarCategorias();
            cbMarca.DataSource = marcaNegocio.ListarMarcas();

            if (articulo != null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                cbMarca.Text = articulo.Marca.Descripcion;
                cbCategoria.Text = articulo.Categoria.Descripcion;
                txtImagen.Text = articulo.Imagen;
                txtPrecio.Text = articulo.Precio.ToString();
                CargarImagen(articulo.Imagen);
            }
            else CargarImagen("https://www.kurin.com/wp-content/uploads/placeholder-square.jpg");
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();

            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Imagen = txtImagen.Text;
                articulo.Precio = int.Parse(txtPrecio.Text);

                negocio.AgregarArticulo(articulo);

                MessageBox.Show("Articulo agregado exitosamente!", "Agregar articulo");

                Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
