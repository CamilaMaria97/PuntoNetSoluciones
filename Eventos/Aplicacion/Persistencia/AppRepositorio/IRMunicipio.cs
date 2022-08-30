/*using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRMunicipio
    {
        public bool CrearMunicipio(Municipio municipio);
        public Municipio BuscarMunicipio(int idMunicipio);
        public bool ActualizarMunicipio(Municipio municipio);
        public bool EliminarMunicipio(int idMunicipio);
        public List<Municipio> ListarMunicipios1();
        public IEnumerable<Municipio> ListarMunicipios();
    }
}*/

using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRMunicipio
    {
        public bool CrearMunicipio(Municipio municipio);
        public Municipio BuscarMunicipio(int idMunicipio);
        public bool ActualizarMunicipio(Municipio municipio);
        public bool EliminarMunicipio(int idMunicipio);
        public List<Municipio> ListarMunicipios1();
        public IEnumerable<Municipio> ListarMunicipios();
    }
}