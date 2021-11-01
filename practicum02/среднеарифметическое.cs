// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
//Создать на его основе масив B, отбрасывая те, которые
//нарушают порядок возрастания
//больше среднего арифметического элементов A
//чётные

int lenght = 8;
int[] A = new int[lenght];
int index = 0;

while (index < lenght)
{
    A[index] = new Random().Next(10, 100);
    index++;
}

index = 0;
while (index < lenght)
{
    int array = A[index];
    Console.WriteLine(array);
    index++;
}

Console.WriteLine();

int sum = A.Sum();
index = 0;

int SrAr = sum / lenght;
Console.WriteLine("Среднее арифметическое = " + SrAr);
Console.WriteLine();

index = 0;
while (index <= lenght)
{
    int B = A[index];
    if (B > SrAr)
    {
        Console.WriteLine(B);
        index++;
    }
}
index++;
