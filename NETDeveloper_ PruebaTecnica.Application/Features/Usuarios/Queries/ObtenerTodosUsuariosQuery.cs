using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NETDeveloper__PruebaTecnica.Application.DTOs;
using NETDeveloper__PruebaTecnica.Domain;
using NETDeveloper__PruebaTecnica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDeveloper__PruebaTecnica.Application.Features.Usuarios.Queries
{
    public class ObtenerTodosUsuariosQuery
    {

        public class ObtenerTodosUsuariosQueryRequest : IRequest<List<UsuarioDTO>> { }

        public class ObtenerTodosUsuariosQueryHandler : IRequestHandler<ObtenerTodosUsuariosQueryRequest, List<UsuarioDTO>>
        {
            private readonly NETDeveloper_PruebaTecnicaDbContext _context;
            private readonly IMapper _mapper;

            public ObtenerTodosUsuariosQueryHandler(NETDeveloper_PruebaTecnicaDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<UsuarioDTO>> Handle(ObtenerTodosUsuariosQueryRequest request, CancellationToken cancellationToken)
            {

                var todosUsuariosBd = await _context.Usuarios.ToListAsync();

                return _mapper.Map<List<Usuario>, List<UsuarioDTO>>(todosUsuariosBd);
            }
        }


    }
}
