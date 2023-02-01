// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Input_array(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-50, 51);
}

int release(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            count ++;
    return count;
}


Console.Clear();
Console.Write("Fill in a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(release(array));