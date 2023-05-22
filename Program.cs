namespace ExperimentationWithEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            Beverage beverage = new Expresso();

            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);

            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());
        }
    }
}