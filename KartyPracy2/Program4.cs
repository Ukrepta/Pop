internal class Program{
    private static void Main(string[] args) {

        int waga = int.Parse(Console.ReadLine());
        int limit = 20;
        if (waga <= limit)
        {
            Console.WriteLine("TAK");
        }
        else {
            Console.WriteLine("NIE");
        }
    }
}