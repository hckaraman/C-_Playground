using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Threading;

// using .Interop.TimeSeries;
// using Microsoft.Data.Analysis;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));
            // Thread.Sleep(10000);
            ;
            int[,] data =
            {
                {1, 3, 4},
                {12, 5, 1},
                {1, 4, 7}
            };

            try
            {
                Console.WriteLine(data[0, 2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            // DateTime start = new DateTime();
            DateTime currentTime = DateTime.Now;
            // Console.WriteLine(currentTime);

            DateTime startDate = new DateTime(2000, 1, 1);

            DateTime[] newDays = new DateTime[366];


            /*
            for (int i = 0; i < newDays.Length; i++)
            {
                newDays[i] = (startDate.AddDays(i));
                Console.WriteLine(newDays[i].ToShortDateString());
            }
            */

            List<double> myList = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            foreach (var value in myList)
            {
                // Console.WriteLine(value);
            }

            Dictionary<string, double> newDict = new Dictionary<string, double>();

            newDict.Add("Atlar", 5.0);
            newDict.Add("Atkafasi", 123.0);

            // Console.WriteLine(newDict["Atkafasi"]);

            string[] names = {"at", "KAfasi", "Atlarca"};

            // names.ToDictionary()

            Dictionary<string, int> nDict = new Dictionary<string, int>()
            {
                {"Atlar", 5},
                {"At", 3},
                {"at", 41}
            };

            myList.ForEach(p => Console.WriteLine("{0}", p));
        }


        static void AddValues(double[] x)
        {
            // foreach (var y in x)
            // {
            //     Console.WriteLine(y);
            // }

            Console.WriteLine("Sum of all values in array {0}", x.Sum());
        }
    }
}