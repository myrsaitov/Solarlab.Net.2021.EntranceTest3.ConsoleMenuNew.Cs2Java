using Congratulator.NSCongratulation;
using System;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        public void Add()
        {
            Console.Clear();
            Console.WriteLine("Add new Item:");
            Console.WriteLine();

            Console.Write("Description: ");
            string AddDescription = Console.ReadLine();

            string Input;
            bool RES = true;

            Console.Write("Year: ");
            Input = Console.ReadLine();
            int Year = -1;
            RES &= Int32.TryParse(Input, out Year);

            Console.Write("Month: ");
            Input = Console.ReadLine();
            int Month = -1;
            RES &= Int32.TryParse(Input, out Month);

            Console.Write("Day: ");
            Input = Console.ReadLine();
            int Day = -1;
            RES &= Int32.TryParse(Input, out Day);

            Console.Write("Hour: ");
            Input = Console.ReadLine();
            int Hour = -1;
            RES &= Int32.TryParse(Input, out Hour);

            Console.Write("Minute: ");
            Input = Console.ReadLine();
            int Minute = -1;
            RES &= Int32.TryParse(Input, out Minute);

            Console.Write("Second: ");
            Input = Console.ReadLine();
            int Second = -1;
            RES &= Int32.TryParse(Input, out Second);

            if (!RES)
            {
                Console.WriteLine();
                Console.WriteLine("Error!");
                Console.WriteLine("USE Only 0 ... 9 Symbols!: ");
                Console.WriteLine();
                Console.WriteLine("Press ANY key to Continue!");
                ConsoleKeyInfo cki1;
                int num1 = 0;
                do
                {
                    cki1 = Console.ReadKey(true);
                    num1 = Convert.ToInt32(cki1.Key);
                    if (num1 != null) break;

                } while (true);

            }
            else
            {


                int Test = 0;

                Console.WriteLine();

                if ((Year >= 1970) && (Year <= 2100))
                {
                    Test++;
                }
                else { Console.WriteLine("TimeStamp Input Error: Invalid Year!"); }

                if ((Month >= 1) && (Month <= 12))
                {
                    Test++;
                }
                else { Console.WriteLine("TimeStamp Input Error: Invalid Month!"); }

                if ((Day >= 1) && (Day <= 31))
                {
                    Test++;
                }
                else { Console.WriteLine("TimeStamp Input Error: Invalid Day!"); }

                if ((Hour >= 1) && (Hour <= 23))
                {
                    Test++;
                }
                else { Console.WriteLine("TimeStamp Input Error: Invalid Hour!"); }

                if ((Minute >= 1) && (Minute <= 59))
                {
                    Test++;
                }
                else { Console.WriteLine("TimeStamp Input Error: Invalid Minute!"); }

                if ((Second >= 1) && (Second <= 59))
                {
                    Test++;
                }
                else { Console.WriteLine("TimeStamp Input Error: Invalid Second!"); }

                if (Test == 6)
                {
                    DateTime NewDateTime = new DateTime(Year, Month, Day, Hour, Minute, Second);
                    double NewUnixTime = ConvertToUnixTimestamp(NewDateTime);
                    this.ListOfCongratulations.Add(new Congratulation() { Description = AddDescription, UnixTime = NewUnixTime });
                    this.AddedUnixTime = NewUnixTime;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Press ANY key to Continue!");
                    ConsoleKeyInfo cki;
                    int num = 0;
                    do
                    {
                        cki = Console.ReadKey(true);
                        num = Convert.ToInt32(cki.Key);
                        if (num != null) break;

                    } while (true);
                }
            }
        }
    }
}