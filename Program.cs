// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Колличество чисел:");
// int num=Convert.ToInt32(Console.ReadLine());
// int[] array=new int[num];
// int sum=0;
// for(int i=0; i<array.Length;i++)
// {
//     array[i]=new Random().Next(-10,10);
//     Console.Write(array[i]+" ");
//     if (array[i]>0)
//         {
//             sum++;
//         }
// } 
// Console.WriteLine();
// Console.Write("четных чисел:"+sum);

//_________________________________________________________________________

//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("введите значение k1:");
int k1=Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b1:");
int b1=Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение k2:");
int k2=Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2:");
int b2=Convert.ToInt32(Console.ReadLine());
if(k1==k2)
{
    Console.Write("прямые параллельны");
}
else{
    int x = -(b1 - b2) / (k1 - k2);
    int y = k1 * x + b1;
    Console.Write("пересечение в точке:"+x+" "+y);
}




