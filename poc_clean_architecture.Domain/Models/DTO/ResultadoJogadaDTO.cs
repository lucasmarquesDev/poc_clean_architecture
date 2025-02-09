﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Domain.Models.DTO
{
    public class ResultadoJogadaDTO
    {
        public string JogadaJogador { get; set; }
        public string JogadaMaquina { get; set; }
        public string Resultado { get; set; }

        public ResultadoJogadaDTO(string jogadaJogador, string jogadaMaquina, string resultado)
        {
            JogadaJogador = jogadaJogador;
            JogadaMaquina = jogadaMaquina;
            Resultado = resultado;
        }
    }
}
