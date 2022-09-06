int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int SumNum(int start, int end, int sum)
{
    if (start == end) return sum+start;
    else return SumNum(start+1,end, sum+start);
}

int start = Prompt("Введите число M:");
int end = Prompt("Введите число N:");


if (start <= end)
{
    Console.WriteLine(SumNum(start, end,0));
}
else
{
    Console.WriteLine(SumNum(end, start,0));
}