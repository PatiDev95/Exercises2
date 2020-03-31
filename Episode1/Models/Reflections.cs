using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Episode1.Models
{
    class Reflections
    {
        public void Test()
        {
            var user = new User("user1@gmail.com", "secret");
            var type = user.GetType();
            Console.WriteLine($"{type.Name} {type.Namespace} {type.FullName}");

            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"{method.Name}");
            }

            user.Activate();
            Console.WriteLine($"Is activate: {user.IsActive}.");

            var deactivateMethod = methods.First(x => x.Name == "Deactivate");
            deactivateMethod.Invoke(user, null);
            Console.WriteLine($"Is active: {user.IsActive}.");

            Console.WriteLine($"Email:{user.Email}.");
            var setEmailMethod = type.GetMethod("SetEmail");
            setEmailMethod.Invoke(user, new[] { "user2@gmail.com" });
            Console.WriteLine($"Email: {user.Email}.");

            var email = type.GetProperty("Email").GetValue(user);
            Console.WriteLine($"Email: {email}.");

            var databaseTypes = Assembly.GetEntryAssembly()
                                        .GetTypes()
                                        .Where(x => x.Name.Contains("Databae"));

            foreach(var databaseType in databaseTypes)
            {
                Console.WriteLine($"{databaseType}");
            }

            var user2 = Activator.CreateInstance(typeof(User), new[] { "user2@email.com", "secret" });
                Console.WriteLine($"{user.Email}");


        }
    }
}
