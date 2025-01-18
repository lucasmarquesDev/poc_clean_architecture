using AutoMapper;
using MediatR;
using poc_clean_architecture.Persistence.Repositories;

namespace poc_clean_architecture.Application.UseCases.CreateJogada
{
    public class GetJogadaComputerHandler : IRequestHandler<GetJogadaComputerRequest, GetJogadaComputerResponse>
    {
        private readonly IJogadorRepository _repository;
        private readonly IMapper _mapper;

        public GetJogadaComputerHandler(IJogadorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetJogadaComputerResponse> Handle(GetJogadaComputerRequest request, CancellationToken cancellationToken)
        {
            var jogada = _repository.GetJogador();

            var result = _mapper.Map<GetJogadaComputerResponse>(jogada);

            return result;
        }
    }
}
