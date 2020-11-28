using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Entrar via teclado com a base e a altura de um retângulo, calcular e exibir sua área.

            Retangulo ret = new Retangulo();

            Console.Write("Informe a base do retângulo: ");
            ret.setBase(double.Parse(Console.ReadLine()));

            Console.Write("Informe a altura do retângulo: ");
            ret.setAltura(double.Parse(Console.ReadLine()));

            ret.calcularArea();

            Console.WriteLine("O retângulo tem área igual a {0} ", ret.getArea());
            Console.ReadKey();
        }

    }
    }

