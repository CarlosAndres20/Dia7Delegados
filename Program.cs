using System;
using System.Collections.Generic;
//-------------------------------
//-----------Delegados-----------
//-------------------------------
namespace Dia7Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Proyecto pro = new Proyecto();
            
            Console.ReadKey();
            //pro.AgregarProyecto();
            //pro.AgregarProyecto2();
            pro.Imprimir();
            //Delegados (1.1)

            //Func<double, double, double> raiz = CalcularRaiz;
            //double pr=raiz(8, 2);
            //Console.WriteLine($"Raiz de {pr}");
            //Func<double, double, double> potencia = (x, y) => { return Math.Pow(x, y); };
            //Console.WriteLine($"Raiz con landa {potencia(8,2)}");
            //Func<int, int> doble = x => { return x *= 2; };
            //Console.WriteLine($"Multiplicación con landa {doble(8)}");
            

        }
        public static double CalcularRaiz(double bas,double exp)
        {
            return Math.Pow(bas, exp);
        }
    }
}
