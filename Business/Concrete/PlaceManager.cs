using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Results;
using Core.Utilities.Business;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PlaceManager : IPlaceService
    {
        IPlaceDal _placeDal;
        ICategoryService _categoryService;

        public PlaceManager(IPlaceDal placeDal, ICategoryService categoryService)
        {
            _placeDal = placeDal;
            _categoryService = categoryService;
        }

        [SecuredOperation("place.Add,admin")]
        [ValidationAspect(typeof(PlaceValidator))]
        [CacheRemoveAspect("IPlaceService.Get")]
        public IResult Add(Place place)
        {
            IResult result = BusinessRules.Run(CheckIfPlaceNameExists(place.PlaceName),
                CheckIfCategoryLimitExceded());

            if(result != null)
            {
                return result;
            }
      
            _placeDal.Add(place);
            return new SuccessResult(Messages.PlaceAdded);
        }

        public IResult Delete(Place place)
        {
            _placeDal.Delete(place);
            return new SuccessResult(Messages.PlaceDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Place>> GetAll()
        {
            return new SuccessDataResult<List<Place>>(_placeDal.GetAll(),Messages.PlacesListed);
        }

        public IDataResult<List<Place>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Place>>(_placeDal.GetAll(p => p.CategoryId == id));
        }

        [CacheAspect]
        //[PerformanceAspect(5)]
        public IDataResult<Place> GetById(int placeId)
        {
            return new SuccessDataResult<Place>(_placeDal.Get(p => p.PlaceId == placeId));
        }

        public IDataResult<List<Place>> GetByPlacePrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Place>>(_placeDal.GetAll(p => p.PlacePrice >= min && p.PlacePrice <= max));
        }

        public IDataResult<List<PlaceDetailDto>> GetPlaceDetails()
        {
            return new SuccessDataResult<List<PlaceDetailDto>>(_placeDal.GetPlaceDetail());
        }

        [ValidationAspect(typeof(PlaceValidator))]
        [CacheRemoveAspect("IPlaceService.Get")]
        public IResult Update(Place place)
        {
            _placeDal.Update(place);
            return new SuccessResult(Messages.PlaceUpdated);
        }

        [ValidationAspect(typeof(PlaceValidator))]
        //aynı isimde ürün eklenemez
        private IResult CheckIfPlaceNameExists(string placeName)
        {
            var result = _placeDal.GetAll(p => p.PlaceName == placeName).Any();
            if(result)
            {
                return new ErrorResult(Messages.PlaceNameAlreadyExists);
            }
            return new SuccessResult();
        }

        //kategori limiti kontrolü
        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _categoryService.GetAll();
            if(result.Data.Count > 20)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Place place)
        {
            Add(place);
            if (true)
            {

            }
            Add(place);
            return null;
        }
    }
}
