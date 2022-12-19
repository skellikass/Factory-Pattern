namespace FactoryPattern
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome!  Please select a clothing item from the following by typing your choice:");
            Console.WriteLine("sweater, pants");
            Console.WriteLine("(If an option above is not selected, you will receive the most expensive selection as default.)");
            var clothingChoice = Console.ReadLine();
            var printChoice = ClothingFactory.GetCLothing(clothingChoice);
            printChoice.PrintDetails();
        }
    }
}
