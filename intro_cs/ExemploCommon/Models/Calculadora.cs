using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace intro_cs.Models
{
    public class Calculadora
    {

//Calculando Somar
        public void Somar(int x, int y) {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

//Calculando Subtração
        public void Subtrair(int x, int y) {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

//Calculando Multiplicação
        public void Multiplicar(int x, int y) {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
    
//Calculando Divisão
        public void Dividir(int x, int y) {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

//Calculando Potencia
        public void Pontencia(int x, int y) {
            double potencia = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }

//Calculando Seno
        public void Seno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} graus = {Math.Round(seno, 2)}");
        }

//Calculando Coseno
        public void Coseno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Seno de {angulo} graus = {Math.Round(coseno, 2)}");
        }

//Calculando Tangete
        public void Tangente(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Seno de {angulo} graus = {Math.Round(tangente, 2)}");
        }

//Calculando RaizQuadrada
        public void RaizQuadrada(double x) {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}
