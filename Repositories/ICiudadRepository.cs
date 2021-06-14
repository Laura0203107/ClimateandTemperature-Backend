using System.Collections.Generic;
using System.Threading.Tasks;
using ClimateApi.Models;

namespace ClimateApi.Repositories
{
    public interface ICiudadRepository
    {
         Task<ciudades> Get(int idciudad);
         Task<IEnumerable<ciudades>> GetAll();          
         Task Add(ciudades ciudad);
         Task Delete(int idciudad);
         Task Update(ciudades ciudad);
        
    }

}