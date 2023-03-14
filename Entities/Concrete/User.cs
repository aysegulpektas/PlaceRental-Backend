using System;
using Core.Entities;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
	public class User:IEntity
	{
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string ContactNumber { get; set; }
        public string City { get; set; }



    }
}

