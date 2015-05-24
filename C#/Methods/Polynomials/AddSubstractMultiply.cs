using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomials
{
    class AddSubstractMultiply
    {
        static void Main()
        {
            Console.WriteLine("NOTE: When substracting polynomial B is going to be substracted from polynomial A (A - B)");
            Console.WriteLine("Enter coefficients of equasion A:");
            int[] coefficientsA = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter coefficient of equation B:");
            int[] coefficientsB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            Console.WriteLine("Polynomial A:");
            PrintPolynomial(coefficientsA);
            Console.WriteLine("Polynomial B:");
            PrintPolynomial(coefficientsB);
            Console.WriteLine("Polynomial A + Polynomial B:");
            PrintPolynomial(AddPolynomials(coefficientsA, coefficientsB));
            Console.WriteLine("Polynomial A - Polynomial B:");
            PrintPolynomial(SubstractPolynomials(coefficientsA, coefficientsB));
            Console.WriteLine("Polynomial A * Polynomial B:");
            PrintPolynomial(MultiplyPolynomials(coefficientsA, coefficientsB));
        }

        static void PrintPolynomial (int[] coefficients)
        {
            for (int i = coefficients.Length - 1; i >= 0; i--)
            {
                Console.Write(coefficients[i] + "*x^" + i + (i == 0 ? "\n" : " + "));
            }
        }

        static int[] AddPolynomials (int[] coefficientA, int[] coefficientB)
        {
            int[] addedPolynomials = new int[0];
            int difference = 0;
            if (coefficientA.Length > coefficientB.Length)
            {
                difference = coefficientA.Length - coefficientB.Length;
                addedPolynomials = new int[coefficientA.Length];
                for(int i = coefficientB.Length - 1; i >= 0; i--)
                {
                    addedPolynomials[i] = coefficientA[i] + coefficientB[i];
                }
                for (int i = coefficientB.Length; i < coefficientB.Length + difference; i++)
                {
                    addedPolynomials[i] = coefficientA[i];
                }
            }
            else if (coefficientB.Length > coefficientA.Length)
            {
                difference = coefficientB.Length - coefficientA.Length;
                addedPolynomials = new int[coefficientB.Length];
                for (int i = coefficientA.Length - 1; i >= 0; i--)
                {
                    addedPolynomials[i] = coefficientB[i] + coefficientA[i];
                }
                for (int i = coefficientA.Length; i < coefficientA.Length + difference; i++)
                {
                    addedPolynomials[i] = coefficientB[i];
                }
            }
            return addedPolynomials;
        }

        static int[] SubstractPolynomials (int[] coefficientA, int[] coefficientB)
        {
            int[] substractedPolynomials = new int[0];
            int difference = 0;

            if(coefficientA.Length > coefficientB.Length)
            {
                substractedPolynomials = new int[coefficientA.Length];
                difference = coefficientA.Length - coefficientB.Length;

                for (int i = coefficientB.Length - 1; i >= 0; i--)
                {
                    substractedPolynomials[i] = coefficientA[i] - coefficientB[i];
                }
                for(int i = coefficientB.Length; i < coefficientB.Length + difference; i++)
                {
                    substractedPolynomials[i] = coefficientA[i];
                }
            }

            else if (coefficientB.Length > coefficientA.Length)
            {
                substractedPolynomials = new int[coefficientB.Length];
                difference = coefficientB.Length - coefficientA.Length;

                for (int i = coefficientA.Length - 1; i >= 0; i--)
                {
                    substractedPolynomials[i] = coefficientA[i] - coefficientB[i];
                }

                for (int i = coefficientA.Length; i < coefficientA.Length + difference; i++)
                {
                    substractedPolynomials[i] = coefficientB[i];
                }
            }

            return substractedPolynomials;
        }

        static int[] MultiplyPolynomials (int[] coefficientA, int[] coefficientB)
        {
            int[] multipliedPolynomials = new int[coefficientA.Length + coefficientB.Length - 1];


            for (int i = 0; i < coefficientA.Length; i++)
            {
                for (int j = 0; j < coefficientB.Length; j++)
                {
                    multipliedPolynomials[i + j] = coefficientA[i] * coefficientB[j];
                }
            }

            return multipliedPolynomials;
        }
    }
}
