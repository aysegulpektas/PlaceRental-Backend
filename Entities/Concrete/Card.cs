using Core.Entities;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Card : IEntity
    {
        public int CardId { get; set; }
        public int UserId { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public DateTime CardDate { get; set; }
        public string CVV { get; set; }
    }
}
