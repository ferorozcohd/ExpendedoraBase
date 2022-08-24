using System;
using System.Threading;

namespace ExpendedoraBase
{
    class Expendedora
    {
        string marca;
        byte temperatura;
        string codigo;
        float precio;

        public Expendedora()
        {
            saludar();
            marca = "AMS";
            Console.WriteLine("Marca: " +marca);
            ControlarTiempoDisplay();
            temperatura = 14;
            Console.WriteLine("Temperatura: " + temperatura + "C°");
            ControlarTiempoDisplay();
            codigo = MostrarCodigodeProductos();
            MostrarPrecio(codigo);

        }

        void ControlarTiempoDisplay()
        {
            Thread.Sleep(2500);
            Console.Clear();
        }
            
            void saludar()
        { 
            Console.WriteLine("Bienvenido"); 
        }

        string MostrarCodigodeProductos()
        {
            Console.WriteLine("A1: Kinder Delice \tB2: Takis \tC3: Donitas");
            Console.WriteLine("Ingrese el Codigo del producto a elegir");
            string codigo = Console.ReadLine(); //"codigo" es una variable local
            return codigo;
        }

        void MostrarPrecio(string codigo)
        {
            switch (codigo) 
            {
                case "A1":
                    Console.WriteLine("el precio es: {0}", precio);
                    break;
                case "B2":
                    Console.WriteLine("el precio es: {0}", precio);
                    break;
                case "C3":
                    Console.WriteLine("el precio es: {0}", precio);
                    break;
                 default:
                    Console.WriteLine("el precio es: {0}", precio);
                    break;



            }
        }
        
    }
}
