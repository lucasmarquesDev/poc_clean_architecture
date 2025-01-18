using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Application.UseCases.CreateJogada
{
    public sealed class GetJogadaComputerResponse
    {
        public ObjetoEnum jogada { get; set; }

        public GetJogadaComputerResponse(ObjetoEnum _jogada)
        {
            jogada = _jogada;
        }
    }
}