using HarryPotter.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter.MainApplication.Services
{
    public interface ISpellRepository
    {
        Task<ICollection<Spell>> GetAllSpells();
    }
}
