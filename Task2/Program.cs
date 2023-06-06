// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int size = 4;
double [] NewArray ()
{
double[] array =new double [size];
for (int i=0; i <size; i++)
{
    Console.WriteLine("Введите поочереди последовательно координаты первой и второй точки ");
   array [i] = Convert.ToDouble(Console.ReadLine());
    
    }
    return array;
    }
   double []array = NewArray ();
   double X = (array[2]-array[0])/(array[1]-array[3]);
   double Y = array[1]* X + array[0];
   
 Console.WriteLine($"Прямые пересекуться в точке с координатами ({X}:{Y})");
