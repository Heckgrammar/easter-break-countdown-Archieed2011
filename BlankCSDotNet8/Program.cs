namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your countdown?");
            string countdown1 = Console.ReadLine();

            Console.WriteLine("What date is your countdown?");
            DateTime countdown = new Console.ReadLine();

            DateTime current = DateTime.Now;

            //DateTime target = new DateTime(2025, 4, 4, 15, 10, 5);

            TimeSpan difference = countdown - current;
            Console.WriteLine("There is " + difference.Days + " days, " + difference.Hours + " hours, " + difference.Minutes + " minutes, and " + difference.Seconds + " seconds until" + countdown1);
           
            Thread.Sleep(1000);

            //if (difference.Days < 0)
            //{
              //  Console.WriteLine("It's the easter holidays");
            //}
        }
    }
}
