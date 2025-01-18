using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaControlador.Entities
{
    public class Prestamo
    {
        [Key]
        public int PrestamoID { get; set; }
        public int IDLibro { get; set; }
        public string? NombreMiembro { get; set; }
        public DateOnly FechaPrestamo { get; set; }
        public DateOnly FechaDevolucion { get; set; }
        public string? Estado { get; set; }
    }
}
