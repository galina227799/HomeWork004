Console.Clear();
Console.Write("Введите число возводимое  в степень: ");
int Number1 = int.Parse(Console.ReadLine());

Console.Write("Введите степень числа: ");
int Number2 = int.Parse(Console.ReadLine());

Double result = Math.Pow(Number1,Number2);
Console.WriteLine($"{Number1}^{Number2} = {result}");
