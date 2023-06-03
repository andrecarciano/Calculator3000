using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator3000
{
    class Program
    {
        enum Menu {Soma=1, Subtração, Divisão, Multiplicação, Potencia, Raiz, Sair};

        static void Main(string[] args)
        {
            bool selecaosair = false;
            while (!selecaosair)
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo a CALCULATOR 3000, escolha uma das opções a baixo: ");
                Console.WriteLine("1 - Soma \n2 - Subtração \n3 - Divisão \n4 - Multiplicação " +
                    "\n5 - Potencia \n6 - Raiz \n7 - Sair");
                Menu opcoes = (Menu)int.Parse(Console.ReadLine()); //Conversão para o enum através de CAST
                switch (opcoes)
                {
                    case Menu.Soma:
                        Console.Write("Quantos numeros você quer somar ? : ");
                        int quantidade = int.Parse(Console.ReadLine());
                        int res = 0;
                        int[] array = new int[quantidade];

                        for (int i = 1; i <= quantidade; i++)
                        {
                            Console.Write("\nDigite o {0}º Numero: ",i);
                            int num = int.Parse(Console.ReadLine());
                            array[i-1] = num;
                            res += num;

                        }

                        Console.WriteLine("\nSomando...");
                        Thread.Sleep(1000);
                        Console.Write("\nVoce Digitou {0} numeros e a soma deles é: ", quantidade);
                        for(int i = 1; i <=quantidade; i++)
                        {
                            if (i != array.Length)
                            {
                                Console.Write(array[i-1]);
                                Thread.Sleep(800);
                                Console.Write(" + ");
                                Thread.Sleep(800);
                            }
                            else { 
                                Console.Write(array[i-1]);
                                Thread.Sleep(800);
                                Console.Write(" = ");
                                Thread.Sleep(800);

                            }
                        }
                        Console.WriteLine(res);
                        Thread.Sleep(2000);
                        Console.Write("Pressione \u0022enter\u0022 para voltar ao menu principal: ");
                        Console.ReadLine();

                        break;

                    case Menu.Subtração:

                        Console.Write("Quantos numeros você quer subtrair ? : ");
                        quantidade = int.Parse(Console.ReadLine());
                        res = 0;
                        array = new int[quantidade];

                        for (int i = 1; i <= quantidade; i++)
                        {
                            Console.Write("\nDigite o {0}º Numero: ", i);
                            int num = int.Parse(Console.ReadLine());
                            array[i - 1] = num;
                            if (i==1){ res = num; }
                            else { res -= num;}
                        }

                        Console.WriteLine("\nSubtraindo...");
                        Thread.Sleep(1000);
                        Console.Write("\nVoce Digitou {0} numeros e a subtração deles é: ", quantidade);
                        for (int i = 1; i <= quantidade; i++)
                        {
                            if (i != array.Length)
                            {
                                Console.Write(array[i - 1]);
                                Thread.Sleep(800);
                                Console.Write(" - ");
                                Thread.Sleep(800);
                            }
                            else
                            {
                                Console.Write(array[i - 1]);
                                Thread.Sleep(800);
                                Console.Write(" = ");
                                Thread.Sleep(800);

                            }
                        }
                        Console.WriteLine(res);
                        Thread.Sleep(2000);
                        Console.Write("Pressione \u0022enter\u0022 para voltar ao menu principal: ");
                        Console.ReadLine();
                        break;

                    case Menu.Divisão:

                        Console.Write("Quantos numeros você quer dividir ? : ");
                        quantidade = int.Parse(Console.ReadLine());
                        float resdiv = 0f;
                        float[] arraydiv = new float[quantidade];

                        for (int i = 1; i <= quantidade; i++)
                        {
                            Console.Write("\nDigite o {0}º Numero: ", i);
                            float num = float.Parse(Console.ReadLine());
                            arraydiv[i - 1] = num;
                            if (i == 1) { resdiv = num; }
                            else { resdiv /= num; }
                        }

                        Console.WriteLine("\nDividindo...");
                        Thread.Sleep(1000);
                        Console.Write("\nVoce Digitou {0} numeros e a divisão deles é: ", quantidade);
                        for (int i = 1; i <= quantidade; i++)
                        {
                            if (i != arraydiv.Length)
                            {
                                Console.Write(arraydiv[i - 1]);
                                Thread.Sleep(800);
                                Console.Write(" / ");
                                Thread.Sleep(800);
                            }
                            else
                            {
                                Console.Write(arraydiv[i - 1]);
                                Thread.Sleep(800);
                                Console.Write(" = ");
                                Thread.Sleep(800);

                            }
                        }
                        Console.WriteLine(resdiv);
                        Thread.Sleep(2000);
                        Console.Write("Pressione \u0022enter\u0022 para voltar ao menu principal: ");
                        Console.ReadLine();

                        break;

                    case Menu.Multiplicação:
                        Console.WriteLine("Em Construção :)");
                        Thread.Sleep(2000);
                        break;

                    case Menu.Potencia:
                        Console.WriteLine("Em Construção :)");
                        Thread.Sleep(2000);
                        break;

                    case Menu.Raiz:
                        Console.WriteLine("Em Construção :)");
                        Thread.Sleep(2000);
                        break;

                    case Menu.Sair:
                        selecaosair = true;
                        Console.WriteLine("Obrigado por usar a CALCULATOR 3000. Até a proxima!");
                        break;




                }

                
            }


            


        }
    }
}
