// Task2. Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее

void task2()
{
    Console.WriteLine("Большее и меньшее из 2х чисел");
    Console.Write("Введите число 1: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число 2: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a < b)
    {
        Console.WriteLine(b + " больше, чем " + a);
    }
    else if (a > b)
    {
        Console.WriteLine(a + " больше, чем " + b);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

// Task4. Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

void task4(){
    Console.WriteLine("Поиск максимального из 3х чисел");
    Console.Write("Введите число 1: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число 2: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число 3: ");
    int c = Convert.ToInt32(Console.ReadLine());

    int max = a;
    if(max < b) max = b;
    if(max < c) max = c;

    Console.WriteLine("max = " + max);
}

// Task6. Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка)

void task6(){
    Console.WriteLine("Проверка числа на четность");
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    bool mod2 = false;

    if(a%2 == 0) mod2 = true;

    if(mod2){
        Console.Write("Число четное");
    } else {
        Console.Write("Число нечетное");
    }
}

// Task8. Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N

void task8(){
    Console.WriteLine("Четные числа от 1 до N");

    Console.Write("Введите N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    for(int i = 1; i <= N; i++) {
        if(i % 2 == 0) Console.Write(i + ", ");
    }
}

Console.Write("Введите номер задачи: ");
int a = Convert.ToInt32(Console.ReadLine());
switch(a){
    case 2: task2();
    break;
    case 4: task4();
    break;
    case 6: task6();
    break;
    case 8: task8();
    break;
    default: Console.WriteLine("Нет такой задачи");
    break;
}