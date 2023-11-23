using AutoMapper;
using NETDeveloper__PruebaTecnica.Application.DTOs;
using NETDeveloper__PruebaTecnica.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDeveloper__PruebaTecnica.Application.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}
