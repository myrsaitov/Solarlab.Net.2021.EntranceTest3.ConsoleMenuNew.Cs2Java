using Congratulator.NSCongratulation;
using System;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        public void EditD()
        {
            Console.Write("New Description: ");
            AddDescription = Console.ReadLine();

            if (this.ListOfCongratulations.Count > 0)
            {
                this.ListOfCongratulations.RemoveAt(Selected);
            }

            DateTime NewDateTime = new DateTime(Year, Month, Day, Hour, Minute, Second);
            double NewUnixTime = ConvertToUnixTimestamp(NewDateTime);
            this.ListOfCongratulations.Add(new Congratulation() { Description = AddDescription, UnixTime = NewUnixTime });
            this.AddedUnixTime = NewUnixTime;
        }
    }
}