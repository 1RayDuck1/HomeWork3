//Задча 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


/*
string Palim(int num)
{
    int number = num;
    int rev = 0;
    while(num > 0)
    {
        rev = rev * 10 + num % 10;
        num = num / 10;
    }
    if(rev == number)
    {
        return("Да.");
    }
    else
        return("Нет.");

}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string ans = Palim(number);

Console.WriteLine($"{number} -> {ans}");
*/




// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void PrintCoub(int num)
{
    double number = 1;
    double coub1 = 3;
    for(int b = 0; b < num; b++)
    {
        double coub = Math.Pow(number,coub1);
        if (b == num - 1)
        {
            Console.WriteLine($"{coub}.");
        }
        else
        {
            Console.Write($"{coub}, ");
        }
        number++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintCoub(number);
*/