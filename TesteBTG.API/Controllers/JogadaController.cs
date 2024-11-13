using MediatR;
using Microsoft.AspNetCore.Mvc;
using TesteBTG.Application.UseCases.CreateJogada;
using TesteBTG.Domain.Models.Enum;

namespace TesteBTG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadaController : ControllerBase
    {
        IMediator _mediator;

        public JogadaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "Jogada")]
        public async Task<IActionResult> Post([FromBody] ObjetoEnum jogada)
        {
            var resulJogada = await _mediator.Send(new CreateJogadaRequest(jogada));

            return Ok(resulJogada);
        }
    }
}
