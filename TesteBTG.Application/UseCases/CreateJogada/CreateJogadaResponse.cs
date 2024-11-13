using TesteBTG.Domain.Models.Enum;

namespace TesteBTG.Application.UseCases.CreateJogada
{
    public sealed class CreateJogadaResponse
    {
        public string JogadaJogador { get; set; }
        public string JogadaMaquina { get; set; }
        public string Resultado { get; set; }

        public CreateJogadaResponse(string jogadaJogador, string jogadaMaquina, string resultado)
        {
            JogadaJogador = jogadaJogador;
            JogadaMaquina = jogadaMaquina;
            Resultado = resultado;
        }
    }
}