﻿using MetroTickets.DataService.Data;
using MetroTickets.Entities.DbSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTickets.Helpers
{
    public class GraphConstructionToDB
    {
        public Station[] stationsArray;
        public Edge[] edgesArray;

        public GraphConstructionToDB()
        {
            Process();
        }

        // 
        private void Process()
        {
            Dictionary<string, int> stationsWithIds = new Dictionary<string, int>();
            List<Station> stationsList = new List<Station>();
            List<Edge> edgesList = new List<Edge>();

            int StationId = 1;
            int EdgeId = 1;
            int previousStationId = -1;

            foreach (var line in Metro.lines)
            {
                foreach (var stationName in line.Value)
                {
                    if (!stationsWithIds.ContainsKey(stationName))
                    {
                        stationsWithIds[stationName] = StationId;
                        stationsList.Add(new Station { Id = StationId++, Name = stationName });
                    }

                    int currentStationId = stationsWithIds[stationName];

                    if (previousStationId != -1)
                    {
                        edgesList.Add(new Edge { Id = EdgeId++, FirstId = previousStationId, SecondId = currentStationId, Cost = 1 });
                    }

                    previousStationId = currentStationId;
                }
                previousStationId = -1;
            }
            stationsArray = stationsList.ToArray();
            edgesArray = edgesList.ToArray();
        }

    }
}
