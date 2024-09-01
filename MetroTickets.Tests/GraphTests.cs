using MetroTickets.Constants;
using MetroTickets.DataService.Data;
using MetroTickets.Entities.DbSet;
using MetroTickets.Entities.Models;
using MetroTickets.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTickets.Tests
{
    public class GraphTests
    {
        [Fact]
        public async void FindDistance_BetweenHelwanAndMaadi_ReturnsDistance()
        {
            Graph graph = Graph.getInstance();
            AppDbContext db = new AppDbContext();

            Station? Helwan = await db.Stations.FirstOrDefaultAsync(s => s.Name == "Helwan");
            Station? Maadi = await db.Stations.FirstOrDefaultAsync(s => s.Name == "Maadi");

            Assert.NotNull(Helwan);
            Assert.NotNull(Maadi);

            Result<int> result = graph.FindDistance(Helwan.Id, Maadi.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = 10;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_BetweenHelwanAndAinHelwan_ReturnsDistance()
        {
            Graph graph = Graph.getInstance();
            AppDbContext db = new AppDbContext();

            Station? Helwan = await db.Stations.FirstOrDefaultAsync(s => s.Name == "Helwan");
            Station? AinHelwan = await db.Stations.FirstOrDefaultAsync(s => s.Name == "Ain Helwan");

            Assert.NotNull(Helwan);
            Assert.NotNull(AinHelwan);

            Result<int> result = graph.FindDistance(Helwan.Id, AinHelwan.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = 1;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void FindDistance_BetweenHelwanAndNewElMarg_ReturnsDistance()
        {
            Graph graph = Graph.getInstance();
            AppDbContext db = new AppDbContext();

            Station? Helwan = await db.Stations.FirstOrDefaultAsync(s => s.Name == "Helwan");
            Station? NewElMarg = await db.Stations.FirstOrDefaultAsync(s => s.Name == "New El Marg");

            Assert.NotNull(Helwan);
            Assert.NotNull(NewElMarg);

            Result<int> result = graph.FindDistance(Helwan.Id, NewElMarg.Id);

            Assert.True(result.IsSuccess);

            int actual = result.Data;
            int expected = 34;

            Assert.Equal(expected, actual);
        }
    }
}
