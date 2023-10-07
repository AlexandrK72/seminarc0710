// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.




int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsExist(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b ;
   
}


int numbera = Prompt("Введите длину первой стороны треугольника = ");

int numberb = Prompt("Введите длину второй стороны треугольника = ");

int numberc = Prompt("Введите длину третьей стороны треугольника = ");

bool result = IsExist(numbera,numberb,numberc);

Console.WriteLine(result ? "Треугольник существует" : "Треугольник не существует");