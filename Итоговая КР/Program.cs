using System;

class Program
{
    static void Main()
    {
        // ввод массива с клавиатуры
        Console.Write("Введите элементы массива через пробел: ");
        string[] inputArray = Console.ReadLine().Split(' ');

        // формирование нового массива
        string[] resultArray = FilterArrayByLength(inputArray, 3);

        // вывод нового массива
        Console.WriteLine("Новый массив: " + string.Join(" ", resultArray));
    }

    static string[] FilterArrayByLength(string[] inputArray, int maxLength)
    {
        int count = 0;
        // вычисление размера нового массива
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                count++;
            }
        }

        // создание нового массива
        string[] resultArray = new string[count];
        int index = 0;

        // заполнение нового массива
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}