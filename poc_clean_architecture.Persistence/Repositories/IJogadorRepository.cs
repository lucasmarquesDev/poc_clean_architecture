using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Persistence.Repositories
{
    public interface IJogadorRepository
    {
        ObjetoEnum GetJogador();
    }
}
