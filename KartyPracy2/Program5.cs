internal class Program{
    private static void Main(string[] args) {

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a>c && b<c)
        {
            Console.WriteLine("TAK");
        }
        if (a<c && b>c)
        {
            Console.WriteLine("TAK");
        }
        else 
        {
            Console.WriteLine("NIE");
        }
        Console.ReadKey();
    }
}