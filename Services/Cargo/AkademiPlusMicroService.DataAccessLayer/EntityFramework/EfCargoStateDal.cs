using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.DataAccessLayer.Abstract;
using AkademiPlusMicroService.DataAccessLayer.Context;
using AkademiPlusMicroService.DataAccessLayer.Repository;
using AkademiPlusMicroService.EntityLayer.Entities;

namespace AkademiPlusMicroService.DataAccessLayer.EntityFramework
{
    public class EfCargoStateDal : GenericRepository<CargoState>, ICargoStateDal
    {
        private readonly CargoContext _context;
        public EfCargoStateDal(CargoContext cargoContext) : base(cargoContext)
        {
            _context = cargoContext;
        }
    }
}
