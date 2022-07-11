// Является ли одно из двух чисел квадратом другого
Console.WriteLine("Введите два числа");
int firstnum = Convert.ToInt32(Console.ReadLine());
int secondnum = Convert.ToInt32(Console.ReadLine());
string square (int num1,int num2)
{
    if (num1*num1==num2)
    {
        return "второе число - квадрат первого";
    }
    else
        if (num2*num2==num1)
      {
          return "первое число - квадрат второго";
      }
      else
      {
        return "ни одно число не является квадратом другого";
      }
}
Console.WriteLine(square(firstnum, secondnum));

