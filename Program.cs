namespace GA_AggregateAndContainment_Hongfei
{
    internal class Program
    {
        //Week3_GA_AggregateAndContainment
        //Hongfei
        //01/28/2024

        static List<Engine> _engines;
        static void Main(string[] args)
        {
            _engines = new List<Engine>();
            
            GraphicsCard gc = new GraphicsCard(GraphicsCard.Brand.Nvidia);
            Computer comp = new Computer(gc);

            Console.WriteLine("Computer Information:");
            Console.WriteLine(comp.ToString());

            Engine fastEngine = new Engine(250);
            Engine slowerEngine = new Engine(120);
            Console.WriteLine(fastEngine.Hp);

            _engines.Add(fastEngine);
            _engines.Add(slowerEngine);

            Suspension suspension = new Suspension(-.4f, 5, .5f);

            Car car = new Car("Ford", "Escort",fastEngine,suspension);
            Console.WriteLine(car.ToString());

            Character donkeyKong = new Character(150, "Donkey Kong");
            GoKart goKart = new GoKart(donkeyKong);
            Console.WriteLine(goKart);

            Character toad = new Character(50, "Toad");
            GoKart goKartToad = new GoKart(toad);
            Console.WriteLine(goKartToad);

            goKartToad.TweakEngine(-50);

            //Response to exceptions in the Engine class set properties
            try
            {
                goKartToad.TweakEngine(-50);
                Console.WriteLine("We reached this line of code");
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("This after our try catch");

             
        }

    }
}
