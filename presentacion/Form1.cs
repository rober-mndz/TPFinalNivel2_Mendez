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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                List<Articulo> listaArticulos = negocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticulos;
                CargarImagen(listaArticulos[0].Imagen);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbArticulo.Load("https://www.kurin.com/wp-content/uploads/placeholder-square.jpg");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            }
            else return;

            lblCodigo.Text = seleccionado.Codigo;
            lblNombre.Text = seleccionado.Nombre;
            lblDescripcion.Text = seleccionado.Descripcion;
            lblMarca.Text = seleccionado.Marca.Descripcion;
            lblCategoria.Text = seleccionado.Categoria.Descripcion;
            lblPrecio.Text = "$"+seleccionado.Precio.ToString();
            CargarImagen(seleccionado.Imagen);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo ventana = new AgregarArticulo();
            ventana.ShowDialog();
            cargar();
        }
    }
}
