using SOLID_PRINCIPLES.LSP;
using SOLID_PRINCIPLES.OCP;
using System;


namespace CSharp10Explore
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*The Open-Closed Principle states that “software entities such as modules, classes, functions, etc. should be open for extension, but closed for modification“.*/
            Console.WriteLine("-----------Open Close Principle-------------");
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
          
           
            Console.WriteLine(FInvoiceAmount);
            Console.WriteLine("-----------Open Close Principle-------------");


            /*LSP -The Liskov Substitution Principle is a Substitutability principle in object-oriented programming Language. 
             * This principle states that, if S is a subtype of T, then objects of type T should be replaced with the objects of type S.“.*/

            Console.WriteLine("-----------Liskova  Principle Not Followed-------------");
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
            Console.WriteLine("-----------Liskova  Principle Not Followed-------------");


            Console.WriteLine("-----------Liskova  Principle Not Followed-------------");
            
            Console.WriteLine("-----------Liskova  Principle Not Followed-------------");


            /*ISP - Clients should not be forced to implement any methods they don’t use. Rather than one fat interface, 
             * numerous little interfaces are preferred based on groups of methods with each interface serving one submodule“.*/

            Console.WriteLine("-----------InterFace Segregation Principle Not Followed-------------");

            Console.WriteLine("-----------InterFace Segregation Principle Not Followed-------------");


            /* Dependency Inversion 
            high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions. 
            Secondly, abstractions should not depend upon details. Details should depend upon abstractions.*/



            ICovariant<Vehicle> covariant = (ICovariant<Bus>) null;
            IContraVariant<Car> contraVariant = (IContraVariant<Vehicle>)null;
            IComparable<Vehicle> comparable;
            
        }
       

        // C&C
        class Vehicle
        { 
        }

        class Car : Vehicle { }

        class Bus : Vehicle { }

        //Covariance
        interface ICovariant<out T> {
            T Name { get; }

            T Remove();
        }

        //Contravariance
        interface IContraVariant<in T>
        {
            void GetDeteails(T obj);

        }

        //IEnumerable(Of T) (T is covariant)
        //IEnumerator(Of T) (T is covariant)
        //IQueryable(Of T) (T is covariant)
        //IGrouping(Of TKey, TElement) (TKey and TElement are covariant)
        //IComparer(Of T) (T is contravariant)
        //IEqualityComparer(Of T) (T is contravariant)
        //IComparable(Of T) (T is contravariant)



        //Open Close Principle

    }
}
