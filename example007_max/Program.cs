double numberA = new Random().Next(1, 100);
Console.WriteLine(numberA);
double numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);
double numberC = new Random().Next(1, 100);
Console.WriteLine(numberC);
double numberD = new Random().Next(1, 100);
Console.WriteLine(numberD);

double max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
if (numberD > max) max = numberD;

Console.Write("Максимальное число: ");
Console.WriteLine(max);
