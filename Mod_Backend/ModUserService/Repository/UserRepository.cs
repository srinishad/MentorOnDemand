using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mod.UserService.Context;
using Mod.UserService.Models;

namespace Mod.UserService.Repository
{
    public class UserRepository : IUserRepository

    {
        private readonly UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(User item)
        {
            _context.User.Add(item);
            _context.SaveChanges();
        }

        public void Block(int id)
        {
            var item = _context.User.Find(id);
            item.UserActive = !(item.UserActive);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public List<Mentor> SearchMentor(string MentorSkills)
        {
            //return _context.Mentors.Find(MentorSkills);

            return _context.Mentor.Where(i => i.MentorSkills == MentorSkills).ToList();

        }

        public void Delete(int id)
        {
            var item = _context.User.Find(id);
            _context.User.Remove(item);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.User.ToList();
        }

        public User GetById(int id)
        {
            return _context.User.Find(id);
        }

        public void Update(User item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
     
    }
}
