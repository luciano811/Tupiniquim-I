using System;

namespace TupiniquimI.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bem vindo ao robô Tupiniquim I ");
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Você sabe as regras do robô, vamos fazê-lo funcionar! ");
            Console.WriteLine(); Console.WriteLine();

            int x = 0, y = 0;
                        

                      

            Console.WriteLine("Orientação atual do Robô   (0,0,N)");
            Console.WriteLine(); Console.WriteLine();


            Console.WriteLine("Digite a opção que você para o robô (e = Vira a esquerda, d = Vira a direita, m = Move-se para o respectivo lado");

            string a;
            string Z = "N";

            

            a = Console.ReadLine();



            if (a == "d")
            {
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("O Tupiniquim virou-se para o Leste");
                Z = "L";
                Console.WriteLine();
                Console.Write("Orientação atual do Robô   ("); Console.Write(x); Console.Write(y); Console.Write(Z); Console.Write(")");
                Console.WriteLine();
            }


            else if (a == "e")
            {
                Console.WriteLine("O Tupiniquim Moveu-se para o Oeste");
                Z = "O";
                Console.WriteLine();
                Console.Write("Orientação atual do Robô   ("); Console.Write(x); Console.Write(y); Console.Write(Z); Console.Write(")");
                Console.WriteLine();
            }


            else if (Z == "N" && a == "m")

            {
                y = y + 1;

                Console.WriteLine();
                Console.Write("Orientação atual do Robô   ("); Console.Write(x); Console.Write(y); Console.Write(Z); Console.Write(")");
                Console.WriteLine();


            }

            else if (Z == "O" && a == "m")


            {

                if (x == 0)
                {
                    Console.WriteLine("Impossível, X já é zero");
                }

                else
                {
                    x = x - 1;
                    Console.WriteLine();
                    Console.Write("Orientação atual do Robô   ("); Console.Write(x); Console.Write(y); Console.Write(Z); Console.Write(")");
                    Console.WriteLine();

                }

            }

            else if (Z == "L" && a == "m")


            {

                if (x == 0)
                {
                    Console.WriteLine("Impossível, X já é zero");
                }

                else
                {
                    x = x + 1;
                    Console.WriteLine();
                    Console.Write("Orientação atual do Robô   ("); Console.Write(x); Console.Write(y); Console.Write(Z); Console.Write(")");
                    Console.WriteLine();

                }



                Console.Write("O Tupiniquim Virou para o Oeste");

                Console.Write("     Posição atual: (", x, y, ")");





            }

            else if (Z == "S" && a == "m")


            {

                if (y == 0)
                {
                    Console.WriteLine("Impossível, X já é zero");
                }

                else
                {
                    y = y - 1;
                    Console.WriteLine();
                    Console.Write("Orientação atual do Robô   ("); Console.Write(x); Console.Write(y); Console.Write(Z); Console.Write(")");
                    Console.WriteLine();

                }




                Console.WriteLine("O Tupiniquim Moveu-se para o Oeste");





            }


           















            //Console.WriteLine("Digite o valor B");

            //b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite o valor C");

            //c = Convert.ToInt32(Console.ReadLine());



            //for (int i = 0; i < 5; i++)

            //{
            //    if (x[i] != y[i])
            //        {




            //    }




            //}



            //for (int j = 0; j < 5; j++)

            //{





            //}






















































































































































        }
    }
}
