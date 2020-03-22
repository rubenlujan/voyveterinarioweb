using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoyVeterinarioWeb.Models
{
    public class DirectorioView
    {
        public int Id { get; set; }
        public string LinkFoto { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Info { get; set; }
        public string Telefono { get; set; }
        public string FB { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
    }
}