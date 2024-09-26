// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

//public class Program
//{
//    public static void Main()
//    {
//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine("Digite um número" );
//            int x = Convert.ToInt32(Console.ReadLine());
//            if (x % 2 == 0)
//            {
//                Console.WriteLine("O número " + x + "é par");
//            }
//            else
//            {
//                Console.WriteLine("O número " + x + "é ímpar");
//            }
//        }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {   //  FC = (°F - 32) × 5/9
//        Console.WriteLine("Digite a temperatura em Fahrenheit: ");
//        double fahrenheit = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("A temperatura em graus Celsius é: " + (fahrenheit-32) * 5/9);

//    }
//}

public class Program
{
    public static void Main()
    {
            int a = 2, b = 1, c = 5;
            int maior;
            int medio;
            int menor;

            if (a > b && a > c)
            {
               if (b > c) {
                maior = a;
                medio = b;
                menor = c;

                Console.WriteLine($"{maior} {medio} {menor}");
            }
               else
            {
                maior = a;
                medio = c;
                menor = b;

                Console.WriteLine($"{maior} {medio} {menor}");
            }
            }
            if (b > a && b > c)
            {
                if (a > c)
            {
                maior = b;
                medio = a;
                menor = c;

                Console.WriteLine($"{maior} {medio} {menor}");
            }
                else
            {
                maior = b;
                medio = c;
                menor = a;

                Console.WriteLine($"{maior} {medio} {menor}");
            }
            }
            else
            {
            if (b > a)
            {
                maior = c;
                medio = b;
                menor = a;

                Console.WriteLine($"{maior} {medio} {menor}");
            }
            else 
            {
                maior = c;
                medio = a;
                menor = b;

                Console.WriteLine($"{maior} {medio} {menor}");
            }
    
            }

    

    }
}