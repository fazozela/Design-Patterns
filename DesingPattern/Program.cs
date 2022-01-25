//using DesingPattern.Dependency_Injection;
using DesingPattern.BuilderPattern;
using DesingPattern.Factory;
using DesingPattern.Models;
using DesingPattern.RepositoryPattern;
using DesingPattern.StatePattern;
using DesingPattern.Strategypattern;
using DesingPattern.UnitOfWorkPattern;
using System;
using System.Linq;

namespace DesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SINGLETON
            //var singleton = Singleton.Singleton.Instance;
            /*var log = Singleton.Log.Instance;
            log.Save("a");
            log.Save("b");*/



            //FACTORY
            //Creamos las fábricas
            /*SalesFactory storeSaleFactory = new StoreSaleFactory(10);
            SalesFactory internetSaleFactory = new InternetSaleFactory(5);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(20);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(20);*/



            //DEPENDENCY INJECTION
            /*var beer = new Beer("Huari-Chocolate", "Huari");
            var chocoHuari = new DrinkWithBeer(200, 50, beer);
            chocoHuari.Build();*/



            //Repository
            /*using (var context = new DesignPatternsContext())
            {
                var lst = context.Beers.ToList();
                Console.WriteLine($"** CERVEZAS EN BASE DE DATOS **");

                foreach (var beer in lst)
                {
                    Console.WriteLine(beer.Name);
                }
            }*/

            /*using (var context = new DesignPatternsContext())
            {
                var beerRepository = new BeerRepository(context);
                var beer = new Beer();
                beer.BeerId = 3;
                beer.Name = "Corona";
                beer.Style = "Pilsner";

                beerRepository.Add(beer);
                beerRepository.Save();

                foreach (var item in beerRepository.Get())
                {
                    Console.WriteLine(item.Name);
                }

            }*/

            /*using (var context = new DesignPatternsContext())
            {
                var beerRepository = new Repository<Beer>(context);

                var beer = new Beer() { Name = "Potosina", Style = "Gringa" };
                beerRepository.Add(beer);
                beerRepository.Save();

                foreach (var item in beerRepository.Get())
                {
                    Console.WriteLine($"{item.BeerId} {item.Name}");
                }

                var brandRepository = new Repository<Brand>(context);
                var brand = new Brand();
                brand.Name = "Taquiña";
                brandRepository.Add(brand);
                brandRepository.Save();

                foreach (var item in brandRepository.Get())
                {
                    Console.WriteLine($"{item.Name}");
                }
            }*/



            //UNIT OF WORK
            /*using (var context = new DesignPatternsContext())
            {
                var unitOfWork = new UnitOfWork(context);

                var beers = unitOfWork.Beers;
                var beer = new Beer() { Name = "Cat", Style = "Strong" };
                beers.Add(beer);

                var brands = unitOfWork.Brands;
                var brand = new Brand() { Name = "Cat"};
                brands.Add(brand);

                unitOfWork.Save();
            }*/



            //STRATEGY
            /*var context = new Context(new CarStrategy());
            context.Run();
            context.Strategy = new MotoStrategy();
            context.Run();
            context.Strategy = new BicicleStrategy();
            context.Run();*/



            //BUILDER
            /*var builder = new PreparedAlcoholicDrinkConcreteBuilder();
            var barmanDirector = new BarmanDirector(builder);

            barmanDirector.PreparedMargarita();
            //barmanDirector.PreparedPinaColada();

            var preparedDrink = builder.GetPreparedDrink();
            Console.WriteLine(preparedDrink.Result);*/



            //STATE PATTERN
            var customercontext = new CustomerContext();
            Console.WriteLine(customercontext.GetState());

            customercontext.Request(100);
            Console.WriteLine(customercontext.GetState());

            customercontext.Request(50);
            Console.WriteLine(customercontext.GetState());

            customercontext.Request(100);
            Console.WriteLine(customercontext.GetState());

            customercontext.Request(50);
            Console.WriteLine(customercontext.GetState());

            customercontext.Request(50);
            Console.WriteLine(customercontext.GetState());
        }
    }
}
