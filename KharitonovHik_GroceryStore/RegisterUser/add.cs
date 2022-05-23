using HashPasswords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterUser
{
    class add
    {
        public static void Main()
        {
            Console.Write("Создание новой учетной записи для пользователя\n\n");
            string login;
            string password;
            string surname;
            string name;

            Console.Write("Введите логин пользователя: ");
            login = Console.ReadLine();
            Console.Write("Введите пароль пользователя: ");
            password = Console.ReadLine();
            Console.Write("Введите имя пользователя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию пользователя: ");
            surname = Console.ReadLine();
            password = Hash.GetHashPassword(password);

            Console.WriteLine($"Хэшированный пароль пользователя: {password}\nУчетная запись добавлена");
            Model.kataev2Entities1 kataev2Entities1 = new Model.kataev2Entities1();
            Model.Users users = new Model.Users()
            {
                Login = login,
                Password = password,
                Name = name,
                Surname = surname,
            };
            kataev2Entities1.Users.Add(users);
            kataev2Entities1.SaveChanges();
            Console.ReadLine();
        }
    }
}
