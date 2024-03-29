﻿using Microsoft.EntityFrameworkCore;
using Mod.TechnologyServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod.TechnologyServices.Context
{
    public class SkillsContext:DbContext
    {
        public SkillsContext(DbContextOptions<SkillsContext> options) : base(options)
        {

        }
        public DbSet<Skills> Skills { get; set; }
    }
}
