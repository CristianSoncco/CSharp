using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entity
{
    public class PokemonRes
    {
        public int count { get; set; }
        public string   next { get; set; }
        public string? previous { get; set; }
        public List<Pokemon> results{ get; set; }

    }
}
