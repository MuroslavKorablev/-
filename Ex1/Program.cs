using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine()!;

        // Разбиваем введенные строки на массив строк
        string[] inputArray = input.Split(',');

        // Формируем новый массив из строк, длина которых меньше или равна 3 символам
        string[] resultArray = FilterStrings(inputArray);

        // Выводим результат
        Console.WriteLine("Результат:");
        Console.WriteLine("[" + string.Join(", ", resultArray) + "]");
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        // Определяем количество строк, удовлетворяющих условию
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (IsStringLengthLessOrEqualThree(inputArray[i]))
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] resultArray = new string[count];

        // Заполняем новый массив строками, удовлетворяющими условию
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (IsStringLengthLessOrEqualThree(inputArray[i]))
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }




