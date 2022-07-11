// Программа, которая принимает на вход число и проверяет его на кратность 7 и 23
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
string check (int num1)
{
    if (num1 % 7==0 || num1 % 23==0)//или && если число должно быть кратно и 7 и 23
    {
        return "число кратно";
    }
    else
    {
        return "число не кратно";
    }
}
Console.WriteLine(check(Num));