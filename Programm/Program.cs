void PrintArray(string[]a)
{
    for(int i = 0; i< a.Length; i++) Console.Write($"{a[i]} ");
}
string [] SortArr(string [] arr)
{
    string [] array = new string [arr.Length];
    for(int i = 0; i< arr.Length; i++)
    {
        if(arr[i].Length<=3)array[i] = arr[i];
    }
    return array;
}
Console.WriteLine("Сколько строковых значений будет в Вашем массиве?");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заполните Ваш массив строками");
string [] array  = new string [n];
int i = 0;
while (i < n)
{
    array[i] = Console.ReadLine();
    i++;
}
PrintArray(SortArr(array));