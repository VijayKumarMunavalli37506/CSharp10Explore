using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp10Explore
{
    class ProgramExt
    {
      
        


        // C&C
        class Vehicle
        {
        }

        class Car : Vehicle { }

        class Bus : Vehicle { }

        //Covariance
        interface ICovariant<out T>
        {
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

    }
}