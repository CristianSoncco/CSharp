using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Entity;

namespace ConsoleApp2.Services
{
    public interface IPrinter
    {
        void Print(Pokemon pokemon, string message);
    }
}
