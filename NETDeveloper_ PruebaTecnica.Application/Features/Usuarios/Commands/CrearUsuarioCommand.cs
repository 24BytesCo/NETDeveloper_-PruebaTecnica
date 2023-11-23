using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDeveloper__PruebaTecnica.Application.Features.Usuarios.Commands
{
    public class CrearUsuarioCommand
    {
        public class CrearUsuarioCommandRequest : IRequest
        {
            public string? NombreUsuario { get; set; }

            public string? Pass { get; set; }

        }

        public class CrearUsuarioCommandRequestValidator : AbstractValidator<CrearUsuarioCommandRequest>
        {
            public CrearUsuarioCommandRequestValidator()
            {
                RuleFor(x => x.NombreUsuario).NotEmpty().NotNull();
                RuleFor(x => x.Pass).NotEmpty().NotNull();
            }

        }

        public class CrearUsuarioCommandRequestHandler : IRequestHandler<CrearUsuarioCommandRequest>
        {
            public Task<Unit> Handle(CrearUsuarioCommandRequest request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }





    }
}
