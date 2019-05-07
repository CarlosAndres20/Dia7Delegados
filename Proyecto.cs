﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dia7Delegados
{
    class Proyecto
    {
        public List<Proyecto> proyectos = new List<Proyecto>();
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        public List<Proyecto> AgregarProyecto() {
            Console.WriteLine("Escriba y para ingresar");
            var res = Console.ReadLine();
            while (res=="y")
            {
                Console.WriteLine("Escriba el nombre del proyecto");
                var nom = Console.ReadLine();
                Console.WriteLine("Escriba código del proyecto");
                var cod = Console.ReadLine();
                var miProyecto = new Proyecto()
                {
                    Nombre = nom,
                    Codigo = int.Parse(cod)
                };
                proyectos.Add(miProyecto);
                Console.WriteLine("Escriba y para ingresar");
                res = Console.ReadLine();
            }
            return proyectos;
        }
        public List<Proyecto> AgregarProyecto2()
        {
            var proys = new List<Proyecto>() {
                new Proyecto()
            {
                Nombre = "Bancaria",
                Codigo = 3,
                Area="Comercio",
                Duracion=12
            },
                new Proyecto()
            {
                Nombre = "Mercadeo",
                Codigo = 23,
                Area="Talento Humano",
                Duracion=6
            },
                 new Proyecto()
            {
                Nombre = "Atencion Primera",
                Codigo = 23,
                Area="AIPI",
                Duracion=18
            }
        };
            return proys;
            
        }
        public void Imprimir() {
            proyectos = AgregarProyecto2();
            Console.WriteLine($"Esta es la lista:");
            foreach (var item in proyectos)
            {
                if (item.Codigo>=20)
                {
                    Console.WriteLine($"Nombre: {item.Nombre}");
                    Console.WriteLine($"Nombre: {item.Codigo}");
                    Console.WriteLine($"Nombre: {item.Area}");
                    Console.WriteLine($"Nombre: {item.Duracion}");
                }
                //Console.WriteLine($"Esta es la lista: {item.Nombre}{item.Codigo}{item.Area}{item.Duracion}");
            }
        }
    }
}
