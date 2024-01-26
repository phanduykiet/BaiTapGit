namespace DemoBai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            Console.Write("Nhap mot so nguyen n:");
            int n = int.Parse(Console.ReadLine());
            int z = n * 6;
            int A = (z * z + n * n * n * z * n) * 4;
            Console.WriteLine("Ket qua :" + A);
        }
    }
}
