int VvodElementa(int i)
{
    Console.Write($"Введите числовой элемент # {i} ");
    int Elem = int.Parse(Console.ReadLine());
    return Elem;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i=0; i < 7; i++)
    {
     Console.Write($"{arr[i]}, ");
    } 
    Console.Write($"{arr[7]}]");
}

Console.Clear();
int[] arr = new int[8];
for(int k = 0; k < 8; k++)
{
    arr[k] = VvodElementa(k+1);

}
PrintArray(arr);