//                    Домашняя работа к семинару № 3.
//  Найти кубы чисел от 1 до N
/*
Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);
Console.WriteLine($"Таблица кубов чисел от 1 до {N} :" );

int[] InACube(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

void OutputCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{number} ^ 3 = ");
        Console.WriteLine(array[i]);
        number++;
    }
}
int[] Table = InACube(N);
OutputCubs(Table);
*/

//   Найти сумму чисел от 1 до А
/*
Console.Write("Введите число:   ");
string writeA = Console.ReadLine();
int A = Convert.ToInt32(writeA);

int SumNumbers(int A)
{
    int number = 1;
    int sum = 0;
    for (int i = 0; i < A; i++)
    {
        sum = sum + number;
        number++;
    }
    return sum;
}

int NumbersSum = SumNumbers(A);
Console.WriteLine($"Сумма чисел от 1 до {A} составляет {NumbersSum}");
*/

//    Возведите число А в натуральную степень B используя цикл
/*
Console.Write("Введите число A:   ");
string writeNumber = Console.ReadLine();
int Number = Convert.ToInt32(writeNumber);
Console.Write("Введите число B:   ");
string writeExponent = Console.ReadLine();
int Exponent = Convert.ToInt32(writeExponent);
int count = 1;
int result = Number;

while (count < Exponent)
{
    result = result * Number;
    count++;
}

Console.WriteLine($"{Number} ^ {Exponent} = {result}");
Console.WriteLine();
*/

//   Подсчитать сумму цифр в числе
/*
int number = new Random().Next(1, 100000);
int sumDigit = 0;
Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
    int digit = number % 10;
    sumDigit = sumDigit + digit;
    number = number / 10;
}

Console.WriteLine(sumDigit);
Console.WriteLine();
*/

//   Написать программу вычисления произведения чисел от 1 до N
/*
Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int GetComposition(int x)
{
    int comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
    }
    return comp;
}

Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetComposition(N)}");
Console.WriteLine();
*/
//     Показать кубы чисел, заканчивающихся на четную цифру
/*
int N = new Random().Next(1, 50);
int number = 1;
Console.WriteLine($"Кубы числа {N} с чётной цифрой на конце: ");
while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) 
        Console.Write(cube + " ");
        number++;
}
Console.WriteLine();
*/
//     Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
/*
int N = 8;
int min = 0;
int max = 1;

int[] CreateArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

PrintArray(CreateArray(N, min, max));
*/

//     Определить, присутствует ли в заданном массиве, некоторое число
/*
int Num = 33;
int size = 18;
int min = 1;
int max = 60;
int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
bool FindNumber(int[] array, int Num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Num) return true;
    }
    return false;
}
void PrinArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
string Result = "отсутствует";
int[] array = CreateArray(size, min, max);
PrinArray(array);
Console.WriteLine();
if (FindNumber(array, Num)) Result = "присутствует";
Console.WriteLine($"Число {Num} {Result} в массиве");
*/
//    Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
/*
int size = 50;
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
    Console.WriteLine();
}
PrintResult(CreateArray(size));
*/
//    В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
/*
int size = 123;
int min = -100;
int max = 200;
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void PrintCountArray(int[] arr)
{
    int count = 1;
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
    Console.WriteLine();
    Console.WriteLine($"Количество элементов из отрезка [10, 99] равно {count}");
    Console.WriteLine();
}
PrintCountArray(CreateArray(size, min, max));
*/
//    Найти сумму чисел одномерного массива стоящих на нечетной позиции
/*
int size = 17;
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void PrintArray(int[] arr)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел, стоящих на нечётной позиции, соcтавляет {sum} ");
    Console.WriteLine();
}
PrintArray(CreateArray(size));
*/
//      Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
/*
int size = new Random().Next(10, 20);
int min = 1;
int max = 100;
Console.WriteLine($"Количество элементов массива: {size}");
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int[] GetProduct(int[] data)
{
    int[] product = new int[data.Length / 2];
    int last = data.Length - 1;
    for (int i = 0; i < data.Length / 2; i++)
    {
        product[i] = data[i] * data[last];
        last = last - 1;
    }
    return product;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int[] array = CreateArray(size, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("произведение пар чисел в массиве:");
PrintArray(GetProduct(array));
*/
//    В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом 
/*
int size = new Random().Next(1, 20);
Console.WriteLine($"Количество элементов массива: {size}");
double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}
void PrintDifferenced(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    Console.WriteLine($" {arr.Min()} Минимальное значение,   {arr.Max()} максимальное значение");
    Console.WriteLine($"Разница составляет {difference}");
}
PrintDifferenced(CreateArray(size));
*/