using Congratulator.NSCongratulation;
using System;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        public void EditD4()
        {
            Console.Write("New Hour: ");
            Input = Console.ReadLine();
            RES &= Int32.TryParse(Input, out Hour);
            if (!RES)
            {
                Console.WriteLine("Input Error: Use only 0...9 symbols");
            }
            else if ((Hour >= 0) && (Hour <= 23))
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
            else { Console.WriteLine("TimeStamp Input Error: Invalid Hour!"); }
        }
    }
}