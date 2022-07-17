// Программа принимающая координаты точки (x и y), при этом x не равно 0 и y не равно нулю
// и выдающая номер четверти плоскости, в которой находится эта точка
string findQvart(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return "1";
    }
    if (x < 0 && y > 0)
    {
        return "2";
    }
    if (x < 0 && y < 0)
    {
        return "3";
    }
    if (x > 0 && y < 0)
    {
    return "4";
    }
    return "err";
}
Console.WriteLine(findQvart(-3, 3));