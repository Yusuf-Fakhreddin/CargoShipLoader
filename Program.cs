namespace CargoShipLoader // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();

            string gameWelcomeMessage = "Welcome to Cargo Ship\nThe goal of this game is to load the ship to its maxiumum capacity by adding motor cycles, cars, trucks annd train cars.\n" +
                "A cycle takes 3 units of weight.\n" +
                "A car takes 5 units of weight\n" +
                "A truck takes 11 units of weight\n" +
                "A train car takes 17 units of weight\n\n";

            Console.WriteLine(gameWelcomeMessage);

            while (ship.getCurrentShipLoad()!= ship.MaxCapacity)
            {
                ship.CycleCount = 0;
                ship.CarCount=0;
                ship.TruckCount=0;
                ship.TrainCount=0;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The ship maximum capacity is "+ship.MaxCapacity);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("The ship has "+ ship.CycleCount +" motorcycles on board");
                Console.WriteLine("The ship has " + ship.CarCount + " cars on board");
                Console.WriteLine("The ship has " + ship.TruckCount + " trucks on board");
                Console.WriteLine("The ship has " + ship.TrainCount + " train cars on board");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The ship has " + ship.getCurrentShipLoad() + " total weight units on board");
                Console.ForegroundColor = ConsoleColor.White;

                int x;

                Console.WriteLine("How many motor cycles would you like to put on the ship?") ;
                x = int.Parse(Console.ReadLine());
                ship.CycleCount=x;

                Console.WriteLine("How many cars would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());
                ship.CarCount = x;

                Console.WriteLine("How many trucks would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());
                ship.TruckCount = x;

                Console.WriteLine("How many train cars would you like to put on the ship?");
                x = int.Parse(Console.ReadLine());
                ship.TrainCount = x;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The ship current Load is" + ship.getCurrentShipLoad() + " weight units of load\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Red;

                int y = ship.howLoaded();
                if (y > 0)
                {
                    Console.WriteLine(String.Format("The ship still has room. Try again and load {0} weight units more\n", y));
                }
                else if(ship.howLoaded() <0 )
                {
                    Console.WriteLine(String.Format("The ship is overloaded. Try again and take {0} weight units off\n", Math.Abs(y)));

                }


            }
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Congrats, You loaded the ship successfully!");
        }
    }
}