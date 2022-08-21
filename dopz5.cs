// 1. Задан массив дней недели. По введенному порядковому номеру
// выводится название дня недели и количество дней до Вс.

// Console.Clear();
// string[] dw = {"Пн","Вт","Ср","Чт","Пт","Сб","Вс"};
// Console.WriteLine("Введите порядковый номер дня недели (от 1 до 7): ");
// int day = Convert.ToInt32(Console.ReadLine())-1;
// int sun = 0;
// while (day<0 && day<6)
// {
//     Console.Write("Вы ввели не от 1 до 7, исправьте: ");
//     int day2=Convert.ToInt32(Console.ReadLine());
//     if (day2>0 && day2<7)
//     {
//         day=day2-1;
//     }
// }
// if (day==6)
// {
//     Console.WriteLine("Вы выбрали воскресение.");
// }
// else
// {
//     for (int i = day; i < 6; i++)
//     {
//         sun++;
//     }
//     Console.WriteLine($"Вы выбрали - {dw[day]}. До воскресения осталось дней: {sun}");
// }





// 2. Заданы диагонали мониторов в дюймах: 10.1, 11.6, 14, 15.6, 17, 19, 24, 27.
// Формируется и выводится таблица перевода диагоналей в сантиметры.

// Console.Clear();
// double[] mas = {10.1, 11.6, 14, 15.6, 17, 19, 24, 27};
// double cen = 0;
// double inch = 0;
// Console.WriteLine("Дюймы = Сантиметры");
// for (int i = 0; i < mas.Length; i++)
// {
//     cen=mas[i]*2.54;
//     cen=Math.Round(cen, 1);
//     inch=mas[i];
//     Console.WriteLine($"{inch} = {cen}");
// }





// 3. Формируется массив из 7 целых двузначных чисел путем ввода с клавиатуры.
// Выводится этот массив, четные числа и их количество. ( for, foreach )

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
int chet=0;
int elem=7;
Console.WriteLine("Введите первое целое двузначное число случайно генерируемого диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее целое двузначное число случайно генерируемого диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());
if (min>=0)
{
    while (max==min)
    {
        Console.WriteLine("Ваше первое и вторые числа равны, исправьте!");
        Console.WriteLine("Введите первое целое двузначное число случайно генерируемого диапазона: ");
        int min2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите последнее целое двузначное число случайно генерируемого диапазона: ");
        int max2=Convert.ToInt32(Console.ReadLine());
        if (max2>min2||max2<min2)
        {
            min=min2;
            max=max2;
        }
    }
    while (max<min)
    {
        Console.WriteLine("Ваше первое число больше второго, исправьте!");
        Console.WriteLine("Введите первое целое двузначное число случайно генерируемого диапазона: ");
        int min2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите последнее целое двузначное число случайно генерируемого диапазона: ");
        int max2=Convert.ToInt32(Console.ReadLine());
        if (max2>min2)
        {
            min=min2;
            max=max2;
        }
    }
    while (min<9 || min>100)
    {
        Console.Write("Вы ввели не двузначное первое число, исправьте: ");
        int min2=Convert.ToInt32(Console.ReadLine());
        if (min2>9 && min2<100)
        {
            min=min2;
        }
    }
    while (max<9 || max>100)
    {
        Console.Write("Вы ввели не двузначное второе число, исправьте: ");
        int max2=Convert.ToInt32(Console.ReadLine());
        if (max2>9 && max2<100)
        {
            max=max2;
        }
    }
}
else
{
    while (max==min)
    {
        Console.WriteLine("Ваше первое и вторые числа равны, исправьте!");
        Console.WriteLine("Введите первое целое двузначное число случайно генерируемого диапазона: ");
        int min2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите последнее целое двузначное число случайно генерируемого диапазона: ");
        int max2=Convert.ToInt32(Console.ReadLine());
        if (max2>min2||max2<min2)
        {
            min=min2;
            max=max2;
        }
    }
    while (max<min)
    {
        Console.WriteLine("Ваше первое число больше второго, исправьте!");
        Console.WriteLine("Введите первое целое двузначное число случайно генерируемого диапазона: ");
        int min2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите последнее целое двузначное число случайно генерируемого диапазона: ");
        int max2=Convert.ToInt32(Console.ReadLine());
        if (max2>min2)
        {
            min=min2;
            max=max2;
        }
    }
     while (min>-9 || min<-100)
    {
        Console.Write("Вы ввели не двузначное первое число, исправьте: ");
        int min2=Convert.ToInt32(Console.ReadLine());
        if (min2<-9 && min2>-100)
        {
            min=min2;
        }
    }
}
int[] mas = CreateRandomArray(elem, min, max);
Console.Write("Ваш массив: ");
ShowArray(mas);
Console.Write("Четные числа в массиве: ");
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i]%2==0)
    {
        int znach=mas[i];
        chet++;
        Console.Write($"{znach} ");
    }

}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {chet}");


// 4. Формируется массив из n натуральных нечетных чисел.
// Выводится исходный массив и числа кратные 3. ( for, foreach )
// 5. Формируется массив из n целых случайных чисел от 10 до 99
// Выводится исходный массив, нечетные числа и их количество. ( for, foreach )
// 6. Формируется массив из n целых случайных чисел от -50 до 50.
// Массив упорядочивается. Выводятся числа в интервале от – 20 до +20.
// 7. Формируется массив из n целых случайных чисел от -40 до 40.
// Выводятся нечетные отрицательные числа и их к-во. ( for, foreach )
// 8. Формируется массив из n целых случайных чисел от -50 до 50.
// Выводятся положительные числа в порядке убывания и их количество.
// 9. Заданы массивы названий и обозначений транспортных средств, а также
// их скоростей, например: a – автомобиль, 70 км/ч; v – велосипед, 12 км/ч;
// m - мотоцикл, 60 км/ч; p – поезд, 90 км/ч; s – самолет, 800 км/ч)
// По введенному обозначению транспортного средства
// выводится его название и скорость.
// 10. * По введенному порядковому номеру месяца и дате выводится:
// название месяца, количество дней в нем, количество дней, оставшихся
// до конца текущего месяца, название следующего месяца.