// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] OutPut(string[] input, int size)
{
    int[] length = new int[input.Length];
    int j = 0;
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        length[i] = input[i].Length; if (length[i] <= size) count++;
    }
    string[] output = new string[count];
    for (int i = 0; i < input.Length; i++)
    {
        length[i] = input[i].Length; if (length[i] <= size) { output[j] = input[i]; j++; }
    }
    return output;
}
void PrintArray(string[] array)
{
    Console.Write($"[");
    foreach (string item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine($"]");
}
Console.WriteLine("Сколько строк вы хотите ввести?(введите целым числом)");
int length = Convert.ToInt32(Console.ReadLine());
string[] input = new string[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i+1} й ряд символов");
    input[i] = Console.ReadLine();
}
PrintArray(input);
Console.WriteLine($"С каким максимальным числом символов строки вы хотите вывести на экран ?");
int size = Convert.ToInt32(Console.ReadLine());
string[] output = OutPut(input,size);
System.Console.WriteLine($"Строки длина, которых меньше, либо равна {size} символам: ");
PrintArray(output);

