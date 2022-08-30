//задача 41
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int i = 0;
int[] Nums = new int[M];
while (i < M) {
    Console.Write("Введите число "+ (i+1) +" :");
    Nums[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
int count = 0;
int index = 0;
while (index < Nums.Length) {
if (Nums[index] > 0) {count++;}
index++;
}
Console.WriteLine("Количество положительных чисел "+count);
//задача 43
Console.WriteLine("Задайте значения b1, k1, b2 и k2");
Console.WriteLine("введите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
if ((k1 == k2) & (b1 == b2)) {Console.WriteLine("одинаковые прямые");} 
else if (k1==k2) {Console.WriteLine("паралельные");} else {
double x = (b2 - b1)/(k1 - k2);
double y = k1*x+b1;
Console.WriteLine("пересекутся в точке  X:" +x+ ", Y:"+ y);}
