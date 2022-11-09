
/*
// Задача 19

// Напишите программу, которая 
// 1. Принимает на вход пятизначное число и 
// 2. Проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = 0;
while (number < 10000 || number > 99999)

{
    Console.Write("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

if (Palindrom(number)) Console.WriteLine($"{number} Данное число является палиндромом");
else Console.WriteLine($"{number} Данное число не является палиндромом");

bool Palindrom(int num)
{
    int n1 = num / 10000;
    int n2 = num / 1000 % 10;
    int n4 = num / 10 % 10;
    int n5 = num % 10;
    // Console.WriteLine($"{n1} {n2} {n4} {n5} ");
    if (n1 == n5 && n2 == n4) return true;
    return false;
}
*/

// Задача 21

// Напишите программу, которая 
// 1. Принимает на вход координаты двух точек и 
// 2. Находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


/*
int[] x = { 0, 0 };
int[] y = { 0, 0 };
int[] z = { 0, 0 };

for (int i = 0; i < 2; i++)
{
    Console.Write($"ВВЕдите x{i + 1} ");
    x[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"ВВЕдите y{i + 1} ");
    y[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"ВВЕдите z{i + 1} ");
    z[i] = Convert.ToInt32(Console.ReadLine());
}


int xPoint = x[1] - x[0];
int yPoint = y[1] - y[0];
int zPoint = z[1] - z[0];

Console.WriteLine($"Расстояние между двумя заданными координатами равно {Res(xPoint, yPoint, zPoint)}");

double Res(int xx, int yy, int zz)
{
    double r = Math.Sqrt(xx * xx + yy * yy+ zz * zz);
    r = Math.Round(r, 2, MidpointRounding.ToZero);

    return r;
}
*/


// Задача 23

// Напишите программу, которая 
// 1. Принимает на вход число (N) и 
// 2. Выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

/*
int num = 0;
while (num < 1)
{
    Console.WriteLine("Введите число:");
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        KvadratNum(num);
        break;
    }
}

void KvadratNum(int num1)
{
    for (int i = 1; i <= num1; i++) Console.WriteLine($"{i,5}\t|{Math.Pow(i,3),5}");
}
*/