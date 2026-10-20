using CRUDWinFormsMVPP.Models;
using System;
using System.Text;
using System.Collections.Generic;

namespace MvpCrudApp.Models
{
    public interface IPetRepository
    {
        void Add(PetModel petModel);
        void Edit(PetModel petModel);
        void Delete(int id);
        IEnumerable<PetModel> GetAll();
        IEnumerable<PetModel> GetByValue(string value);
    }
}