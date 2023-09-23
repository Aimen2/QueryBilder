using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    // Models/BannedGame.cs

    public class BannedGame : Models.IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Reason { get; set; }
        public DateTime DateBanned { get; set; }

        // Add any other properties specific to the BannedGame table if needed
    }

}
