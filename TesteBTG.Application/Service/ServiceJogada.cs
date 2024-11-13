using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBTG.Application.UseCases.CreateJogada;
using TesteBTG.Domain.Models.DTO;
using TesteBTG.Domain.Models.Enum;

namespace TesteBTG.Application.Service
{
    public class ServiceJogada : IServiceJogada
    {
        public ServiceJogada() { }

        public async Task<ResultadoJogadaDTO> ProcessarJogada(ObjetoEnum jogadaJogador)
        {
            var jogadaComputador = (ObjetoEnum)Random.Shared.Next(0, 3);

            if (jogadaComputador.GetHashCode() == jogadaJogador.GetHashCode())
                return new ResultadoJogadaDTO(jogadaJogador.ToString(), jogadaComputador.ToString(), "Empate");

            var resultado = jogadaJogador switch
            {
                ObjetoEnum.Pedra => jogadaComputador == ObjetoEnum.Tesoura ? "Você foi ganhou!" : "Computador Ganhou!",
                ObjetoEnum.Papel => jogadaComputador == ObjetoEnum.Pedra ? "Você foi ganhou!" : "Computador Ganhou!",
                ObjetoEnum.Tesoura => jogadaComputador == ObjetoEnum.Papel ? "Você foi ganhou!" : "Computador Ganhou!",
                _ => "Opção invalida"
            };


            return new ResultadoJogadaDTO(jogadaJogador.ToString(), jogadaComputador.ToString(), resultado);
        }
    }
}
