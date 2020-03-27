using Episode1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Episode1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var user = new
            {
                Id = 1,
                Email = " ....",
                adress = new
                {
                    street = "krakowska 1"
                }
            };

            List<User> users = new List<User>();
            var diffrentUsers = users.Select(x => new { Email = x.Email });
            foreach(var diffrentUser in diffrentUsers)
            {
                diffrentUser.Email;
            }

        }
    }
}
