using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            IEnumerable<Artist> artistFromMountVernonResult = Artists.Where( str => str.Hometown == "Mount Vernon");

            foreach(JsonData.Artist artist in artistFromMountVernonResult){
                Console.WriteLine($"Name of artist from {artist.Hometown} is {artist.RealName} and their age is {artist.Age}.");
            }

            //Who is the youngest artist in our collection of artists?
            var youngestArtist = (from match in Artists orderby match.Age descending select new {match.ArtistName, match.Age}).Last();
            Console.WriteLine($"The youngest Artist is {youngestArtist.ArtistName} and his age is {youngestArtist.Age}.");

            //Display all artists with 'William' somewhere in their real name
            var artistsWilliam = (from match in Artists
                                    where match.RealName.Contains("William")
                                    select new {match.ArtistName, match.RealName});

            foreach(var william in artistsWilliam){
                Console.WriteLine($"{william.ArtistName} is {william.RealName}");
            }
            
            //Display the 3 oldest artist from Atlanta
            List<Artist> oldestArtistFromATL = Artists.Where(match => match.Hometown == "Atlanta").OrderByDescending(match => match.Age).Take(3).ToList();
            foreach(var artist in oldestArtistFromATL){
                Console.WriteLine($"{artist.ArtistName} is {artist.Age}");
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
