// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10



int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// int DectoBin(int num)
// {
//     int res = 0;
//     int mult = 1;
//     while (num > 0)
//     {
//         res += num%2 * mult;
//         num/=2;
//         mult *=10;
//     }
//     return res;
// }


string DectoBin(int num) //вычисление через строку
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num%2 + res;
        num/=2;
        
    }
    return res;
}


int number = Prompt("Введите число = ");

Console.WriteLine(DectoBin(number));