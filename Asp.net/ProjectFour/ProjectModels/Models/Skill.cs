using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectModels.Models
{
    public class Skill
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public List<Character> Characters { get; set; }
    }
}