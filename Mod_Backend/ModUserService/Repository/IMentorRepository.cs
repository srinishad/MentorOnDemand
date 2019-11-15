using Mod.UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.UserService.Repository
{
   public interface IMentorRepository
    {
        void Add(Mentor item);
        List<Mentor> GetAll();
        Mentor GetById(int id);
        void Update(Mentor item);
        void Delete(int id);
        void Block(int id);
    }
}
