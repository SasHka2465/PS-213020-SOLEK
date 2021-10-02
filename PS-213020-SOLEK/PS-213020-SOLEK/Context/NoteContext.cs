using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PS_213020_SOLEK.Models;

namespace PS_213020_SOLEK.Contexts
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> option) : base(option)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
