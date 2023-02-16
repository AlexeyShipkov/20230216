// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] Intersection (int b1, int k1, int b2, int k2)
{
    double x = Convert.ToDouble(b2-b1)/Convert.ToDouble(k1-k2);
    double y = x*k1 + b1;
    double [] array = new double[2];
    array[0] = Math.Round(x,1);
    array[1] = Math.Round(y,1);
    return array;
}
void ShowArray (double [] array)   //  метод вывода массива 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("input b1");
int user_b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input k1");
int user_k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input b2");
int user_b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input k2");
int user_k2 = Convert.ToInt32(Console.ReadLine());

if (user_k1 == user_k2)
Console.WriteLine("The lines are parallel");
else
{
    double [] newArray = Intersection(user_b1, user_k1, user_b2, user_k2);
    ShowArray(newArray);
}

