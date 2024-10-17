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
        public AgregarArticulo()
        {
            InitializeComponent();
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
            CargarImagen("https://www.kurin.com/wp-content/uploads/placeholder-square.jpg");
            cbCategoria.DataSource = categoriaNegocio.ListarCategorias();
            cbMarca.DataSource = marcaNegocio.ListarMarcas();
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
