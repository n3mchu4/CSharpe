namespace MyLib;

public class nhapsonguyen
{
    public static int nhapso(ref int x, ref int y)
    {
        Console.Write("Nhap x: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = int.Parse(Console.ReadLine());
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