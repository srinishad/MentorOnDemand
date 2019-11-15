using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mod.UserService.Context;
using Mod.UserService.Models;

namespace Mod.UserService.Repository
{
    public class MentorRepository : IMentorRepository
    {

        private readonly UserContext _context;
        public MentorRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(Mentor item)
        {

            _context.Mentor.Add(item);
            _context.SaveChanges();
        }

        public void Block(int id)
        {
            var item = _context.Mentor.Find(id);
            item.MentorActive = !(item.MentorActive);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Mentor.Find(id);
            _context.Mentor.Remove(item);
            _context.SaveChanges();
        }

        public List<Mentor> GetAll()
        {
            return _context.Mentor.ToList();
        }

        public Mentor GetById(int id)
        {
            return _context.Mentor.Find(id);
        }

        public void Update(Mentor item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
       
    }
}
