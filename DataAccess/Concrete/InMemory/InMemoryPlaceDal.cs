using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryPlaceDal : IPlaceDal
    {
        List<Place> _places;
        public InMemoryPlaceDal()
        {
            _places = new List<Place>
            {


            };
        }
        public void Add(Place place)
        {
            _places.Add(place);
        }

        public void Delete(Place place)
        {
            Place placeToDelete = _places.SingleOrDefault(p => p.PlaceId == place.PlaceId);
            _places.Remove(placeToDelete);
        }

        public List<Place> GetAll()
        {
            return _places;
        }

        public void Update(Place place)
        {
            Place placeToUpdate = _places.SingleOrDefault(p => p.PlaceId == place.PlaceId);
            placeToUpdate.CategoryId = place.CategoryId;
            placeToUpdate.PlaceDescription = place.PlaceDescription;
        }

        public List<Place> GetAllByCategory(int categoryId)
        {
            return _places.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Place> GetAll(Expression<Func<Place, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Place Get(Expression<Func<Place, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<PlaceDetailDto> GetPlaceDetail()
        {
            throw new NotImplementedException();
        }
    }
}
