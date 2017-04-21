using System;

namespace Lupi.Data.Entities
{
    public class Collar
    {
        public Guid Id { get; set; }

        public Owner AssociatedOwner { get; set; }

    }
}