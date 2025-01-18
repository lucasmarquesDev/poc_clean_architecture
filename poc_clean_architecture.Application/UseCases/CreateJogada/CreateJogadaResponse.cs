using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Application.UseCases.CreateJogada
{
    public sealed class CreateJogadaResponse
    {
        public ObjetoEnum jogada { get; set; }

        public CreateJogadaResponse(ObjetoEnum _jogada)
        {
            jogada = _jogada;
        }
    }
}