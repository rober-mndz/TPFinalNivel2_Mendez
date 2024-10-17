using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                datos.setQuery("Select Id, Descripcion From CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)datos.Reader["Id"];
                    categoria.Descripcion = (string)datos.Reader["Descripcion"];

                    lista.Add(categoria);
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
