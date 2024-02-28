namespace exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number, any number ,':) ");
            int numberpicked = int.Parse(Console.ReadLine());

            for ( int evennumbers = 0; evennumbers <= numberpicked; evennumbers++ , evennumbers++)
            {
                Console.WriteLine(evennumbers);
            }

        }
    }
}