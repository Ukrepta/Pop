internal class Program{
    private static void Main(string[] args) {

        int a = int.Parse(Console.ReadLine());
        if (a % 3 == 0)
        {
            Console.WriteLine("TAK");
        }
        else {
            Console.WriteLine("NIE");
        }
    }
}