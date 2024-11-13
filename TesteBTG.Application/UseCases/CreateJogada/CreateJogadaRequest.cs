using MediatR;
using TesteBTG.Domain.Models.Enum;

namespace TesteBTG.Application.UseCases.CreateJogada
{
    public sealed class CreateJogadaRequest : IRequest<CreateJogadaResponse>
    {
        public ObjetoEnum ObjetoJogador { get; set; }

        public CreateJogadaRequest(ObjetoEnum objetoJogador)
        {
            ObjetoJogador = objetoJogador;
        }
    }
}