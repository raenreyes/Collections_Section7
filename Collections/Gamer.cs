using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Gamer
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int rank { get; set; }
        

        public Gamer(string role, string name, int rank) { 
            this.Role = role;
            this.Name = name;
            this.rank = rank;
        }
    }
}
