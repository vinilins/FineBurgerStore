using ProjectStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStore
{
    public class UserManager : DataBaseManager
    {
        private static UserManager _instance;

        public static UserManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserManager();
            }
            return _instance;
        }

        public List<User> UsersList { get; set; }

        public UserManager():base()
        {/*
            UsersList = new List<User>()
            {
                new User { Email = "admin", Password = "1234", Name= "Administrador"}
            };
        */
            if (!FineBurgerContext.Users.Any())
            {
                var user = new User { Email = "admin", Password = "1234", Name = "Administrador" };
                FineBurgerContext.Users.Add(user);
                FineBurgerContext.SaveChanges();
            }
            UsersList = FineBurgerContext.Users.ToList();
        }

        public void AddList(User newUser)
        {
            FineBurgerContext.Users.Add(newUser);
            FineBurgerContext.SaveChanges();
            UsersList = FineBurgerContext.Users.ToList();
        }

        public bool SearchList(String email, String Password)
        {
            return UsersList.Any(u => u.Email.Equals(email) && u.Password.Equals(Password));
        }

        internal void RemoveList(string buttonValue)
        {
            var userForDelete = UsersList.First(u => u.Email.Equals(buttonValue));
            FineBurgerContext.Users.Remove(userForDelete);
            FineBurgerContext.SaveChanges();
            UsersList = FineBurgerContext.Users.ToList();
        }
    }
}
