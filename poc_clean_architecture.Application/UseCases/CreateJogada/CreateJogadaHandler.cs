using AutoMapper;
using MediatR;
using poc_clean_architecture.Persistence.Repositories;

namespace poc_clean_architecture.Application.UseCases.CreateJogada
{
    public class CreateJogadaHandler : IRequestHandler<CreateJogadaRequest, CreateJogadaResponse>
    {
        private readonly IJogadorRepository _repository;
        private readonly IMapper _mapper;

        public CreateJogadaHandler(IJogadorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateJogadaResponse> Handle(CreateJogadaRequest request, CancellationToken cancellationToken)
        {
            var jogada = _repository.GetJogador();

            var result = _mapper.Map<CreateJogadaResponse>(jogada);

            return result;
        }
    }
}
