//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] InputArray()
{
    int[] result = new int[8];
    for(int i=0;i<8;i++)
    {
        Console.WriteLine("Введите элемент массива");
        result[i]=Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

void OutputArray(int[] Arr)
{
    int N = Arr.Length;
    for(int i=0;i<N;i++)
    {
        if(i==0) Console.Write("[" + Arr[i]);
        else Console.Write("," + Arr[i]);
    }
    Console.Write("]");
}

OutputArray(InputArray());