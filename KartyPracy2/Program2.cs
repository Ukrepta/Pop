internal class Program{
    private static void Main(string[] args) {

        int a = int.Parse(Console.ReadLine());
        if (a % 17 == 0 && a % 100 == 0)
        {
            Console.WriteLine("TAK");
        }
        else {
            Console.WriteLine("NIE");
        }
    }
}