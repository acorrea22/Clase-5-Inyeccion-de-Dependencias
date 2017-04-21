using System;
using System.Collections.Generic;

namespace Lupi.Data.Entities
{
    public class Breed
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string HairType { get; set; }
        public List<string> HairColors { get; set; }

    }
}