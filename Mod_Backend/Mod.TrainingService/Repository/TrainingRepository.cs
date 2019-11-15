using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mod.TrainingService.Context;
using Mod.TrainingService.Models;

namespace Mod.TrainingService.Repository
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }
        public void Add(Training item)
        {
            _context.Training.Add(item);
            _context.SaveChanges();
        }

        public void Update(Training item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

        }
        public List<Training> GetAll()
        {
            return _context.Training.ToList();
        }

        public Training GetById(int id)
        {
            return _context.Training.Find(id);
        }
    }
}
