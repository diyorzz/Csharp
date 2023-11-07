using Bogus;
using Inheritance.Models;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            UpdateDatabase();
            Console.WriteLine("Hello, World!");

        }
        static void UpdateDatabase()
        {
            using var context=new DatabaseDbContext();
            var faker = new Faker();
            //context.Products.Add(new Product
            //{
            //    Name = faker.Commerce.ProductName(),
            //    Price = faker.Random.Number(100, 10000),
            //    ValidityTime = faker.Random.Number(1, 6)
            //});

            context.Fruits.Add(new Fruits
            {
                Name = faker.Commerce.ProductName(),
                Price = faker.Random.Number(100, 10000),
                ValidityTime = faker.Random.Number(1, 6),
                SaveTemperature = faker.Random.Number(12, 25)
            });
            //context.Waters.Add(new Waters
            //{
            //    Name = faker.Commerce.ProductName(),
            //    Price = faker.Random.Number(100, 10000),
            //    ValidityTime = faker.Random.Number(1, 6),
            //    Amount = faker.Random.Double(1, 2.0)
            //});
            context.StillWater.Add(new StillWater
            {
                Name = faker.Commerce.ProductName(),
                Price = faker.Random.Number(100, 10000),
                ValidityTime = faker.Random.Number(1, 6),
                Amount = faker.Random.Double(1, 2.0),
                SaveTemprature = faker.Random.Double(10.0, 25.0)
            });
            context.CarbonatedWater.Add(new CarbonatedWater
            {
                Name = faker.Commerce.ProductName(),
                Price = faker.Random.Number(100, 10000),
                ValidityTime = faker.Random.Number(1, 6),
                Amount = faker.Random.Double(1, 2.0),
                Carbonate = faker.Random.Double(10.24)
            });

            context.SaveChanges();
        }
    }
}