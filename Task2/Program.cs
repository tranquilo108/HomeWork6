//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


static void NewMethod1()
{
    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < a; i++)
    {
        int z = Convert.ToInt32(Console.ReadLine());
        if (z > 0)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}
NewMethod1();
