using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double>();
            for (Int32 I = 0; I < 3; I++)
            {
                double input = Convert.ToDouble(Console.ReadLine());

                numbers.Add(input);
                if (I == 3)
                {


                    break;

                }

            }

            Console.WriteLine(" ");

            double X;
            X = numbers[0];
            double XB = Math.Round((Double)X, 2);
            double Y;
            Y = numbers[1];
            double YB = Math.Round((Double)Y, 2);
            double Z;
            Z = numbers[2];
            double ZB = Math.Round((Double)Z, 2);


            double A;
            A = numbers[0];
            double AB = Math.Round((Double)A, 2);
            double B;
            B = numbers[1];
            double BB = Math.Round((Double)B, 2);
            double C;
            C = numbers[2];
            double CB = Math.Round((Double)C, 2);

            double D;
            D = numbers[0];
            int DB = Convert.ToInt32(D);
            double E;
            E = numbers[1];
            int EB = Convert.ToInt32(E);
            double F;
            F = numbers[2];
            int FB = Convert.ToInt32(F);

            double G;
            G = numbers[0] * 31.65;
            double GB = Math.Round((Double)G, 2);
            double H;
            H = numbers[1] * 31.65;
            double HB = Math.Round((Double)H, 2);
            double J;
            J = numbers[2] * 31.65;
            double JB = Math.Round((Double)J, 2);


            Console.WriteLine("Total is {0}", numbers[0] + numbers[1] + numbers[2]);



            Console.WriteLine("Average is {0}", ((numbers[0] + numbers[1] + numbers[2]) / 3));
            if (numbers[0] < numbers[1] && numbers[0] < numbers[2])
                Console.WriteLine("{0} is the lowest", numbers[0]);
            if (numbers[1] < numbers[0] && numbers[1] < numbers[2])
                Console.WriteLine("{0} is the lowest", numbers[1]);
            if (numbers[2] < numbers[0] && numbers[2] < numbers[1])
                Console.WriteLine("{0} is the lowest", numbers[2]);



            if (numbers[0] > numbers[1] && numbers[0] > numbers[2])
                Console.WriteLine("{0} is the highest", numbers[0]);
            if (numbers[1] > numbers[0] && numbers[1] > numbers[2])
                Console.WriteLine("{0} is the highest", numbers[1]);
            if (numbers[2] > numbers[0] && numbers[2] > numbers[1])
                Console.WriteLine("{0} is the highest", numbers[2]);

            Console.WriteLine(" ");


            Console.WriteLine("{0} is ${0} USD", AB);
            Console.WriteLine("{0} is ${0} USD", BB);
            Console.WriteLine("{0} is ${0} USD", CB);

            Console.WriteLine(" ");


            Console.WriteLine("{0} is {0}kr of Swedish krona", AB);
            Console.WriteLine("{0} is {0}kr of Swedish krona", BB);
            Console.WriteLine("{0} is {0}kr of Swedish krona", CB);

            Console.WriteLine(" ");


            Console.WriteLine("{0} is {0}Yen of Japanese Yen", DB);
            Console.WriteLine("{0} is {0}Yen of Japanese Yen", EB);
            Console.WriteLine("{0} is {0}Yen of Japanese Yen", FB);

            Console.WriteLine(" ");


            Console.WriteLine("{0} is {0}Baht of Thai Baht", AB);
            Console.WriteLine("{0} is {0}Baht of Thai Baht", BB);
            Console.WriteLine("{0} is {0}Baht of Thai Baht", CB);






            Console.ReadKey();



        }
    }
}
        
