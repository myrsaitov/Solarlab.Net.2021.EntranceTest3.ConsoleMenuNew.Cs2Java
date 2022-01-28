using System;

namespace Congratulator.NSMyList
{
    public partial class MyList
    {
        public void Remove()
        {
            if (this.ListOfCongratulations.Count > 0)
            {
                Console.Clear();
                this.ListOfCongratulations.RemoveAt(Selected);
                Console.WriteLine("Succesfully removed!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nothing to remove!");
            }


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