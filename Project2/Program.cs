// Вывод случайного трёхзначного числа и удаление второй цифры
int num = new Random().Next(99,1000);
Console.WriteLine("Сгенерировано случайное число: " +num);

int snowNewNum (int num1)
{
    int firstSymbol = num1 / 100;
    int secondSymbol = num1 %10;
    int newNum = firstSymbol*10 + secondSymbol;

    return (newNum);
}

Console.WriteLine(snowNewNum(num));// второе решение
//int snownumber(){
    //int num = Random().Next(100,999);
    //int first = num/100;
    //int second num%10;
    //
    //return First*10+second;
    //
//}
//Console.WriteLine(snownumber());