using AutoMapper;
using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Application.UseCases.CreateJogada
{
    public class GetJogadaComputerMapper : Profile
    {
        public GetJogadaComputerMapper()
        {
            CreateMap<ObjetoEnum, GetJogadaComputerResponse>().ConstructUsing(x => new GetJogadaComputerResponse(x));
        }
    }
}
