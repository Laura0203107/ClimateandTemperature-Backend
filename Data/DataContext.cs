using Microsoft.EntityFrameworkCore;
using ClimateApi.Models;
 
namespace CiudadesApi.Data
{
    public class DataContext: DbContext, IDataContext
    {  
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
             
        }
 
        public DbSet<ciudades> Ciudades { get; set; }
    }
}