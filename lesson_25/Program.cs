/*Напишите цикл, который принимает на вход два числа (A и B) и возводит 
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("insert number A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("insert number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;

if (b < 1)
Console.Write("B natural error\n");
else
{
    while(b!=0)
    {
        c = c * a;
        b = b - 1;
    }
    Console.WriteLine($"Number А in natural grade B: {c}");
}

