using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace LeetCodeSolutions._1396._Design_Underground_System
{



    public class UndergroundSystem
    {

        Dictionary<string, int[]> result = new Dictionary<string, int[]>();

        Dictionary<int, KeyValuePair<string, int>> checkin = new Dictionary<int, KeyValuePair<string, int>>();

        public UndergroundSystem()
        {

        }

        public void CheckIn(int id, string stationName, int t)
        {
            checkin.Add(id, new KeyValuePair<string, int>( stationName,t ));

        }

        public void CheckOut(int id, string stationName, int t)
        {
            string fromStation = checkin[id].Key;
            int time = checkin[id].Value;

            int avg = t - time;

            string key = $"{fromStation},{stationName}";

            if (!result.ContainsKey(key))
                result.Add(key, new int[2] { 0, 0 });

            result[key][0] += avg;
            result[key][1]++;

            checkin.Remove(id);




        }

        public double GetAverageTime(string startStation, string endStation)
        {
            var key = $"{startStation},{endStation}";

            if (result.ContainsKey(key)) return (double)result[key][0] / result[key][1];

            return 0.0;
        }
    }
}
