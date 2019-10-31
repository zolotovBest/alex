using System;


namespace help
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" N: ");
            double N = double.Parse(Console.ReadLine());
            Console.WriteLine(" x: ");
            double x = double.Parse(Console.ReadLine());

            double gl = 0;
            double N1 = 1;

            for (int i = 1; i <= N; i++)
            {

                for (int k = 1; k <= N; k++)
                {

                    N1 = (N1 * 2) * k;
                }



                double hf = (Math.Pow((-1), i) - (Math.Pow(x, 2 * i) / N1));
                gl = gl + hf;

            }
            Console.Write(gl);

            Console.ReadKey();
        }
    }
}