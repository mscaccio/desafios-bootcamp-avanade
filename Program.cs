using System;
using static System.Console;

class Desafios
{
    static void Main(string[] args)
    {
        // Desafios matemáticos em C#
        WriteLine("2/3 - Programa para Validação de Notas");
        CalculaMedia();

        Console.WriteLine();

        //Desafios avançados em C#
        WriteLine("1/3 - Teorema da Divisão Euclidiana");
        DivisaoEuclidiana();
    }

    public static void CalculaMedia()
    {
        double nota1 = -1,
               nota2 = -1,
               media;

        while (true)
        {
            if (nota1 < 0 || nota1 > 10)
            {
                if (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    continue;
                }
            }
            else if (nota2 < 0 || nota2 > 10)
            {
                if (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    continue;
                }
            }
            else if (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10)
            {
                media = (nota1 + nota2) / 2;
                Console.Write("media = ");
                Console.WriteLine(media.ToString("N2"));

                while (true)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    double res = double.Parse(Console.ReadLine());

                    if (res < 1 || res > 2)
                        continue;
                    else if (res >= 1 && res <= 2)
                    {
                        if (res == 1)
                        {
                            nota1 = -1;
                            nota2 = -1;
                            break;
                        }

                        if (res == 2)
                            return;
                    }
                }
            }
        }
    }

    public static void DivisaoEuclidiana()
    {
        string[] valores = Console.ReadLine().Split();
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int q, r;

        q = a / b;
        r = a % b;

        if (r < 0)
        {
            double q1, r1 = 0.0;

            r1 = r + Math.Sqrt(b * b);
            q1 = (a - r1) / b;

            Console.WriteLine("{0} {1}", q1, r1);
        }
        else
            Console.WriteLine("{0} {1}", q, r);
    }
}