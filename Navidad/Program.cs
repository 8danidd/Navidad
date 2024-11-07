using System;
class Arbol
{
    public static void Main(string[] args)
    {
        int height;

        Console.WriteLine("How tall do you want your tree?");
        height = Convert.ToInt32(Console.ReadLine());

        for (int p = -1; p < height; p++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("0");

        for (int i = 1; i <= height; i++)
        {
            for (int l = height; l >= i; l--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.Write(i);
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int ñ = 0; ñ < 2; ñ++)
        {
            for (int p = 0; p < height; p++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|||");
        }
    }
}
