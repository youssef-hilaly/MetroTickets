using MetroTickets.Constants;
using MetroTickets.DataService.Data;
using MetroTickets.DataService.Migrations;
using MetroTickets.Entities.DbSet;
using MetroTickets.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTickets.Helpers
{
    internal class Graph
    {

        private static Graph instance = null;

        private AppDbContext db = new AppDbContext();

        private Dictionary<int, List<int>> adjacencyList; // Store the Graph so we can traverse over it

        private static List<Station> stations;
        private List<Edge> edges;

        public static Graph getInstance()
        {
            if (instance == null)
            {
                instance = new Graph();
            }
            return instance;
        }

        private Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
            Init();
        }

        private async void Init()
        {
            stations = await db.Stations.ToListAsync();
            edges = await db.Edges.ToListAsync();

            for (int i = 0; i < edges.Count; i++)
            {
                AddEdge(edges[i].SecondId, edges[i].FirstId);
                AddEdge(edges[i].FirstId, edges[i].SecondId);
            }
        }

        private void AddEdge(int from, int to)
        {
            if (!adjacencyList.ContainsKey(from))
            {
                adjacencyList[from] = new List<int>();
            }
            adjacencyList[from].Add(to);
        }

        public static bool IsExist(int id)
        {
            return stations.Any(x => x.Id == id);
        }

        // Using BFS Algorithm
        public Result<int> FindDistance(int from, int to)
        {

            if (Cache.IsExist(from, to))
            {
                return Result<int>.Success(Cache.Get(from, to));
            }
            if (Cache.IsExist(to, from))
            {
                return Result<int>.Success(Cache.Get(to, from));
            }

            HashSet<int> isVisited = new HashSet<int>();
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(from, 0));

            while (queue.Count > 0)
            {
                var (node, distance) = queue.Dequeue();

                if (node == to)
                {
                    Cache.AddToCache(from, to, distance);
                    return Result<int>.Success(distance);
                }

                if (adjacencyList.ContainsKey(node))
                {
                    foreach (int child in adjacencyList[node])
                    {
                        if (isVisited.Contains(child)) continue;

                        isVisited.Add(child);
                        queue.Enqueue(new Tuple<int, int>(child, distance + 1));
                    }
                }
            }
            return Result<int>.Failure($"{Constats.NO_PATH} {from}, {to}");
        }

        public void DisplayStations()
        {
            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"{stations[i].Id} {stations[i].Name}");
            }
        }
    }
}
