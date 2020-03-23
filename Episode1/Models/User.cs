using System;
using System.Collections.Generic;
using System.Text;

namespace Episode1.Models
{
    public class User
    {
        private ISet<Order> _orders = new HashSet<Order>();
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public decimal Funds { get; private set; }
       

        public User(string email, string password)

        {
            SetEmail(email);
            SetPassword(password);
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is incorrect.");
            }

            if(Email== email)
            {
                return;
            }

            Email = email;
            
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password is incorrect.");
            }

            if (Password == password)
            {
                return;
            }

            Password = password;
            Update();
        }

        public void SetAge(int age)
        {
            if(age<13)
            {
                throw new Exception("Age must be greater or equile to 13.");
            }

            if (Age == age)
            {
                return;
            }

            Age = age;
            Update();
        }

        public void Activate ()
        {
            if(IsActive)
            {
                return;
            }

            IsActive = true;
            Update();
        }

        public void Deactivate()
        {
            if (!IsActive)
            {
                return;
            }

            IsActive = false;
            Update();
        }

        public void IncreaseFunds(decimal funds)
        {
            if (funds <= 0)
            {
                throw new Exception("Funds must be greater then 0.");
            }
            Funds += funds;
            Update();
        }


        public void PurchaseOrder(Order order)
        {
            if (!IsActive)
            {
                throw new Exception("Only active user can purchase an order.");
            }

            decimal orderPrice = order.TotalPrice;
            if(Funds - orderPrice < 0)
            {
                throw new Exception("You don't have enought money.");
            }

            order.Purchase();
            Funds -= orderPrice;
            _orders.Add(order);
            Update();
        }

        private void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }

    }
}
