using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Collection.Generic;
using Dominio;
using Persistencia;

namespace Frontend.page.CMunicipio
{
    public class IndexModel : PageModel
    {
        //Atributos
        private readonly IRMunicipio _repoMunicipio;
        public IEnumerable<Municipio> Municipios{get;set;}
        //Metodos
        //constructor

        public IndexModel(IRMunicipio repoMunicipio)
        {
            this._repoMunicipio=repoMunicipio;
        }

        // enviar vista y/o valores al usuario
        public void OnGet()
        {
            Municipios=__repoMunicipio.ListarMunicipios();
        }
    }
}
