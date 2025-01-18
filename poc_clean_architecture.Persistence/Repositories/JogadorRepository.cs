using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Persistence.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        public ObjetoEnum GetJogador()
        {
            var jogadaComputador = (ObjetoEnum)Random.Shared.Next(0, 3);

            return jogadaComputador;
        }
    }
}
