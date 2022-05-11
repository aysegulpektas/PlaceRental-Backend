using Core.Results;
using Entities.Concrete;
using Entities.DTOs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface IPlaceService
    {
        IDataResult<List<Place>> GetAll();
        IDataResult<List<Place>> GetAllByCategoryId(int id);
        IDataResult<List<Place>> GetByPlacePrice(decimal min, decimal max);
        IDataResult<List<PlaceDetailDto>> GetPlaceDetails();

        IDataResult<Place> GetById(int placeId);

        IResult Add(Place place);
        IResult Update(Place place);
        IResult Delete(Place place);

        IResult AddTransactionalTest(Place place);
    }
}
