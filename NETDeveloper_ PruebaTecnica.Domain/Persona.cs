﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NETDeveloper__PruebaTecnica.Domain
{
    public class Persona
    {
        [Key]
        public Guid Identificador { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombres { get; set; }

        [StringLength(100)]
        public string? Apellidos { get; set; }

        [Required]
        [StringLength(100)]
        public string? NumeroIdentificacion { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(100)]
        public string? TipoIdentificacion { get; set; }
        
        [DataType(DataType.Date)]        
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [NotMapped]
        public string NumeroIdentificacionConcat => $"{NumeroIdentificacion} {TipoIdentificacion}";

        [NotMapped]
        public string NombresApellidosConcat => $"{Nombres} {Apellidos}";
    }
}