Console.Write(" Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write(" Введите третье число ");
int n = Convert.ToInt32(Console.ReadLine());

double max=0;
if (a > b)
max = a;
else if  (b > n)
max = b;
else if (n > a)
max = n;
Console.WriteLine("Вот он! Максимум из 3 = " + max);


