using System;
using System.Collections.Generic;
using LambdaUserEngine;
using LambdaUserEngine.Servies;

class Program
{
    static void Main(string[] args)
    {
        List<User> users = new List<User>
        {
            new User { FirstName = "Dima", SecondName = "Aboba" },
            new User { FirstName = "Dima", SecondName = "Spencer" },
            new User { FirstName = "Nazar", SecondName = "Pirat" },
            new User { FirstName = "Dasha", SecondName = "Flower" }
        };

        string nameToFilter = "Dima";

        UserFilter userFilter = new UserFilter();
        List<string> filteredNames = userFilter.FilterOperation(users, user => user.FirstName == nameToFilter);

        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }

        UserMapper mapper = new UserMapper();

        List<string> results = mapper.MapOperation(users, user => $"{user.FirstName} - {user.FirstName.Length}");

        foreach (string item in results)
        {
            Console.WriteLine(item);
        }

        UserProcess userProcess = new UserProcess();

        List<User> processedUsers = userProcess.ProcessUsers(users, user => new User
        {
            FirstName = user.FirstName.ToUpper(),
            SecondName = user.SecondName.ToUpper()
        });

        foreach (var user in processedUsers)
        {
            Console.WriteLine($"{user.FirstName} {user.SecondName}");
        }
    }
}