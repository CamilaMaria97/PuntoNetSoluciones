//using System.IO.Pipes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Dominio
{
    public class Municipio
    {
        public int     id    {get;set;}
        [Required(ErrorMessage="Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage="el campo {0} debe ser máximo de {1} caracteres")]
        [MinLength(4, ErrorMessage=" el campo {0} de tener al menos {1} caracteres")]
        public string Nombre {get;set;}
         //Relacion con torneo, propiedad navigacional
        public List<Torneo> Torneos {get;set;}


    }
}