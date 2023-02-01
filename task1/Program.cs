// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int NumberInput()
{
    int number;
    while (true)
    {
        string? str = Console.ReadLine();
        if (int.TryParse(str, out number))
        {
            break;
        }
        else
            Console.WriteLine("Введено не число. Попробуйте снова: ");
    }

    return number;
}

int counter = 0, M = 5;
Console.WriteLine("Введите М чисел: ");
for (int i = 0; i < M; i++)
{
    int num = NumberInput();
    if (num > 0)
    {
        counter++;
    }
}
Console.WriteLine(counter);