using TesteBTG.Domain.Models.DTO;
using TesteBTG.Domain.Models.Enum;

namespace TesteBTG.Application.Service
{
    public interface IServiceJogada
    {
        Task<ResultadoJogadaDTO> ProcessarJogada(ObjetoEnum jogadaJogador);
    }
}