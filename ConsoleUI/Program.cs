using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCoreCarDal());
            Car car1 = new Car { Id= 1 ,BrandId = 1, ColorId = 4, ModelYear = 2017, DailyPrice = 5, Description = "Megane Otomatik" };
            carManager.AddCar(car1);



            //foreach (var item in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(item.Description);
            //}
        }

    }
}
