using System;

class Desafios
{
    static void Main(string[] args)
    {
        // Desafios matemáticos em C# - 2 / 3 - Programa para Validação de Notas
        // https://web.digitalinnovation.one/coding/desafios-matematicos-em-c/algorithm/programa-para-validacao-de-notas?back=/track/avanade-codeanywhere-net
        CalculaMedia();
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
}