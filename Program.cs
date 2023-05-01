using System;
using System.Globalization;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            planoCartesiano pl = new planoCartesiano();
            Console.WriteLine("Bem vindo. Preparamos um plano cartesiano (-6, 6).\nVocê deve marcar um ponto nesse plano. ");
            pl.montarPlanoCartesiano();
            Console.WriteLine("\nDigite a posição x do plano cartesiano: ");
            pl.setX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a posição Y do plano cartesiano: ");
            pl.setY(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nMontando plano cartesiano: ");
            pl.montarPlanoCartesiano();
            
            int valorX = pl.getX();
            int valorY = pl.getY();
            Console.WriteLine("Posição do ponto: x = "+ valorX + ", y = " + valorY);


        }
    }
}