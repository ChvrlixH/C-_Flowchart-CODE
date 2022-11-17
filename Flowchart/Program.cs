#region Ededin 2-nin quvveti olub olmadiginin yoxlanilmasi
using System.Collections.Concurrent;
Console.WriteLine("Zehmet olmasa ededi daxil edin");
int num = int.Parse(Console.ReadLine());
while (num % 2 == 0)
{
    num /= 2;
}
if (num == 1)
{
    Console.WriteLine("Eded 2-nin quvvetidir");
}
else
{
    Console.WriteLine("Eded 2-nin quvveti deyil");
}
#endregion

#region 2 ededin daxilindeki ededler
Console.WriteLine("Zehmet olmasa 1-ci ededi daxil edin");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zehmet olmasa 2-ci ededi daxil edin");
int num2 = Convert.ToInt32(Console.ReadLine());
for (int i = num1 + 1; i < num2; i++)
{
    Console.WriteLine();
    Console.WriteLine(i);
}
#endregion

#region Eded 70-den boyukdurse
Console.WriteLine("Zehmet olmasa ededi qeyd edin:");
int result = 1;
int num = int.Parse(Console.ReadLine());
if (num > 70)
{
    result = (num - 70) * 3;
    Console.WriteLine(result);
}
else //ferqin ozunu dedikde verilen ededi nezerde tutub else yazdim.
{
    Console.WriteLine(num);
}
#endregion

#region X,Y,Z En boyuk olani yazdir

Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int z = Convert.ToInt32(Console.ReadLine());

if (x > y && x > z)
{
    Console.WriteLine("En boyuk eded X-dir: " + x);
}
else if (y > x && y > z)
{
    Console.WriteLine("En boyuk eded Y-dir: " + y);
}
else if (z > x && z > y)
{
    Console.WriteLine("En boyuk eded Z-dir: " + z);
}
#endregion

#region n<m arasindaki tek ededler
Console.WriteLine("N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("M: ");
int m = int.Parse(Console.ReadLine());
int plus = 0;

for (int i = n; i < m; i++)
    if (i % 2 == 0)
    {
        plus++;
    }
Console.WriteLine("Tek ededlerin sayi: " + plus); 
#endregion
