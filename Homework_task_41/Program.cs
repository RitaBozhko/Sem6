// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы хотите ввести?");
int m = int.Parse(Console.ReadLine()!);

int count = 0;
for (int i=0; i<m; i++)
{
    Console.WriteLine("Введите число: ");
    bool userEnter = int.TryParse(Console.ReadLine(), out int userNum);
    if (userNum > 0) count ++;
    if(!userEnter) break;
}

Console.WriteLine($"Вы ввели {count} чисел больше нуля.");