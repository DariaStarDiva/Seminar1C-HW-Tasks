Console.Write(" Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите первое число ");
int b = Convert.ToInt32(Console.ReadLine());

while ( a == b)
{
    Console.Write(" Вы ошиблись! Введите разные числа ");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
}
int big = 0;
int small = 0; 
if  (a > b)
{big = a;
small = b;}
else if (a < b)
{big = b;
small = a;}

Console.WriteLine("Вот они! Максимум  = " + big);
Console.WriteLine("Вот они! Минимум  = " + small);
