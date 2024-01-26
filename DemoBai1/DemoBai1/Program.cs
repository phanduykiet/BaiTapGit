namespace DemoBai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int z = 5;

            Console.Write("Nhap mot so nguyen: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Phuong trinh");
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
            int A = x * x + y * y + z * 5;
            Console.WriteLine(A);
        }
    }
}
