namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var future = new Car();

            future.Make = "BMW";
            future.Model = "Sedan";
            future.Year = 2035;

            Console.WriteLine($"This is a {future.Make} from the future. " +
                $"Its a four door {future.Model} " +
                $"and will come out in the year {future.Year}!");
        }
    }
}
