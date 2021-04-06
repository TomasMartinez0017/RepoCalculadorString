using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraStrings
{
    public class Calculadora
    {
        public int Suma(string parametro)
        {
            int suma = 0;
            string[] sumandos = parametro.Split(',');
            if(sumandos[0] == "")
            {
                return suma;
            }
            else
            {
                for (int i = 0; i < sumandos.Length; i++)
                {
                    suma += Int32.Parse(sumandos[i]);
                }
                return suma;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Ingrese la cantidad de sumas");
            int cantSumas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numeros a sumar");
            int[] resultados = new int[cantSumas];
            for (int i = 0; i < cantSumas; i++)
            {
                string texto = Console.ReadLine();
                resultados[i] = calc.Suma(texto);
            }
            Console.WriteLine("Los ultimos 3 resultados son:");
            int cant = 3;
            int ultimaPos = resultados.Length - 1;
            while (cant != 0 && ultimaPos>=0)
            {
                Console.WriteLine(resultados[ultimaPos]);
                ultimaPos--;
                cant--;
            }
            Console.ReadLine();
        }
    }
}
