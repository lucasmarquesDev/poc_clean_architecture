using poc_clean_architecture.Domain.Models.DTO;
using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Application.Service
{
    public interface IServiceJogada
    {
        Task<ResultadoJogadaDTO> ProcessarJogada(ObjetoEnum jogadaJogador);
    }
}