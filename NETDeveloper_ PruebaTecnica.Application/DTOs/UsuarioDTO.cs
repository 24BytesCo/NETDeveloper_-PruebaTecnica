using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDeveloper__PruebaTecnica.Application.DTOs
{
    public class UsuarioDTO
    {
        public Guid Identificador { get; set; }

        public string? NombreUsuario { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
