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
    public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
    {
        private readonly CargoContext _context;
        public EfCargoDetailDal(CargoContext cargoContext) : base(cargoContext)
        {
            _context = cargoContext;
        }

        public int TotalCargoCount()
        {
            return _context.CargoDetails.Count();
        }
    }
}
