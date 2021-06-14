using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClimateApi.Models;
 
namespace CiudadesApi.Data
{
    public interface IDataContext
    {
          DbSet<ciudades> Ciudades {get; set;}
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}