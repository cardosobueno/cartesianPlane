using System;
using System.Globalization;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool loop = true;      
            planoCartesiano pl = new planoCartesiano();
            Console.WriteLine("Bem vindo. Preparamos um plano cartesiano (-6, 6).\nVocê deve marcar um ponto nesse plano. ");
            pl.montarPlanoCartesiano();
            int valorX = 0; 
            int valorY = 0;
            do{
                
                try
                {   
                    do{
                    Console.WriteLine("\nDigite a posição x do plano cartesiano (min -6, max 6): ");
                    valorX = int.Parse(Console.ReadLine());
                    }while(valorX > 6 || valorX < -6 );
                    do{
                    Console.WriteLine("Digite a posição Y do plano cartesiano (min -6, max 6): ");
                    valorY = int.Parse(Console.ReadLine());
                    }while(valorY > 6 || valorY < -6);
                    pl.setX(valorX);
                    pl.setY(valorY);
                    loop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nDigite apenas números inteiros!");
                    loop = true;
                }
                catch(OverflowException)
                {
                    Console.WriteLine("\nNúmero muito grande! tente novamente");

                }
                
            }while(loop == true);


            Console.WriteLine("\nMontando plano cartesiano: ");
            pl.montarPlanoCartesiano();
            
            valorX = pl.getX();
            valorY = pl.getY();
            Console.WriteLine("Posição do ponto: x = "+ valorX + ", y = " + valorY);


        }
    }
}