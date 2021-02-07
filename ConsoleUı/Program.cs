using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Name);
                    
            }


        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var a = carManager.GetAll();

            foreach (var item in a)
            {
                Console.WriteLine(item.Name);
            }

            var brand = carManager.GetCarsByBrandId(1);
            var color = carManager.GetCarsByColorId(2);

            foreach (var item in brand)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ModelYear);
            }
            foreach (var item in color)
            {
                Console.WriteLine(item.DailyPrice);
            }

            Car cars = new Car()
            {
                BrandId = 1,
                Code = "code",
                ColorId = 3,
                CreatedDate = DateTime.Now,
                DailyPrice = 100,
                Description = "",
                IsActive = true,
                ModelYear = 2020,
                ModifiedDate = DateTime.Now,
                Name = "test"
            };
            if (cars.Name.Length > 2 && cars.DailyPrice > 0)
            {
                carManager.Add(cars);
                Console.WriteLine("Added");
            }

        }
    }
}
