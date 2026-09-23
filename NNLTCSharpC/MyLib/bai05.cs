namespace MyLib;

public class bai05
{
    public static void chonchucnang()
    {
        int choice;
        Console.WriteLine("MENU\n1. Nhap hai gia tri so thuc cho x, y\n2. Tinh x^y\n3. Tinh can bac 2 cua x va y\n4. Thoat");
        choice = int.Parse("Chon chuc nang: "+Console.ReadLine());
        switch (choice)
        {
            case 1:
            break;
            case 2:
            break;
            case 3:
            break;
            case 4:
            break;
        }   
    }

    public static void nhap(ref float x, ref float y){
        Console.Write("Nhap x: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = float.Parse(Console.ReadLine());
    }

    public static int tinhsomu(int x, int y)
    {
        int mu=1;
        for (int i = 1; i <= y; i++)
        {
            mu = mu*x;
        }
        return mu;
    }

    public static void canbachai(int x,int y)
    {
        
    }
}