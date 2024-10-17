using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Marca> ListarMarcas()
        {
            List<Marca> lista = new List<Marca>();
            try
            {
                datos.setQuery("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Reader.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)datos.Reader["Id"];
                    marca.Descripcion = (string)datos.Reader["Descripcion"];

                    lista.Add(marca);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
