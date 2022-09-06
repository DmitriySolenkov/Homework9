int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

string PrintNumRec(int start, int end)
{
    if (start == end) return Convert.ToString(start);
    else return (start + " " + PrintNumRec(start + 1, end));
}

int start = Prompt("Введите число M:");
int end = Prompt("Введите число N:");


if (start <= end)
{
    Console.WriteLine(PrintNumRec(start, end));
}
else
{
    Console.WriteLine(PrintNumRec(end, start));
}