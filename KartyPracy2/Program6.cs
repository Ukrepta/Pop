int a = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

if ((Math.Pow(a, p) - a) % p == 0)
{
    Console.WriteLine("TAK");
}
else
{
    Console.WriteLine("NIE");
}