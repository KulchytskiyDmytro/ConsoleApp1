// See https://aka.ms/new-console-template for more information



int a1;
int step;
int n;
int sum = 0;
Console.WriteLine("Кульчицький Дмитро Олександрович");
Console.WriteLine("Введите первый элемент");
a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите знаменатель прогрессии");
step = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число элементов");
n = Convert.ToInt32(Console.ReadLine());
     
sum = ((2*a1+step*(n-1))/2)*n;
Console.WriteLine("Сумма членов прогрессии равна " + Convert.ToString(sum));
Console.ReadKey();
