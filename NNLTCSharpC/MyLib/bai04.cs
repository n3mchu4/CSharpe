namespace MyLib;

public class bai03
{
    public static int nhapso(ref int x, ref int y)
    {
        while (true)
        {
            Console.Write("Nhap x: ");
            if (int.TryParse(Console.ReadLine(), out x))
                break;

            Console.WriteLine("x phai la so nguyen. Nhap lai!");
        }

        while (true)
        {
            Console.Write("Nhap y: ");
            if (int.TryParse(Console.ReadLine(), out y))
                break;

            Console.WriteLine("y phai la so nguyen. Nhap lai!");
        }

            return tinh(x,y);
    }

    public static int tinh(int x, int y)
    {
        int mu=1;
        for (int i = 1; i <= y; i++)
        {
            mu = mu*x;
        }
        return mu;
    }


}