internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap 1 so nguyen n > 0");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine("n khong phai la so nguyen to");
        } else
        {
            int dem = 0;
            // bool laSoNT = true;     // Tạo biến đánh dấu nó đúng, sau xét điều kiện đúng sai sau
            for (int i = 2; i <= n; i++)
            {
                // int dem = 0;
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 1)
            {
                Console.WriteLine("n la so nguyen to");
            } else
            {
                Console.WriteLine("n khong phai la so nguyen to");
            }
        }
    }
}