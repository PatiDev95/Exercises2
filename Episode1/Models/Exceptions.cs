using System;
using System.Collections.Generic;
using System.Text;

namespace Episode1.Models
{
    public class Exceptions
    {
        public void Test()
        {
            try
            {
                User user = new User("email@email.com", "haslo");
                user = null;

                throw new ArgumentNullException(nameof(user));

                //Sign up user...
                //Email in use
                throw new Exception("Email in use.");
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine($"Null error: {exception}");
            }

            catch (Exception exception)
            {
                Console.WriteLine($"An error: {exception}");
            }
            Console.WriteLine("OK");
        }
    }
}
