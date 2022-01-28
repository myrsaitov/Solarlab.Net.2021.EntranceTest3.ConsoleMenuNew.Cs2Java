using Congratulator.NSCongratulation;
using System;
using System.Collections.Generic;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        public void Show()
        {
            Console.WriteLine("My List of congatulations:");
            Console.WriteLine();

            this.ListOfCongratulations.Sort(CompareUnixTime);

            if (this.ListOfCongratulations.Count == 1) { this.Selected = 0; }

            if (this.AddedUnixTime > 0)
            {
                for (int i = 0; i < this.ListOfCongratulations.Count; i++)
                {
                    if (this.AddedUnixTime == this.ListOfCongratulations[i].UnixTime)
                    { this.Selected = i; }
                }

                this.AddedUnixTime = 0;
            }

            for (int i = 0; i < this.ListOfCongratulations.Count; i++)
            {
                if (i == Selected)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ConvertFromUnixTimestamp(this.ListOfCongratulations[i].UnixTime).ToString("yyyy/MM/dd HH:mm:ss") + " " + this.ListOfCongratulations[i].Description);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ConvertFromUnixTimestamp(this.ListOfCongratulations[i].UnixTime).ToString("yyyy/MM/dd HH:mm:ss") + " " + this.ListOfCongratulations[i].Description);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            //foreach (Congratulation plan in ListOfCongratulations)
            //Console.WriteLine(ConvertFromUnixTimestamp(plan.UnixTime).ToString("yyyy/MM/dd HH:mm:ss") + " " + plan.Description);

        }
    }
}