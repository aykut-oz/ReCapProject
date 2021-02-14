using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            carManager.Add(new Car() { BrandId = 1, Code="1-t", Name="Opel", ColorId=1, CreatedDate=DateTime.Now, DailyPrice=200, Description="Araç Arızası Giderildi", IsActive=true, ModelYear=2021 });

            Console.WriteLine("-- CARS --");
            foreach (var car in carManager.GetAll().Data)
                Console.WriteLine("{0} - {1} ", car.Id, car.Description);

            Console.WriteLine("-- BRANDS --");
            foreach (var brand in brandManager.GetAll().Data)
                Console.WriteLine("{0} - {1} ", brand.Id, brand.Name);

        }


    }
}
