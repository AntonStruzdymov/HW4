int startNumber = 200;
string answer1 = "";
string space = ", ";
while (startNumber <= 500)
{
    if (startNumber % 17 == 0)
    {
        string to17th = startNumber.ToString();
        answer1 += to17th + space;
    }
    startNumber++;
}
char[] end = { ',' , ' '};
string answer = answer1.TrimEnd(end);
Console.WriteLine(answer);