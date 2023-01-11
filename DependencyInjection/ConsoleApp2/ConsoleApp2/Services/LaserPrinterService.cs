using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Entity;

namespace ConsoleApp2.Services
{
    public class LaserPrinterService : IPrinter
    {
        public void Print(Pokemon pokemon, string message)
        {
            Console.WriteLine($"Se imprime en impresora laser el nombre {pokemon.name}.");
            Console.WriteLine(message);
        }
    }
}
