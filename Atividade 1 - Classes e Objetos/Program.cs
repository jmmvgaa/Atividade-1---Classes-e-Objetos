using System;
using System.Collections.Generic;

namespace Atividade_1___Classes_e_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Calculadora num2 = new Calculadora();
            Console.WriteLine("Insira 2 numeros para serem SOMADOS: ");
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" = " + num2.somar());

            Console.WriteLine("Insira 2 numeros para serem SUBTRAIDOS: ");
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" = "+num2.subtrair());

            Console.WriteLine("Insira 2 numeros para serem MULTIPLICADOS: ");
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" = " + num2.multiplicar());

            Console.WriteLine("Insira 2 numeros para serem DIVIDIDIS: ");
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" = " + num2.dividir());

            Console.WriteLine("Insira  numero para ver sua RAIZ QUADRADA: ");
            num2.addNumero(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" = " + num2.raizquadrada());
            

        }
    
    }
}
