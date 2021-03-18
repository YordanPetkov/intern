using Station.Data;
using Station.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Station.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            //PopulateTableTrains();
            //PopulateTableTrips();
            //PopulateTableUsers();
            PrintTrip(2);
        }

        static void PrintTrip(int tripId)
        {
            using(var context = new StationDBContext())
            {
                var trip = context.Trips.Find(tripId);
                var train = context.Trains.Find(trip.TrainId);
                var passangers = trip.Users;

                Console.WriteLine("From \"{0}\" to \"{1}\" , train : \"{2}\"", trip.Place1, trip.Place2, train.Name);
                Console.WriteLine("Passangers : ");

                foreach (var passanger in passangers)
                {
                    Console.WriteLine(passanger.Name);
                }
            }
        }

        static void PopulateTableTrains()
        {
            using (var context = new StationDBContext())
            {
                context.Trains.Add(new Train(){ 
                    Id = 1,
                    Name = "Chaika"
                });

                context.Trains.Add(new Train()
                {
                    Id = 2,
                    Name = "Yantra"
                });

                context.Trains.Add(new Train() 
                {
                    Id = 3,
                    Name = "Diana"
                });

                context.SaveChanges();
            }
        }

        static void PopulateTableTrips()
        {
            using (var context = new StationDBContext())
            {
                context.Trips.Add(new Trip()
                {
                    Id = 1,
                    Place1 = "Sofia",
                    Place2 = "Bourgas",
                    Train = context.Trains
                            .Where(t => t.Name == "Chaika")
                            .FirstOrDefault<Train>()
                });

                context.Trips.Add(new Trip()
                {
                    Id = 2,
                    Place1 = "Sofia",
                    Place2 = "Gorna Oriahovitsa",
                    Train = context.Trains
                            .Where(t => t.Name == "Yantra")
                            .FirstOrDefault<Train>()
                });

                context.Trips.Add(new Trip()
                {
                    Id = 3,
                    Place1 = "Sofia",
                    Place2 = "Yambol",
                    Train = context.Trains
                            .Where(t => t.Name == "Diana")
                            .FirstOrDefault<Train>()
                });

                context.SaveChanges();
            }
        }
        static void PopulateTableUsers()
        {
            var userNames = new string[] { 
                "Petar Ivanov",
                "Dimitar Andreev",
                "Georgi Petrov",
                "Miroslav Kolev",
                "Stanimir Nikolov",
                "Ivan Kirqkov",
                "Stanimir Kalinov",
                "Qsen Petrov",
                "Georgi Ivanov", 
                "Krasimir Antov", 
                "Galin Malinov", 
                "Petia Sotirova", 
                "Ivanka Stamenova", 
                "Galina Ivanova",
                "Magdalena Petrova" };

            using (var context = new StationDBContext())
            {
                int currentUserId = 1;

                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        var newUser = new User()
                            {
                                Id = currentUserId++,
                                Name = userNames[(i-1)*5 + j]
                            };

                        newUser.Trips.Add(context.Trips
                                     .Where(t => t.Id == i)
                                     .FirstOrDefault<Trip>());

                        context.Users.Add(newUser);
                    }
                }

                context.SaveChanges();
            }
        }
    }
}