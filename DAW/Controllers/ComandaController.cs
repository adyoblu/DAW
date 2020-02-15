using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAW.Domain.ExtensionMethods;
using DAW.Domain.Models;
using DAW.Domain.Requests;
using DAW.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAW.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
            private readonly IComandaServices _comandaServices;

            public ComandaController(IComandaServices comandaServices)
            {
                _comandaServices = comandaServices;
            }

            [HttpGet("Toatecomenzile")]
            public async Task<ObjectResult> ToateComenzileAsync()
            {
                List<Comanda> result = await _comandaServices.ComandaRepository.GetAllAsync();

                return Ok(result);
            }

            [HttpGet("GetComanda/{id}")]
            public async Task<ObjectResult> GetComandaAsync([FromRoute] int id)
            {
                Comanda result = await _comandaServices.ComandaRepository.GetByIdAsync(id);

                return Ok(result);
            }


            [HttpPost("CreateComanda")]
            public async Task<ObjectResult> CreateComandaAsync([FromBody] GeneralComandaRequest request)
            {
                Comanda result = await _comandaServices.ComandaRepository.CreateAsync(request.ToDTO());
                await _comandaServices.CommitChanges();

                return Ok(result);
            }

            [HttpPut("UpdateComanda/{id}")]
            public async Task<ObjectResult> UpdateComandaAsync([FromBody] GeneralComandaRequest request, [FromRoute] int id)
            {
                Comanda result = _comandaServices.ComandaRepository.Update(request.ToDTO(id));
                await _comandaServices.CommitChanges();

                return Ok(result);
            }

            [HttpDelete("DeleteComanda/{id}")]
            public async Task<ObjectResult> DeleteComandaAsync([FromRoute] int id)
            {
                Comanda comanda = await _comandaServices.ComandaRepository.GetByIdAsync(id);
                _comandaServices.ComandaRepository.Delete(comanda);
                await _comandaServices.CommitChanges();

                return Ok(comanda);
            }

        }
}