using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
       
        Console.ForegroundColor = ConsoleColor.Blue; 
        Console.WriteLine("\n\n");

        string[] welcomeMessage = {
            "          **           **          ",
            "        ******       ******        ",
            "      **********   **********      ",
            "    ************* *************    ",
            "  ********************************",
            "**********************************",
            "  ********************************",
            "    **************************    ",
            "      **********************      ",
            "        ******************        ",
            "          **************          ",
            "            **********            ",
            "              ******              ",
            "                **                ",
            "                                  ",
            "      w/ love         ",
            "        by Pedro    "
        };

      
        for (int i = 0; i < welcomeMessage.Length; i++)
        {
            Console.WriteLine(welcomeMessage[i]);
            Thread.Sleep(200);
        }

        Console.ResetColor(); 
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear(); 

      
        int opcao;
        double num1, num2, resultado;

        do
        {
            Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("5-Sair");

            opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 4)
            {
                Console.WriteLine("Digite o primeiro número:");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                num2 = double.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Resultado da Adição: {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Resultado da Subtração: {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado da Divisão: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero!");
                        }
                        break;
                }
            }
            else if (opcao != 5)
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
            }

            Console.WriteLine(); 
        } while (opcao != 5);

        Console.WriteLine("Calculadora encerrada. Obrigado!");
    }
}