using System;
public class Sample
{
    public static void Main()
    {
        int i, n;
        double s = 0.0;


            Console.Write("\n\n");
            Console.Write("Calculate the Harmonic number :\n");
            Console.Write("___________________");
        n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <=n; i++)
            {
            Console.Write("1/{0} + ", i);
            s += 1 / (float)i;
            }
        Console.Write("\nnth harmonic value : \n,n,s");
    }
}