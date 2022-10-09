// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadData (string line)
{
Console.WriteLine(line);
int number = int.Parse(Console.ReadLine()??"");
return number;
}

void PrintData (string prefix, string value)
{
    Console.WriteLine(prefix+value);
}

int PolyTest(int chislo)
{
int res = 0;
    if ((chislo / 10000 == chislo % 10) && ((chislo / 1000)%10 == (chislo / 10) % 10)) res = 1;

    else res= 0;
return res;
}

int num = ReadData("Введите пятизначное число: ");
if (num < 10000 || num > 99999)
{
    PrintData("Число не пятизначное", "");    
} 
else
{
    if (PolyTest(num) == 1)
    {
        PrintData(num.ToString(), " - палиндром");
    }
    else
    {
        PrintData(num.ToString(), " - не палиндром");
    }
}