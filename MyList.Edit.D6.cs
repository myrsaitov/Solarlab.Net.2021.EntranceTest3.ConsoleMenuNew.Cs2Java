using Congratulator.NSCongratulation;
using System;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        public void EditD6()
        {
            Console.Write("New Seconds: ");
            Input = Console.ReadLine();
            RES &= Int32.TryParse(Input, out Second);
            if (!RES)
            {
                Console.WriteLine("Input Error: Use only 0...9 symbols");
            }
            else if ((Second >= 0) && (Second <= 59))
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
            else { Console.WriteLine("TimeStamp Input Error: Invalid Seconds!"); }

        }
    }
}