using Congratulator.NSCongratulation;
using System;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        public void EditD3()
        {
            Console.Write("New Day: ");
            Input = Console.ReadLine();
            RES &= Int32.TryParse(Input, out Day);
            if (!RES)
            {
                Console.WriteLine("Input Error: Use only 0...9 symbols");
            }
            else if ((Day >= 1) && (Day <= 31))
            {
                if (this.ListOfCongratulations.Count > 0)
                {
                    this.ListOfCongratulations.RemoveAt(Selected);
                }

                DateTime NewDateTime = new DateTime(Year, Month, Day, Hour, Minute, Second);
                double NewUnixTime = ConvertToUnixTimestamp(NewDateTime);
                this.ListOfCongratulations.Add(new Congratulation() { Description = AddDescription, UnixTime = NewUnixTime });
                this.AddedUnixTime = NewUnixTime;
            }
            else { Console.WriteLine("TimeStamp Input Error: Invalid Day!"); }
        }
    }
}