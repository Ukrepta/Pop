internal class Program{
    private static void Main(string[] args) {

        int wiek = int.Parse(Console.ReadLine());
        if (wiek >=18)
        {
            Console.WriteLine("TAK");
        }
        else {
            Console.WriteLine("NIE");
        }
    }
}