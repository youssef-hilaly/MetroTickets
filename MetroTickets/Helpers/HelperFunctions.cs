using MetroTickets.Constants;
using MetroTickets.Entities.DbSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroTickets.DataService.Data;

namespace MetroTickets.Helpers
{
    internal class HelperFunctions
    {
        public static int GetInputStation(string s)
        {
            while (true)
            {
                Console.WriteLine(s);
                string? input = Console.ReadLine();

                if (input == null || !int.TryParse(input, out int stationNumber))
                {
                    Console.WriteLine(Constats.ENTER_INVALID_NUMBER);
                    continue;
                }

                if(!Graph.IsExist(stationNumber))
                {
                    Console.WriteLine(Constats.NO_STATION);
                    continue;
                }

                return stationNumber;
            }
        }

        public static int CalcPrice(int count)
        {

            if (count <= Constats.FIRST_TICKET_LIMIT)
            {
                return Constats.FIRST_TICKET_PRICE;
            }
            else if (count >= Constats.FIRST_TICKET_LIMIT && count <= Constats.SECOND_TICKET_LIMIT)
            {
                return Constats.SECOND_TICKET_PRICE;
            }
            else if (count >= Constats.SECOND_TICKET_LIMIT && count <= Constats.THIRD_TICKET_LIMIT)
            {
                return Constats.THIRD_TICKET_PRICE;
            }
            else
            {
                return Constats.FOURTH_TICKET_PRICE;
            }
        }


    }
}
