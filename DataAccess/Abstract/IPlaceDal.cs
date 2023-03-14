using Entities.Concrete;
using Entities.DTOs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPlaceDal : IEntityRepository<Place>
    {
        List<PlaceDetailDto> GetPlaceDetail();

    }
}
