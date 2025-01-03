﻿using dominio;
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
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoria");
            cbCampo.Items.Add("Codigo");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                List<Articulo> listaArticulos = negocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticulos;
                CargarImagen(listaArticulos[0].Imagen);
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Imagen"].Visible = false;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo seleccionado;
                if (dgvArticulos.CurrentRow != null) seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                else
                {
                    MessageBox.Show("Seleccione el articulo a eliminar", "Eliminar Articulo");
                    return;
                }

                DialogResult result = MessageBox.Show("Seguro quiere eliminar el articulo '" + seleccionado.Nombre + "'", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    negocio.EliminarArticulo(seleccionado);
                    cargar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                AgregarArticulo ventana = new AgregarArticulo((Articulo)dgvArticulos.CurrentRow.DataBoundItem);
                ventana.ShowDialog();
                cargar();
            }
            else MessageBox.Show("No hay ningun articulo seleccionado", "Editar Articulo");
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            string query = txtBusqueda.Text;
            List<Articulo> listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Nombre.ToUpper().Contains(query.ToUpper()));
            
            if (query.Length >= 3 || query == "")
            dgvArticulos.DataSource = listaFiltrada;

        }

        private void txtBusqueda_MouseClick(object sender, MouseEventArgs e)
        {
            txtBusqueda.Text = "";
            txtBusqueda.ForeColor = SystemColors.ControlText;
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if(txtBusqueda.Text == "")
            {
                txtBusqueda.Text = "Buscar...";
                txtBusqueda.ForeColor = SystemColors.WindowFrame;
                cargar();
            }
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCampo.SelectedItem != null)
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Comienza Con");
                cbCriterio.Items.Add("Termina Con");
                cbCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCampo.SelectedItem != null && cbCriterio.SelectedItem != null)
                {

                    string campo = cbCampo.SelectedItem.ToString();
                    string criterio = cbCriterio.SelectedItem.ToString();
                    string query = txtFiltroAvanzado.Text;

                    ArticuloNegocio negocio = new ArticuloNegocio();
                    List<Articulo> listaFiltrada = null;

                    if (query.Length >= 3 || query == "" && listaFiltrada != null)
                    {
                        if (campo == "Marca")
                        {
                            switch (criterio)
                            {
                                case "Comienza Con":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Marca.Descripcion.ToUpper().StartsWith(query.ToUpper()));
                                    break;

                                case "Termina Con":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Marca.Descripcion.ToUpper().EndsWith(query.ToUpper()));
                                    break;

                                case "Contiene":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Marca.Descripcion.ToUpper().Contains(query.ToUpper()));
                                    break;

                            }
                        }
                        else if (campo == "Categoria")
                        {
                            switch (criterio)
                            {
                                case "Comienza Con":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Categoria.Descripcion.ToUpper().StartsWith(query.ToUpper()));
                                    break;

                                case "Termina Con":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Categoria.Descripcion.ToUpper().EndsWith(query.ToUpper()));
                                    break;

                                case "Contiene":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Categoria.Descripcion.ToUpper().Contains(query.ToUpper()));
                                    break;
                            }
                        }
                        else if (campo == "Codigo")
                        {
                            switch (criterio)
                            {
                                case "Comienza Con":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Codigo.ToUpper().StartsWith(query.ToUpper()));
                                    break;

                                case "Termina Con":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Codigo.ToUpper().EndsWith(query.ToUpper()));
                                    break;

                                case "Contiene":
                                    listaFiltrada = negocio.ListarArticulos().FindAll(x => x.Codigo.ToUpper().Contains(query.ToUpper()));
                                    break;
                            }
                        }

                        dgvArticulos.DataSource = listaFiltrada;
                    }
                }
                else MessageBox.Show("Por favor, antes de buscar, asegurese de seleccionar tanto el Campo como el Criterio sobre los cuales quiere realizar la busqueda.", "Busqueda Avanzada");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
