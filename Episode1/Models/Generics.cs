using System;
using System.Collections.Generic;
using System.Text;

namespace Episode1.Models
{ 
    public class Result<T>
    {
        public T Item { get; set }
    }

    public class GenericOrderProcessor
    {
        public Order ProcessOrder(string email, int orderId)
        {
            return new Order(1, 100);
        }
    }

    public class Generics
    {
        public void Test()
        {
            List<User> user = new List<User>();
        }
    }
}
