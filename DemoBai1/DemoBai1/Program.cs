namespace DemoBai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 4;

            Console.Write("Nhap mot so nguyen: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Phuong trinh tren");
            int A = x * x + y * y * y * x * y;
            Console.WriteLine(A);
        }
    }
}
