using AutoMapper;
using poc_clean_architecture.Domain.Models.Enum;

namespace poc_clean_architecture.Application.UseCases.CreateJogada
{
    public class CreateJogadaMapper : Profile
    {
        public CreateJogadaMapper()
        {
            CreateMap<ObjetoEnum, CreateJogadaResponse>().ConstructUsing(x => new CreateJogadaResponse(x));
        }
    }
}
