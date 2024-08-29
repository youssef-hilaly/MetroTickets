using MetroTickets.Constants;
using MetroTickets.DataService.Data;
using MetroTickets.Entities.DbSet;
using MetroTickets.Entities.Models;
using MetroTickets.Helpers;
using Microsoft.EntityFrameworkCore;
namespace MetroTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Graph graph = Graph.getInstance();


            while (true)
            {
                graph.DisplayStations();

                int currentStation = HelperFunctions.GetInputStation(Constats.ENTER_CURRENT_STATION);
                int destinationStation = HelperFunctions.GetInputStation(Constats.ENTER_DESTINATION_STATION);

                Result<int> result = graph.FindDistance(currentStation, destinationStation);

                if (!result.IsSuccess)
                {
                    Console.WriteLine(result.ErrorMessage);
                    return;
                }

                int price = HelperFunctions.CalcPrice(result.Data);

                Console.WriteLine($"{Constats.SHOULD_PAY} {price} {Constats.EGP}");

                Thread.Sleep(3000);
            }

        }
    }
}
