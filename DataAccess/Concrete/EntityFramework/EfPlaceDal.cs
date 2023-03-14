using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlaceDal : EfEntityRepositoryBase<Place, NorthwindContext>, IPlaceDal
    {
        public List<PlaceDetailDto> GetPlaceDetail()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Places
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new PlaceDetailDto
                             {
                                 PlaceId = p.PlaceId,
                                 PlaceName = p.PlaceName,
                                 CategoryName = c.CategoryName,
                                 PlacePrice = p.PlacePrice
                             };
                return result.ToList();
            }
        }
    }
}
