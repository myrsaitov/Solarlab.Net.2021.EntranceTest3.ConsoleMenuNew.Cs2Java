using Congratulator.NSCongratulation;
using System;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        private string AddDescription;
        private string Input;
        private bool RES;
        private int Year;
        private int Month;
        private int Day;
        private int Hour;
        private int Minute;
        private int Second;

        public void Edit()
        {
            DateTime DT = ConvertFromUnixTimestamp(this.ListOfCongratulations[this.Selected].UnixTime);
            AddDescription = this.ListOfCongratulations[this.Selected].Description;
            Console.Clear();
            Console.WriteLine(DT.ToString("yyyy/MM/dd HH:mm:ss") + " " + AddDescription);
            Console.WriteLine();
            Console.WriteLine("Press to Edit:");
            Console.WriteLine("1.  Year");
            Console.WriteLine("2.  Month");
            Console.WriteLine("3.  Day");
            Console.WriteLine("4.  Hours");
            Console.WriteLine("5.  Minutes");
            Console.WriteLine("6.  Secons");
            Console.WriteLine("D.  Description");
            Console.WriteLine();
            Console.WriteLine("X.  Abort and Exit");
            Console.WriteLine();

            RES = true;
            Year = Int32.Parse(DT.ToString("yyyy"));
            Month = Int32.Parse(DT.ToString("MM"));
            Day = Int32.Parse(DT.ToString("dd"));
            Hour = Int32.Parse(DT.ToString("HH"));
            Minute = Int32.Parse(DT.ToString("mm"));
            Second = Int32.Parse(DT.ToString("ss"));

            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);

                if (Key.Key == ConsoleKey.J)
                {
                    EditD1();
                    break;
                }

                if (Key.Key == ConsoleKey.D2)
                {
                    EditD2();
                    break;
                }

                if (Key.Key == ConsoleKey.D3)
                {
                    EditD3();
                    break;
                }

                if (Key.Key == ConsoleKey.D4)
                {
                    EditD4();
                    break;
                }

                if (Key.Key == ConsoleKey.D5)
                {
                    EditD5();
                    break;
                }

                if (Key.Key == ConsoleKey.D6)
                {
                    EditD6();
                    break;
                }

                if (Key.Key == ConsoleKey.D)
                {

                    EditD();
                    break;
                }

                if (Key.Key == ConsoleKey.X)
                {
                    break;
                }
            }
        }
    }
}