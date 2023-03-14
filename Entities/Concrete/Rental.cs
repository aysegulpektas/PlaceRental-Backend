using Core.Entities;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int RentId { get; set; }
        public int CustomerId { get; set; }
        public int PlaceId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
