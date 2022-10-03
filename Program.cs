// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Clear();
Console.WriteLine("Введите два числа");
Console.Write("Введите первое число a = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число b = ");
int b = int.Parse(Console.ReadLine()!);
if (a > b) {
    Console.WriteLine("{0} > {1}", a, b);
    Console.WriteLine("max = {0}", a);
} else if (a < b) {
    Console.WriteLine("{0} < {1}", a, b);
    Console.WriteLine("max = {0}", b);
}
