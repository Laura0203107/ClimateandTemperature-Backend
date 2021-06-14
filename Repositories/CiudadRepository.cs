using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClimateApi.Models;
using CiudadesApi.Data;

namespace ClimateApi.Repositories
{
    public class CiudadRepository : ICiudadRepository
    {
        private readonly IDataContext _context;
        public CiudadRepository(IDataContext context)
        {
            _context = context;
        }
        public async Task Add(ciudades ciudad)
        {
            _context.Ciudades.Add(ciudad);
           await _context.SaveChangesAsync();
        }
        
        public async Task  Delete(int idciudad)
        {
                var itemToRemove = await _context.Ciudades.FindAsync(idciudad);
                if (itemToRemove == null)
                    throw new NullReferenceException();

                _context.Ciudades.Remove(itemToRemove);
                await _context.SaveChangesAsync();
        }

        public async Task Update(ciudades ciudad)
    {
        var itemToUpdate = await _context.Ciudades.FindAsync(ciudad.idciudad);
        if (itemToUpdate == null)
            throw new NullReferenceException();
        itemToUpdate.nombre = ciudad.nombre;
        await _context.SaveChangesAsync();
    }

        public async Task<ciudades> Get(int id)
        {
        return await _context.Ciudades.FindAsync(id);
        }
 
        public async Task<IEnumerable<ciudades>> GetAll()
        {
        return await _context.Ciudades.ToListAsync();
        }
    }
}