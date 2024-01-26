namespace DemoBai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 4;

            Console.Write("Nhap mot so nguyen n = ");
            int z = y * 6;

            int A = z * z + y * y * y * z * y;
            Console.WriteLine("kq = ", A * 4);
        }
    }
}
