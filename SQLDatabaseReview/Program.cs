using System;
using System.Collections.Generic;
using DbConnection;

namespace DbConnection
{
    class Program
    {
        public static void getUser(){
            List<Dictionary<string, object>> users = new List<Dictionary<string, object>>();

            users = DbConnector.Query("select * from Users");

            Console.WriteLine("List of users in database:");
            foreach (Dictionary<string, object> allUsers in users)
            {
                Console.WriteLine(" - " + allUsers["FirstName"]);
            }
        }

        public static void addUser(string firstName, string lastName, int favoriteNumber){
            DbConnector.Execute($"insert into Users(FirstName, LastName, FavoriteNumber) values('{firstName}', '{lastName}', '{favoriteNumber}')");
            Console.WriteLine($"Successfully added {firstName} {lastName} to the database");
        }
        public static void updateUser(string firstName, int userId){
            DbConnector.Execute($"update Users set FirstName='{firstName}' where id={userId}");
        }
        public static void deleteUser(int userId){
            DbConnector.Execute($"delete from Users where id={userId}");
        }
        static void Main(string[] args){
            // addUser("Chris", "Fields", 25);
            getUser();
            updateUser("Yem", 2);
            getUser();
            updateUser("Tania", 2);
            getUser();
            deleteUser(6);
            getUser();
        }
    }
}
