using System;
using System.Collections.Generic;

namespace Lupi.Data.Entities
{
    public class Owner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Pet> Pets { get; set; }
        public List<Collar> Collars { get; set; }
    }
}