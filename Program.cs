// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size)
// {
// int[] myArray = new int[size];
// for (int i = 0; i < size; i++)
// {
// myArray[i] = new Random().Next(100, 999 + 1);
// }
// return myArray;
// }

// void ShowArray(int[] array)
// {
// Console.WriteLine("Полученный массив ->:");
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }

// void FindHonSum (int[] array)
// {
// int count = 0;
// for(int i = 0; i < array.Length; i++)
// {
// if (array[i] % 2 == 0) 
// count++;
// }
// Console.WriteLine($"Количество четных элементов {count}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(lenght);
// ShowArray(newArray);
// FindHonSum (newArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
// int[] myArray = new int[size];
// {
// for(int i=0;i<size;i++)
// {
// myArray[i] = new Random().Next(minValue, maxValue+1);
// }
// return myArray;
// }
// }

// void ShowArray(int[] array)
// {
// Console.WriteLine("Полученный массив ->:");
// for(int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// }

// void FindNotHon (int[] array)
// {
// int sum = 0;
// for(int i = 0; i < array.Length; i+=2)
// sum = sum + array[i];
// Console.WriteLine($"Сумма нечетных элементов {sum}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray (lenght,min,max);
// ShowArray(newArray);
// FindNotHon (newArray);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] CreateRandomArray (int size)
// {
// double [] myArray = new double [size];
// for(int i=0; i<size; i++)
// {
// myArray[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
// }
// return myArray;
// }

// void ShowArray(double[] array)
// {
// Console.WriteLine("Полученный массив ->:");
// for(int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// }

// void MaxMin (double[] array)
// {
// double max = 0;
// double min = 100;

// for(int i = 0; i < array.Length; i++)   
// {
// if (array [i] > max)
// {
// max = array [i];
// }
// if ( array [i] < min )
// {
// min = array [i];
// }
// }
// Console.WriteLine($"максимальное число массива {max} минимальное число массива {min}. разница максимального и минимального числа {max - min}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// double [] newArray = CreateRandomArray (lenght);
// ShowArray(newArray);
// MaxMin (newArray);
