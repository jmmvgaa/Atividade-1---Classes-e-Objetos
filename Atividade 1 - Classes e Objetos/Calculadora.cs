using System;
using System.Collections.Generic;

namespace Atividade_1___Classes_e_Objetos
{
    public class Calculadora
    {
        private List<Double> listNumero = new List<double>();

        public void addNumero(Double num)
        {
            this.listNumero.Add(num);
        }
        public double somar()
        {
            double resultado = 0;
            foreach (double numero in this.listNumero)
            {
                resultado += numero;

            }
            this.listNumero.Clear();
            return resultado;
            
        }
        public double subtrair()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach(double numero in this.listNumero)
            {
                resultado -= numero;
            }
            this.listNumero.Clear();
            return resultado;

        }
        public double multiplicar()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado *= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }
        public double dividir()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado /= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }
        public double raizquadrada()
        {
            double resultado = this.listNumero[0];
      
            foreach (double numero in this.listNumero)
            {
                resultado = Math.Sqrt(numero);
            }
            this.listNumero.Clear();
            return resultado;
        }
    }
}
