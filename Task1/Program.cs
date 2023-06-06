// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите число М");
int size = Convert.ToInt32(Console.ReadLine());
int [] NewArray ()
{
int[] array =new int [size];
for (int i=0; i <size; i++)
{
    Console.WriteLine("Введите число");
   array [i] = Convert.ToInt32(Console.ReadLine());
    
    }
    return array;
    }
   int []array = NewArray ();
   int PositiveNumbers =0;
   for (int i=0; i <size; i++)
{
    if (array[i]>0)
    {
         PositiveNumbers++;
    }
    
    }

    Console.WriteLine($"Количество положительных чисел равно { PositiveNumbers}");
