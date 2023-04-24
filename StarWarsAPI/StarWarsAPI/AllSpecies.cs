using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsAPI
{
    class AllSpecies
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Species> results {get; set;}
    }
}
