using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poc_clean_architecture.Application.UseCases.CreateJogada;
using poc_clean_architecture.Domain.Models.DTO;
using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Application.Service
{
    public class ServiceJogada : IServiceJogada
    {
        IMediator _mediator;
        public ServiceJogada(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ResultadoJogadaDTO> ProcessarJogada(ObjetoEnum jogadaJogador)
        {
            var jogadaComputador = await _mediator.Send(new CreateJogadaRequest());

            if (jogadaComputador.jogada.GetHashCode() == jogadaJogador.GetHashCode())
                return new ResultadoJogadaDTO(jogadaJogador.ToString(), jogadaComputador.ToString(), "Empate");

            var resultado = jogadaJogador switch
            {
                ObjetoEnum.Pedra => jogadaComputador.jogada == ObjetoEnum.Tesoura ? "Você foi ganhou!" : "Maquina Ganhou!",
                ObjetoEnum.Papel => jogadaComputador.jogada == ObjetoEnum.Pedra ? "Você foi ganhou!" : "Maquina Ganhou!",
                ObjetoEnum.Tesoura => jogadaComputador.jogada == ObjetoEnum.Papel ? "Você foi ganhou!" : "Maquina Ganhou!",
                _ => "Opção invalida"
            };


            return new ResultadoJogadaDTO(jogadaJogador.ToString(), jogadaComputador.jogada.ToString(), resultado);
        }
    }
}
