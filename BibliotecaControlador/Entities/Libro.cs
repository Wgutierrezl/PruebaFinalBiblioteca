using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaControlador.Entities
{
    public class Libro
    {

        [Key]
        public int LibroID { get; set; }
        public string? NombreLibro { get; set; }
        public string? Genero { get; set; }
        public int IDAutor { get; set; }
        public string? Estado { get; set; }
    }

}
