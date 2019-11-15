using Mod.TechnologyServices.Context;
using Mod.TechnologyServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TechnologyServices.Repository
{
    public class SkillsRepository:ISkillsRepository
    {
        private readonly SkillsContext _context;
        public SkillsRepository(SkillsContext context)
        {
            _context = context;
        }

        public void Add(Skills item)
        {
            _context.Skills.Add(item);
            _context.SaveChanges();
        }

        public List<Skills> GetAll()
        {
            return _context.Skills.ToList();
        }

        public Skills GetById(int id)
        {
            return _context.Skills.Find(id);
        }

        public void Update(Skills item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
