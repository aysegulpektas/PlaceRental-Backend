using Core.Entities;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Place:IEntity
    {
        public int PlaceId { get; set; }
        public int CategoryId { get; set; }
        public string PlaceName { get; set; }
        public string PlaceDescription { get; set; }
        public decimal PlacePrice { get; set; }

    }
}
