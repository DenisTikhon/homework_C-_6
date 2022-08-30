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
Console.WriteLine(count);
//задача 43