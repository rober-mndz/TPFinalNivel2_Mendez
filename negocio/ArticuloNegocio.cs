using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            
            try
            {
                datos.setQuery("SELECT a.Id as ID, Codigo, Nombre, a.Descripcion, m.Descripcion as Marca, c.Descripcion as Categoria, ImagenUrl, Precio FROM ARTICULOS a, MARCAS m, CATEGORIAS c WHERE IdMarca = m.Id AND IdCategoria = c.Id");
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    Articulo articulo = new Articulo();
                    Marca marca = new Marca();
                    Categoria categoria = new Categoria();
                    articulo.Id  = (int)datos.Reader["ID"];
                    articulo.Codigo = (string)datos.Reader["Codigo"];
                    articulo.Nombre = (string)datos.Reader["Nombre"];
                    articulo.Descripcion = (string)datos.Reader["Descripcion"];
                    articulo.Marca = marca;
                    articulo.Marca.Descripcion = (string)datos.Reader["Marca"];
                    articulo.Categoria = categoria;
                    articulo.Categoria.Descripcion = (string)datos.Reader["Categoria"];
                    articulo.Imagen = (string)datos.Reader["ImagenUrl"];
                    articulo.Precio = (decimal)datos.Reader["Precio"];
                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
