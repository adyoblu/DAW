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
    public class DepozitController : ControllerBase
    {
        private readonly IDepozitServices _depozitServices;

        public DepozitController(IDepozitServices depozitServices)
        {
            _depozitServices = depozitServices;
        }

        [HttpGet("GetAllDepozit")]
        public async Task<ObjectResult> GetAllDepozitAsync()
        {
            List<Depozit> result = await _depozitServices.DepozitRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("GetDepozit/{id}")]
        public async Task<ObjectResult> GetDepozitAsync([FromRoute] int id)
        {
            Depozit result = await _depozitServices.DepozitRepository.GetByIdAsync(id);

            return Ok(result);
        }


        [HttpPost("CreateDepozit")]
        public async Task<ObjectResult> CreateDepozitAsync([FromBody] GeneralDepozitRequest request)
        {
            Depozit result = await _depozitServices.DepozitRepository.CreateAsync(request.ToDTO());
            await _depozitServices.CommitChanges();

            return Ok(result);
        }

        [HttpPut("UpdateDepozit/{id}")]
        public async Task<ObjectResult> UpdateDepozitAsync([FromBody] GeneralDepozitRequest request, [FromRoute] int id)
        {
            Depozit result = _depozitServices.DepozitRepository.Update(request.ToDTO(id));
            await _depozitServices.CommitChanges();

            return Ok(result);
        }

        [HttpDelete("DeleteDepozit/{id}")]
        public async Task<ObjectResult> DeleteDepozitAsync([FromRoute] int id)
        {
            Depozit depozit = await _depozitServices.DepozitRepository.GetByIdAsync(id);
            _depozitServices.DepozitRepository.Delete(depozit);
            await _depozitServices.CommitChanges();

            return Ok(depozit);
        }
    }
}