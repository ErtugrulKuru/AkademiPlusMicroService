using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.EntityLayer.Entities;

namespace AkademiPlusMicroService.DataAccessLayer.Abstract
{
    public interface ICargoDetailDal:IGenericDal<CargoDetail>
    {
        int TotalCargoCount();
    }
}
