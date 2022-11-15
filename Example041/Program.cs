// Программа, которая даёт пользователю ввести с клавиатуры M чисел 
// и считает, сколько чисел больше 0 ввёл пользователь

int NumbersGreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество чисел больше 0: " + count);
    return count;
}

Console.Write("Введите числа (через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

NumbersGreaterThanZero(array);