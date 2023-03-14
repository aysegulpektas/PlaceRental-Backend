using Core.Entities;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.Entities
{
    public class PlaceDetailDto:IDto
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string CategoryName { get; set; }
        public decimal PlacePrice { get; set; }
    }
}
