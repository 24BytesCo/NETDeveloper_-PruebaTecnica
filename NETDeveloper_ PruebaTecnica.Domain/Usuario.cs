using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDeveloper__PruebaTecnica.Domain
{
    public class Usuario
    {
        [Key]
        public Guid Identificador { get; set; }

        [StringLength(50)]
        public string? NombreUsuario { get; set; }

        [StringLength(80)]
        public string? Pass { get; set; }
        
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    
    }

}
