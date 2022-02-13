using FacadePattern.Facade;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Facade is a structural design pattern that provides a simplified interface to a library, a framework, 
             * or any other complex set of classes.*/
            Console.WriteLine("----------------------Facde Pattern Implementation----------------------------\n");


            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();


            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }
}
