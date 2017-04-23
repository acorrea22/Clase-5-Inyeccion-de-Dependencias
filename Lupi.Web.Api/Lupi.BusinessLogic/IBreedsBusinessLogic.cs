using Lupi.Data.Entities;
using System;
using System.Collections.Generic;

namespace Lupi.BusinessLogic
{
    public interface IBreedsBusinessLogic
    {
        IEnumerable<Breed> GetAllBreeds();
        Breed GetByID(Guid id);
        void Add(Breed breed);
        bool Delete(Guid id);
        bool Update(Guid id, Breed newBreed);
    }
}