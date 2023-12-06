namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            String? name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
        }
    }
}