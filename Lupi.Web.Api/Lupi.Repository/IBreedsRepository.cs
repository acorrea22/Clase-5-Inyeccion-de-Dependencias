using Lupi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lupi.Repository
{
    public interface IBreedsRepository
    {
        IEnumerable<Breed> GetAll();
        Breed GetByID(Guid id);
        void Add(Breed breed);
        bool DeleteById(Guid id);
        bool Update(Guid id, Breed newBreed);

    }
}
