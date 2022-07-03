//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int Degree(int number, int degree)
{
    int result = 1;

    for (int i=1;i<=degree;i++)
    {  
        result = result * number;
    }
    return result;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую возвести число");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree(A, B));