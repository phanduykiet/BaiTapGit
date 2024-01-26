namespace DemoBai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            Console.Write("Nhap mot so nguyen :");
            int y = int.Parse(Console.ReadLine());
            int z = y * 6;
            int A = (z * z + y * y * y * z * y) * 4;
            Console.WriteLine("Phuong trinh co ket qua :" + A);
        }
    }
}
