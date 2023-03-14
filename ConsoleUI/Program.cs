using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlaceTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void PlaceTest()
        {
            PlaceManager placeManager = new PlaceManager(new EfPlaceDal(), new CategoryManager(new EfCategoryDal()));
            var result = placeManager.GetPlaceDetails();
            if (result.Success==true)
            {
                foreach (var place in result.Data)
                {
                    Console.WriteLine(place.PlaceName + "/" + place.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
