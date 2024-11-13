using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBTG.Domain.Models.DTO;

namespace TesteBTG.Application.UseCases.CreateJogada
{
    public class CreateJogadaMapper : Profile
    {
        public CreateJogadaMapper()
        {
            CreateMap<ResultadoJogadaDTO, CreateJogadaResponse>();
        }
    }
}
