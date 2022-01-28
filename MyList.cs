using Congratulator.NSCongratulation;
using System;
using System.Collections.Generic;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        int Selected = 0;
        int EditIndex = 0;
        double AddedUnixTime = 0;

        List<Congratulation> ListOfCongratulations;
        public MyList()
        {
            this.ListOfCongratulations = new List<Congratulation>()
        {
            new Congratulation() { Description = "Ivanov", UnixTime = 1581580800},
            new Congratulation() { Description = "Petrov", UnixTime = 1580821200},
            new Congratulation() { Description = "Sidorov", UnixTime = 1581962400},
        };
        }

        static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }
        static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date - origin;
            return Math.Floor(diff.TotalSeconds);
        }
        public static int CompareUnixTime(Congratulation plan1, Congratulation plan2)
        {
            return plan1.UnixTime.CompareTo(plan2.UnixTime);
        }

        public void SelectedShow() { Console.WriteLine(this.Selected); }
        public void SelectUp()
        {
            if (this.Selected > 0) { this.Selected--; }
        }

        public void SelectDown()
        {
            if (this.Selected < this.ListOfCongratulations.Count - 1) { this.Selected++; }
        }



    }
}