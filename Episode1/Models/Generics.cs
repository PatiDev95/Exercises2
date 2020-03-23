using System;
using System.Collections.Generic;
using System.Text;

namespace Episode1.Models
{ 
    public class Result<T>
    {
        public T Item { get; set; }

        public bool IsValid { get; set; }

        public string Error { get; set; }
    }

    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }
    }

    public class Triple<TFirst, TSecond, TThird> : Pair<TFirst, TSecond>
    {
        public TThird Third { get; set; }
    }
    public class GenericOrderProcessor
    {
        public Result <Order> ProcessOrder(string email, int orderId)
        {
            Order order = new Order(1, 100);

            return new Result<Order>
            {
                Item = order
            };
        }
        public void LogOrder<TOrder, TSecondOrder>(TOrder order, TSecondOrder secondOrder) where TOrder : Order where TSecondOrder : Order
        {

        }
    }

    

    public class Generics
    {
        public void Test()
        {
            GenericOrderProcessor orderProcessor = new GenericOrderProcessor();
            Result<Order> result = orderProcessor.ProcessOrder("email@email.com", 1);

            Pair<int, string> pair = new Pair<int, string>();
            Triple<int, string, bool> triple = new Triple<int, string, bool>();

            ReferenceResult<User> intResult = new ReferenceResult<User>();
            ValueResult<int> valueResult = new ValueResult<int>();
        }
    }

    public class ReferenceResult<T> where T : class
    {
        public T Result { get; set; }
    }
    public class ValueResult<T> where T : struct
    {
        public T Result { get; set; }
    }
    //TYPY GENERYCZNE - ZAKUMAĆ
    //public class TablicaIntow
    //{
    //    private int[] Array;

    //    public TablicaIntow(int[] array)
    //    {
    //        Array = array;
    //    }

    //    public int znajdz(int index)
    //    {
    //        if(Array[index] != null)
    //        {
    //            return 0;
    //        }
    //        return Array[index];
    //    }
    //}

    //public class TablicaStringow
    //{
    //    private string[] Array;

    //    public TablicaStringow(string[] array)
    //    {
    //        Array = array;
    //    }

    //    public string znajdz(int index)
    //    {
    //        if (Array[index] != null)
    //        {
    //            return null;
    //        }
    //        return Array[index];
    //    }
    //}

    //public class Tablica<T>
    //{
    //    private T[] Array;

    //    public Tablica(T[] array)
    //    {
    //        Array = array;
    //    }

    //    public T znajdz(int index)
    //    {
    //        if (Array[index] != null)
    //        {
    //            return default;
    //        }
    //        return Array[index];
    //    }
    //}


    //TYPY GENERYCZNE ZAKUMAĆ
    //int[] wydatki = new int[10];
    //int jakisWydatek  = wydatki[1];

    //Tablica<int> wydatki2 = new Tablica<int>(wydatki);
    //int innyWydatek = wydatki2.znajdz(1);

    //string[] imiona = new string[3];

    //Tablica<string> dupa = new Tablica<string>(imiona);
    //dupa.znajdz(1);


}
