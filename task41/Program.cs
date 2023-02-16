// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PositiveNumber()
{ 
    Console.WriteLine("Enter numbers, enter n to stop");
    string inp = "";
    int count = 0;
    while (inp != "n")
   {
        inp = Console.ReadLine();
        if (inp == "n") 
        {
            Console.WriteLine("exit by user");
        }
        else
        {
            int num = Convert.ToInt32(inp);
            if (num > 0) 
                count++;       
        }
    }
    Console.WriteLine($"You entered {count} positive numbers");
}
PositiveNumber();