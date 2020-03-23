using Episode1.Models;
using System;

namespace Episode1
{
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

    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello World!");
            //    Order order1 = new Order(1, 100);
            //    User User = new User("blabla@cos.com", "jakieścoś");

            //TYPY GENERYCZNE ZAKUMAĆ
            //int[] wydatki = new int[10];
            //int jakisWydatek  = wydatki[1];

            //Tablica<int> wydatki2 = new Tablica<int>(wydatki);
            //int innyWydatek = wydatki2.znajdz(1);

            //string[] imiona = new string[3];
             
            //Tablica<string> dupa = new Tablica<string>(imiona);
            //dupa.znajdz(1);


            Race race = new Race();
            race.Begin();

           // User.Orders.Add();

        }
    }
}
