// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
//Создать на его основе масив B, отбрасывая те, которые
//нарушают порядок возрастания
//больше среднего арифметического элементов A
//чётные

int[] A = new int[8];
int index = 0;

while (index < 8)
{
    A[index] = new Random().Next(10, 100);
    index++;
}

index = 0;
while (index < 8)
{
    int array = A[index];
    Console.WriteLine(array);
    index++;
}

Console.WriteLine();

index = 0;
while (index <= 8)
{
    int B = A[index];
    if (B % 2 == 0)
    {
        Console.WriteLine(B);
        index++;
    }
    index++;
}