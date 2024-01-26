namespace DemoBai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            Console.Write("n:");
            int n = int.Parse(Console.ReadLine());
            int z = x * 6;
            int A = (z * z + n * n * n * z * n) * 4;
            Console.WriteLine("A= :" + A);
        }
    }
}
