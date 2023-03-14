using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        IPlaceService _placeService;

        public PlacesController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _placeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);       
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _placeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getallbycategoryid")]
        public IActionResult GetAllByCategoryId(int id)
        {
            var result = _placeService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Place place)
        {
            var result = _placeService.Add(place);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("update")]
        public IActionResult Update(Place place)
        {
            var result = _placeService.Update(place);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


    }
}
