using AutoMapper;
using MediatR;
using System.Linq.Expressions;
using TesteBTG.Application.Service;
using TesteBTG.Domain.Models.Enum;

namespace TesteBTG.Application.UseCases.CreateJogada
{
    public class CreateJogadaHandler : IRequestHandler<CreateJogadaRequest, CreateJogadaResponse>
    {
        private readonly IServiceJogada _service;
        private readonly IMapper _mapper;

        public CreateJogadaHandler(IServiceJogada serviceJogada, IMapper mapper)
        {
            _service = serviceJogada;
            _mapper = mapper;
        }

        public async Task<CreateJogadaResponse> Handle(CreateJogadaRequest request, CancellationToken cancellationToken)
        {
            var jogada = await _service.ProcessarJogada(request.ObjetoJogador);

            var result = _mapper.Map<CreateJogadaResponse>(jogada);

            return result;
        }
    }
}
