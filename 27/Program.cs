//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int Sum(int number)
{
    int  result = 0;

    while(number>0)
    {
        result = result + number%10;
        number = number/10;
    }

    return result;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр введённого Вами числа - " + Sum(num));