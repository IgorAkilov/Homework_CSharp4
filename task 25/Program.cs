// Задача 25: Напишите цикл, который принимает
// на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Prompt(string message)
{
Console.WriteLine(message);
int num = int.Parse(Console.ReadLine());
return num;
}


int numberA = Prompt("Введите число:\t");
int numberB = Prompt("Введите степень:\t");
Exponentiation(numberA, numberB);

void Exponentiation(int numA, int numB)
{
    int temp = 1;
    for(int i = 0; i < numB; i ++)
    {
        
        temp *= numA;
    }
    Console.WriteLine(temp);
}
