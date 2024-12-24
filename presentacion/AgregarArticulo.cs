using dominio;
using negocio;
using System;
using System.IO;
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
        private OpenFileDialog archivo = null;

        public AgregarArticulo()
        {
            InitializeComponent();
        }

        public AgregarArticulo(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            lblCargarInfo.Text = "Modifique la informacion deseada.";
            btnAgregar.Text = "Guardar";

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

        private bool ValidarArticulo()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control != txtImagen)
                {
                    if (control.Text == "")
                    {
                        MessageBox.Show("Asegurese de completar todos los campos requeridos.");
                        return false;
                    }
                }
            }

            foreach (char caracter in txtPrecio.Text)
            {
                if (!(char.IsNumber(caracter) || caracter == '.'))
                {
                    MessageBox.Show("Asegurese de ingresar el precio en el formato correcto");
                    return false;
                }
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();

            try
            {

                if (ValidarArticulo())
                {
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Marca = (Marca)cbMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                    articulo.Imagen = txtImagen.Text;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);


                    if (archivo != null && !(txtImagen.Text.Contains("http")))
                        //guardar la imagen!!
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["gdImages"] + archivo.SafeFileName);

                    if (this.articulo == null)
                    {
                        negocio.AgregarArticulo(articulo);
                        MessageBox.Show("Articulo agregado exitosamente!", "Agregar articulo");
                    }
                    else
                    {
                        articulo.Id = this.articulo.Id;
                        negocio.EditarArticulo(articulo);
                        MessageBox.Show("Articulo editado exitosamente!", "Editar articulo");
                    }


                    Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                CargarImagen(archivo.FileName);


            }
        }
    }
}
