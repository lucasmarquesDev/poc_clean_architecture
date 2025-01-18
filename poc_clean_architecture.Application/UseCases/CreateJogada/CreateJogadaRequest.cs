using MediatR;
using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Application.UseCases.CreateJogada
{
    public sealed class CreateJogadaRequest : IRequest<CreateJogadaResponse>
    {
        //public ObjetoEnum ObjetoJogador { get; set; }

        //public CreateJogadaRequest(ObjetoEnum objetoJogador)
        //{
        //    ObjetoJogador = objetoJogador;
        //}
    }
}