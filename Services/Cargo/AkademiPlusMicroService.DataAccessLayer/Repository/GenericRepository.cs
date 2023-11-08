using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.DataAccessLayer.Abstract;
using AkademiPlusMicroService.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusMicroService.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly CargoContext _cargoContext;

        public GenericRepository(CargoContext cargoContext)
        {
            _cargoContext = cargoContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _cargoContext.AddAsync(entity);
            await _cargoContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _cargoContext.Remove(entity);
            await _cargoContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _cargoContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _cargoContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _cargoContext.Update(entity);
            await _cargoContext.SaveChangesAsync();
        }
    }
}
