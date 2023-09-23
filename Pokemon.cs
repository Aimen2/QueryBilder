using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    // Models/Pokemon.cs

    public class Pokemon : Models.IClassModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }

        // Add any other properties specific to the Pokemon table if needed
    }

}
