class Arbol
{
    public static void Main(string[] args)
    {
        int width;
        int height;

        Console.WriteLine("How width do you want your tree?");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How height do you want your tree?");
        height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("      0");
        for (int i = 1; i <= 6; i++)
        {
            for (int l = 5; l >= i; l--)
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
            Console.WriteLine("     |||");
        }
    }
}