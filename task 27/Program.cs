// Задача 27: Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt(string message)
{
Console.WriteLine(message);
int num = int.Parse(Console.ReadLine());
return num;
}

int number = Prompt("Введите число:\t");

int Count(int num){
    int result = 0;
    for(int i = 0; i < num; i++){
        int temp = num % 10;
        result += temp;
        num /= 10;
        
    }
    return result;
}

int sum = Count(number);
Console.WriteLine("Сумма цифр числа = " + sum);
