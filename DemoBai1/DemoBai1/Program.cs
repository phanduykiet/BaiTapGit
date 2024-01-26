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
            
            int A = x * x + y * y + z * 5;
            Console.WriteLine(A);
        }
    }
}
