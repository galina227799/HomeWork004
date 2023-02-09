Console.Clear();
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int result = 0;


while(Number > 0)
{
    result = result + Number%10;
    Number = Number/10;
} 
Console.WriteLine(result);

