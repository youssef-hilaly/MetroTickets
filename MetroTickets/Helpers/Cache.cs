﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTickets.Helpers
{
    internal class Cache
    {
        private static  SortedDictionary<(int from, int to), int> cache = new SortedDictionary<(int from, int to), int>();
        private static int cacheLimit = 50;

        public static void AddToCache(int from, int to, int distance)
        {
            if (cache.Count >= cacheLimit)
            {
                cache.Remove(cache.Keys.Last());
            }
            cache.Add((from, to), distance);
        }

        public static bool IsExist(int from, int to)
        {
            return cache.ContainsKey((from, to));
        }

        public static int Get(int from, int to)
        {
            return cache[(from, to)];
        }

    }
}
