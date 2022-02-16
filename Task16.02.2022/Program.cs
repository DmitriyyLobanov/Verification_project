// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключиельно массивами.

Console.Clear();

string s = string.Empty;

while (String.IsNullOrEmpty(s))
{
    Console.WriteLine("Введите элементы массива через пробел:");
    s = Console.ReadLine();
}
string[] inputArray = s.Split(' ');

void PrintArray(string[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write('"');
        Console.Write($"{array[i]}");
        Console.Write('"');
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(']');
}
string[] CreateShortArray(string[] array)
{
    string[] result = new string[1];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            if (i != array.Length - 1)
            {
                Array.Resize(ref result, result.Length + 1);
                j++;
            }
        }
    }
    return result;
}

string[] newArray = CreateShortArray(inputArray);

Console.WriteLine("Вывод: [Введенный пользователем первичный массив строк] -> [Массив сток полученный после преобразования первичного массива]");
PrintArray(inputArray);
Console.Write(" -> ");
PrintArray(newArray);