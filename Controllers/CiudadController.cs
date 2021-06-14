using Microsoft.AspNetCore.Mvc;
using ClimateApi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClimateApi.Models;


namespace ClimateApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CiudadController: ControllerBase
    {
        private readonly ICiudadRepository _ciudadRepository;
        public CiudadController(ICiudadRepository ciudadRepository)
        {
            _ciudadRepository = ciudadRepository;
        }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ciudades>>> GetCiudades()
    {
        var ciudades = await _ciudadRepository.GetAll();
        return Ok(ciudades);
    }
 
    [HttpGet("{idciudad}")]
    public async Task<ActionResult<ciudades>> GetCiudad(int idciudad)
    {
        var ciudad = await _ciudadRepository.Get(idciudad);
        if(ciudad == null)
            return NotFound();
 
        return Ok(ciudad);
    }
 
    [HttpPost]
    public async Task<ActionResult> CreateCiudad(ciudades createCiudad)
    {
        ciudades ciudad = new()
        {
            nombre = createCiudad.nombre,
            codigopostal = createCiudad.codigopostal,
            temperatura = createCiudad.temperatura,
            humedad = createCiudad.humedad,
        };
        
        await _ciudadRepository.Add(ciudad);
        return Ok();
    }
 
    [HttpDelete("{idciudad}")]
    public async Task<ActionResult> DeleteCiudad(int idciudad)
    {
        await _ciudadRepository.Delete(idciudad);
        return Ok();
    }

    }
}