using MediatR;
using Microsoft.AspNetCore.Mvc;
using poc_clean_architecture.Application.Service;
using poc_clean_architecture.Application.UseCases.CreateJogada;
using poc_clean_architecture.Domain.Models.Enum;
using poc_clean_architecture.Persistence.Repositories;

namespace poc_clean_architecture.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadaController : ControllerBase
    {
        IServiceJogada _service;

        public JogadaController(IServiceJogada service)
        {
            _service = service;
        }

        [HttpPost(Name = "Jogada")]
        public async Task<IActionResult> Post([FromBody] ObjetoEnum jogada)
        {
            var resulJogada = await _service.ProcessarJogada(jogada);

            return Ok(resulJogada);
        }
    }
}
