// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] FillArray(int size)
    {
        int[] arr=new int[size];
        for (int i=0; i<arr.Length; i++)
        {
            arr[i]=new Random().Next(-100,100);
        }
        return arr;
    }

Console.WriteLine("Введите длину массива");
int num=Convert.ToInt32(Console.ReadLine());
int[]array=FillArray(num);
Console.WriteLine(string.Join(", ",array));
int count=0;
int PozCount=0;
for (int i=0; i<array.Length; i++)
{
    if (array[i]>0)
    {PozCount=PozCount+1;
    count++;}
    else
    {count++;}
}
Console.WriteLine($"{PozCount} чисел больше нуля");
